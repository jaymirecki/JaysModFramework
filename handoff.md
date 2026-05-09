# Framework Design Handoff

This document summarizes a design conversation for a GTA V singleplayer RPG framework. It is intended to provide context for continuing work in Claude Code.

---

## Project Vision

A singleplayer GTA V modding framework that enables RPG-style game conversions on top of the base game. The framework acts as an engine layer: it provides systems, and content is defined in data. Plugins built on the framework interact with clean interfaces rather than raw GTA natives.

A secondary goal is **GTA VI portability**: if the native interaction layer is kept thin and behind interfaces, the framework has a credible path to being lifted onto GTA VI when its modding tools mature.

---

## Technical Foundation

### Runtime Target: RAGEPluginHook (RPH)

RPH is chosen over ScriptHookV.NET (SHVDN) primarily for its **GameFiber** threading model. Rather than a tick-based `OnTick()` loop requiring manual state machines, RPH allows long-running logic to be written as sequential, blocking code:

```csharp
GameFiber.StartNew(() =>
{
    while (!runway.HasFreeSlot())
        GameFiber.Yield();

    var plane = SpawnPlane(spawnPoint);
    TaxiToRunway(plane);
    GameFiber.Sleep(15000);
    plane.Delete();
});
```

This is critical for background simulations (e.g. airport traffic) where multiple concurrent lifecycles run simultaneously. Each gets its own fiber; no shared state machine required.

RPH does support per-frame evaluation via a `GameFiber` yield loop, and the framework implements a central `TickManager` that dispatches to registered `ITickable` systems each frame.

**Engine agnosticism is a design goal.** All GTA API interactions are routed through abstraction interfaces. RPH is the initial concrete implementation. SHVDN support could be added later by implementing the same interfaces.

### Testing Strategy

The framework cannot be tested against a running game. All testability is achieved via **dependency inversion**: game interactions are abstracted behind interfaces, with fake implementations used in tests.

Key principle: `YourFramework.Core` has **zero references** to RPH or GTA dlls. Tests run in a standard .NET test runner with no game present.

```
YourFramework.Core        // interfaces + business logic, no RPH/GTA references
YourFramework.Rph         // RPH implementations of Core interfaces
YourFramework.Tests       // xUnit/NUnit, references Core only
YourPlugin.*              // plugins reference Core, use injected interfaces
```

Fake implementations (e.g. `FakeVehicle`, `FakeFiberService`) record calls and expose them for assertion. `FakeFiberService.StartNew()` runs fibers synchronously in tests.

---

## Core Architecture

### Entity System

Two identity systems exist simultaneously:

- **Stable ID (GUID)** — assigned by the framework, lives in XML, survives sessions
- **Runtime Handle** — GTA's entity handle, ephemeral, only valid this session

The registry maps between them and is responsible for re-spawning entities when loading a session from save.

#### Entity Class Design

```csharp
public abstract class EntityDefinition
{
    public Guid Id { get; set; }
    public string Tag { get; set; }
    public Vector3 Position { get; set; }
    public Vector3 Rotation { get; set; }
    public bool PersistAcrossSessions { get; set; }
    public EntitySpawnCondition SpawnCondition { get; set; }
}

public abstract class ManagedEntity<TDefinition, TNativeEntity>
{
    public Guid Id => Definition.Id;
    public TDefinition Definition { get; }
    public TNativeEntity NativeEntity { get; private set; }
    public bool IsSpawned { get; }

    public void AttachNativeEntity(TNativeEntity entity);
    public void Detach();
}
```

Concrete types: `ManagedProp` / `PropDefinition`, `ManagedVehicle` / `VehicleDefinition`, `ManagedPed` / `PedDefinition`.

#### Live-Backed Properties

Properties are backed by the native handle when spawned, and by a private field when not. This avoids a separate sync-on-save step for framework-controlled properties:

```csharp
// Framework-controlled: live-backed is safe
public VehicleColor PrimaryColor
{
    get => _primaryColor;
    set { _primaryColor = value; if (IsSpawned) NativeEntity.SetPrimaryColor(value); }
}

// Engine-mutable (physics, player input): always read from handle when spawned
public Vector3 Position
{
    get => IsSpawned ? NativeEntity.Position : _position;
    set { _position = value; if (IsSpawned) NativeEntity.Position = value; }
}
```

Position and heading are engine-mutable and always read live from the handle when spawned. On save, these are read from the handle directly if spawned, from the backing field if not.

#### Entity Persistence: Transient vs. Persistent

Entities fall into two categories:

- **Session-persistent**: player's owned vehicle, companions, quest-critical peds. Tracked in save file, restored on load.
- **Map-local (transient)**: ambient peds, police cars at a police station, decorative props. Spawned when the map loads, reset when the map reloads. Not individually tracked in save.

#### Vehicle Custody Model

A three-state custody model handles the edge case of a player driving off in a map-owned vehicle:

```csharp
public enum VehicleCustody
{
    MapOwned,       // spawned by map, player hasn't interacted
    PlayerCustody,  // player has driven it away; can't despawn
    PlayerOwned,    // explicitly stored/claimed by player
}
```

- `MapOwned` → `PlayerCustody`: player enters and drives beyond a distance threshold, or map tries to reset while player is in it
- `PlayerCustody` → `PlayerOwned`: player explicitly stores it
- `PlayerCustody` → cleanup: player out of vehicle for X time AND beyond Y distance
- `PlayerOwned` is never cleaned up by map resets

### Entity Registry

```csharp
public class EntityRegistry
{
    public ManagedProp RegisterProp(PropDefinition definition);
    public ManagedVehicle RegisterVehicle(VehicleDefinition definition);
    public ManagedPed RegisterPed(PedDefinition definition);

    public void SpawnAll();       // spawns all entities meeting their spawn condition
    public void DespawnAll();

    public ManagedPed GetPed(Guid id);
    public ManagedVehicle GetVehicle(Guid id);
    public ManagedProp GetProp(Guid id);
}
```

Cross-references between entities (e.g. a ped assigned to a vehicle) use stable GUIDs, resolved after all entities are registered.

### Save/Load

Save files serialize **definitions**, not handles. On load, entities are re-spawned from definitions.

```csharp
public class RegistrySnapshot
{
    public List<PropDefinition> Props { get; set; }
    public List<VehicleDefinition> Vehicles { get; set; }
    public List<PedDefinition> Peds { get; set; }
}
```

Flow:
1. Deserialize definitions from XML
2. Register all entities (no spawning yet)
3. `SpawnAll()` — spawns entities meeting their spawn condition

### Spawn Conditions

```csharp
public class EntitySpawnCondition
{
    public float? MaxDistanceFromPlayer { get; set; }
    public string RequiredSaveFlag { get; set; }
    public TimeRange? ActiveTimeOfDay { get; set; }
    public WeatherCondition? RequiredWeather { get; set; }
}
```

The tick manager evaluates conditions each frame and despawns/respawns entities as conditions change — a lightweight streaming system on top of GTA's own.

---

## Data-Driven Content

Available content (vehicles, ped models, props, outfits, weapons) is defined in XML. No recompilation is required to support new models from GTA Online updates or modded add-on content. Model names are treated as opaque strings resolved at runtime.

**This principle applies to content, not mechanics.** If a GTA update introduces new native functions or gameplay systems, a framework update is required. This is an explicit and accepted boundary.

---

## Interior System

Interiors are explicitly **not** data-driven. GTA V interiors vary too much in activation requirements (MLO, IPL, entity sets, custom sequences) to generalize cleanly into config.

Instead:
- Interiors are codified as an `InteriorId` enum
- Each interior's activation logic is fully encapsulated in a handler class implementing `IInteriorHandler`
- Map XML files reference interiors by enum name only — activation details never appear in content files

```csharp
public enum InteriorId
{
    HighEndApartment_1,
    Casino,
    PoliceStation_MissionRow,
    // ...
}

public interface IInteriorHandler
{
    Vector3 EntryPoint { get; }
    void Activate();
    void Deactivate();
}
```

The `InteriorFactory` maps each `InteriorId` to its handler. Common cases use a generic `MloInterior` or `IplInterior` handler parameterized with the right values. Edge cases (e.g. Casino) get a dedicated handler class.

Adding a new interior: add enum entry, implement/configure handler, register in factory. Small, explicit, checklist-driven.

---

## World Architecture

### Hierarchy

```
Worldspace
  └── Maps (one or more)
        ├── Required Interiors (by InteriorId enum)
        ├── Props
        ├── Peds (map-local)
        └── Vehicles (map-local)
```

### Worldspaces

A worldspace represents a **contiguous fictional region** the player can travel across without loading screens (e.g. San Andreas, Cayo Perico, Liberty City/Alderney, Vice City).

Key design principle: **worldspace is a fictional geography concept, not a technical map-loading concept.** The "Alderney" worldspace might use the standard San Andreas GTA map geometry, dressed differently via props, IPLs, and ambient config. The worldspace definition describes the fiction; the map/prop/interior system handles the technical realization.

```csharp
public class WorldspaceDefinition
{
    public string Id { get; set; }
    public string DisplayName { get; set; }
    public GtaMapRegion BaseMapRegion { get; set; }  // SanAndreas, CayoPerico, NorthYankton
    public List<string> MapIds { get; set; }
    public WorldspaceAmbientConfig Ambient { get; set; }
    public List<TransitionPointDefinition> TransitionPoints { get; set; }
    public WorldspaceTravelRestrictions TravelRestrictions { get; set; }
}
```

### Transition Points

Transition points connect worldspaces. Each has two sides (entry/exit) that reference each other by ID. Trigger types: proximity zone, map edge crossing (direction-based, for aircraft), interaction point.

Transition types: fade out/in, tunnel (darkness masks transition), seamless air (map edge crossing), loading screen.

Travel restrictions can be conditional on: allowed travel methods (foot/road/air/sea), save flags, inventory items.

### Maps

A map is a specific location or scene within a worldspace.

```xml
<Map id="police_hq" displayName="Mission Row Police HQ"
     spawnX="428.0" spawnY="-982.0" spawnZ="30.7">
  <RequiredInteriors>
    <Interior ref="PoliceStation_MissionRow" />
  </RequiredInteriors>
  <Props>
    <Prop model="prop_cs_police_radio" x="432.1" y="-980.3" z="30.7" />
  </Props>
  <Peds>
    <Ped model="mp_m_freemode_01" tag="Desk_Sergeant" ... outfit="police_standard" />
  </Peds>
</Map>
```

Interiors are loaded before entities are spawned (entities may depend on the interior geometry existing).

### Open Questions: World

- **Entity handoff across transitions**: player's owned vehicle presumably travels with them; companion peds may need explicit "call to worldspace" behavior
- **Ambient config transitions**: does weather change immediately on worldspace transition or gradually?
- **Worldspace streaming**: maps likely need to activate/deactivate based on player proximity rather than all loading at once

---

## RPG Systems

### Player Ped

The player always uses the multiplayer freemode ped model (`mp_m_freemode_01` / `mp_f_freemode_01`), enabling full outfit and appearance customization.

### Outfit / Closet System

Outfits are composed of drawable components (slots 0–11) plus props (hat, glasses, etc.), head blend data (face shape), and head overlays (makeup, hair color, tattoos). All are modelled as first-class parts of the `Outfit` object.

Outfits have an ownership state: `Owned`, `Locked`, `Preview`. Unlock conditions can be tied to save flags or mission progression.

The `PedRegistry` tracks all mod-managed peds and their current outfit, enabling save/restore of appearance across sessions.

### Inventory

Applies to player ped, other managed peds, and vehicles. Items and weapons are tracked per-entity in save data. Item definitions are data-driven (XML).

### Mission / Quest System

Missions are defined as a series of stages and objectives in XML, inspired by how Skyrim models quests: stages, conditions, and world-state consequences rather than purely scripted linear sequences.

Completion of a stage can trigger: loading a map, setting a save flag, unlocking another mission, spawning entities, modifying world state.

Branching is a goal. A non-voiced dialogue system is a named dependency of the quest system (quests can invoke dialogue; the two subsystems are otherwise separate).

The quest system is **not a dependency for other systems** and can be implemented later. Other systems (spawn conditions, map availability) query quest state via save flags, which are a simpler primitive.

---

## Planned Plugins

These are example plugins that will be built on the framework:

### Siren Manager
Allows siren lights to remain active while sound is muted. Key native: `SET_VEHICLE_HAS_MUTED_SIRENS`. Models siren patterns (off, lights only, slow wail, yelp, manual) as a state machine. State logic is fully testable; only the final native calls require a real implementation.

### Vehicle Spawner
Spawns vehicles at configurable locations relative to the player. Handles async model loading (request → yield → spawn). Maintains a favorites/history list in XML. Validates spawn position (road, interior, etc.).

### Closet / Outfit Manager
Menu-driven outfit switching for the player and mod-managed peds. Tied to the save system for outfit ownership. Supports the full MP ped component/prop/overlay model.

---

## Key Architectural Principles (Summary)

1. **Stable IDs over native handles** — GUIDs are the source of truth; handles are ephemeral
2. **Definitions are serialized, not handles** — save files capture definitions; entities are re-spawned on load
3. **Engine-mutable properties read live** — position/heading always read from handle when spawned
4. **Register then spawn** — entities are defined before the world is ready; spawned when conditions are met
5. **Business logic is engine-free** — core framework has no RPH/GTA dependency; fully unit-testable
6. **Content is data; mechanics are code** — new models via XML; new game systems require compilation
7. **Interiors are code, not config** — too varied to generalize; enum + factory + handler pattern
8. **Worldspace is fiction; map is technical** — the fictional region and the GTA geometry it uses are separate concerns
9. **GTA VI portability** — the abstraction layer is the porting boundary; only RPH implementations get rewritten

---

## Suggested Documentation Structure for the Repo

```
/docs
  architecture/
    overview.md
    entity-system.md
    world-architecture.md
    save-load.md
    testing-strategy.md
    interior-system.md
    quest-system.md
  plugins/
    siren-manager.md
    vehicle-spawner.md
    outfit-manager.md
  decisions/
    rph-vs-shvdn.md
    interiors-not-data-driven.md
    gta6-portability.md
```

Architecture decision records (ADRs) in `/docs/decisions/` are worth establishing early — several decisions made in this conversation have non-obvious reasoning that will be valuable to capture before it's forgotten.