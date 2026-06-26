---
type: technical-design
feature: save-load
status: in-progress
related:
  - entity-system
  - world-architecture
  - data-model
---

# Save/Load — Technical Design

## Core Principle

Save files serialize **definitions**, not runtime handles. GTA native entity handles are ephemeral — valid only within a session and unusable across restarts. The framework stores everything needed to fully re-create the world from scratch.

---

## Save File Structure

Each save is a named directory under `JMF/Saves/`. All cross-entity references use stable framework GUIDs — never GTA handles.

```
JMF/Saves/
  {save-name}/
    world.xml         ← WorldState: weather, datetime, worldspace, active map
    player.xml        ← PlayerState: position, heading, health, ped model
    flags.xml         ← SaveFlags: key/value boolean progression state
    Vehicles/
      {guid}.xml      ← one PersistentVehicle per file
    Peds/
      {guid}.xml      ← one PersistentPed per file
    Props/
      {guid}.xml      ← one PersistentProp per file
```

Each entity is written as a separate file, keyed by its stable GUID. This matches the one-file-per-content-item convention used in `Data/` (see [ADR-0004](../../architecture/decisions/adr-0004-one-file-per-content-item.md)).

---

## Class Design

### GameState

`GameState` is the top-level coordinator. It holds a reference to `WorldServices` and uses it to both read state (on save) and write state (on load).

```csharp
public class GameState
{
    private readonly WorldServices _world;

    public GameState(WorldServices world)
    {
        _world = world;
    }

    // Read from _world; write to savePath/
    public void Save(string savePath);

    // Read from savePath/; apply to _world
    public void Load(string savePath);
}
```

`GameState` delegates each sub-system to a dedicated state object. It does not serialize anything directly — it orchestrates.

---

### WorldState

`WorldState` holds flat, top-level world properties. No nested entity objects.

```csharp
public class WorldState
{
    public string WorldspaceId { get; set; }
    public string ActiveMapId { get; set; }
    public WeatherType Weather { get; set; }
    public GameDateTime DateTime { get; set; }
}
```

Serialized to `world.xml`:

```xml
<WorldState>
  <WorldspaceId>SanAndreas</WorldspaceId>
  <ActiveMapId>police_hq</ActiveMapId>
  <Weather>Clear</Weather>
  <DateTime>
    <Hour>14</Hour>
    <Minute>30</Minute>
    <Day>15</Day>
    <Month>10</Month>
    <Year>2024</Year>
  </DateTime>
</WorldState>
```

---

### PlayerState

`PlayerState` stores the player ped's full runtime state. The player ped is **not** in the ped registry — spawning and changing the player ped is a distinct native operation, not the same as spawning an NPC ped.

`CharacterName` is a player-facing display name set during the new-game flow. It drives save slot naming (see [Save Slot Management](#save-slot-management)) and is not the same as `ModelName`.

`PlayerState` embeds a full `PersistentPed` object rather than duplicating individual ped properties. This means any new property added to `PersistentPed` (health, armor, current vehicle, outfit, etc.) is automatically included in player saves without modifying `PlayerState`.

```csharp
public class PlayerState
{
    public string CharacterName { get; set; }  // Player-set display name; drives slot naming
    public PersistentPed Ped { get; set; }     // Full ped snapshot
}
```

Serialized to `player.xml`:

```xml
<PlayerState>
  <CharacterName>Michael</CharacterName>
  <Ped>
    <ModelName>mp_m_freemode_01</ModelName>
    <Position x="428.0" y="-982.0" z="30.7" />
    <Heading>270.0</Heading>
    <Health>200</Health>
    <Armor>100</Armor>
  </Ped>
</PlayerState>
```

#### Player Load Order

The player ped requires a specific application order on load because changing the model replaces the underlying native ped object:

```
1. Set player model to Ped.ModelName   ← model change must happen first
2. Copy all remaining Ped properties   ← applied to the new native ped
   (Position, Heading, Health, Armor, CurrentVehicleId, etc.)
```

If properties were applied before the model change, they would be written to the old native ped and lost.

In templates, `CharacterName` is left empty. The new-game flow sets it after `GameState.Load()` returns.

---

### SaveFlags

`SaveFlags` is a flat key/value store of boolean progression states. It is the shared source of truth for quest progression, unlock states, and spawn conditions that reference flags.

```csharp
public class SaveFlags
{
    private readonly Dictionary<string, bool> _flags = new();

    public bool Get(string key) => _flags.TryGetValue(key, out var v) && v;
    public void Set(string key, bool value) => _flags[key] = value;
}
```

Serialized to `flags.xml`:

```xml
<SaveFlags>
  <Flag key="mission_01_complete" value="true" />
  <Flag key="apartment_owned" value="true" />
</SaveFlags>
```

---

### Registry State Objects

Each registry has a dedicated state object responsible for serializing and deserializing its entities. Each writes to its own subdirectory within the save folder, one file per entity.

```csharp
internal class VehicleRegistryState
{
    private const string DirectoryName = "Vehicles";

    // Write one {guid}.xml per vehicle to saveRoot/Vehicles/
    public void Save(string saveRoot, IEnumerable<Vehicle> vehicles);

    // Read all .xml files from saveRoot/Vehicles/; return deserialized definitions
    public IEnumerable<PersistentVehicle> Load(string saveRoot);
}

internal class PedRegistryState
{
    private const string DirectoryName = "Peds";

    public void Save(string saveRoot, IEnumerable<Ped> peds);
    public IEnumerable<PersistentPed> Load(string saveRoot);
}

internal class PropRegistryState
{
    private const string DirectoryName = "Props";

    public void Save(string saveRoot, IEnumerable<Prop> props);
    public IEnumerable<PersistentProp> Load(string saveRoot);
}
```

---

## Serialization Approach

All persistent classes are serialized using `System.Xml.Serialization.XmlSerializer`. The serializer reflects on all public properties automatically — no hand-written read/write code is required at the property level.

This means:
- **Adding a property** to `PersistentVehicle`, `PersistentPed`, or any other persistent class is the only step required to include it in saves. No changes to the save/load framework are needed.
- **Forward compatibility**: if a save file predates a new property, `XmlSerializer` leaves the property at its default value on load. Existing saves remain valid.
- **New entity types**: adding a new persistent class (e.g. `PersistentProp`) and a corresponding registry state object is sufficient to extend the system to a new entity type.

Each state object — `WorldState`, `PlayerState`, and the registry state objects — has real responsibilities beyond raw serialization:

- `WorldState` reads and writes world-level properties (weather, datetime, worldspace, active map) and explicitly does not touch the entity registries. Those are handled by their own state objects.
- Registry state objects manage directory creation, iterate over entities, trigger `SyncLiveToPersistent()` before writing, and handle cross-entity reference resolution on load.
- `PlayerState` applies loaded state to the player ped in a specific order (see below).

---

## Persistent Data Models

### PersistentVehicle

```csharp
public class PersistentVehicle : PersistentEntity
{
    // Inherited: Id (Guid), Position, Heading, ModelName, SpawnCondition
    public SirenState SirenState { get; set; }
    public VehicleCustody Custody { get; set; }
}
```

Example `Vehicles/{guid}.xml`:

```xml
<Vehicle id="3fa85f64-5717-4562-b3fc-2c963f66afa6">
  <ModelName>police3</ModelName>
  <Position x="428.1" y="-980.3" z="30.7" />
  <Heading>270.0</Heading>
  <SirenState>Off</SirenState>
  <Custody>PlayerOwned</Custody>
  <SpawnCondition>
    <RequiredSaveFlag>apartment_owned</RequiredSaveFlag>
  </SpawnCondition>
</Vehicle>
```

---

### PersistentPed

Cross-entity vehicle references use the vehicle's **framework GUID** and a seat index — not a nested object or a GTA handle.

```csharp
public class PersistentPed : PersistentEntity
{
    // Inherited: Id (Guid), Position, Heading, ModelName, SpawnCondition
    public Guid? CurrentVehicleId { get; set; }    // Framework GUID of the vehicle
    public int? CurrentVehicleSeatIndex { get; set; }
}
```

Example `Peds/{guid}.xml`:

```xml
<Ped id="7c9e6679-7425-40de-944b-e07fc1f90ae7">
  <ModelName>mp_m_freemode_01</ModelName>
  <Position x="428.1" y="-980.3" z="30.7" />
  <Heading>90.0</Heading>
  <CurrentVehicleId>3fa85f64-5717-4562-b3fc-2c963f66afa6</CurrentVehicleId>
  <CurrentVehicleSeatIndex>0</CurrentVehicleSeatIndex>
</Ped>
```

If `CurrentVehicleId` is present, it is resolved to a live vehicle after all entities have been registered (see Cross-Entity Reference Resolution below).

---

## Save Flow

```
GameState.Save(savePath)
  │
  ├── 1. SyncLiveToPersistent() on all spawned entities
  │        Copies engine-mutable properties (position, heading) from
  │        live GTA handles into each entity's backing PersistentEntity.
  │
  ├── 2. Write WorldState → savePath/world.xml
  │
  ├── 3. Write PlayerState → savePath/player.xml
  │        Read position, heading, health, armor, model from live player ped.
  │
  ├── 4. VehicleRegistryState.Save(savePath, _world.EntityRegistry.Vehicles)
  │        Write savePath/Vehicles/{guid}.xml for each vehicle.
  │
  ├── 5. PedRegistryState.Save(savePath, _world.EntityRegistry.Peds)
  │        Write savePath/Peds/{guid}.xml for each ped.
  │
  ├── 6. PropRegistryState.Save(savePath, _world.EntityRegistry.Props)
  │        Write savePath/Props/{guid}.xml for each prop.
  │
  └── 7. Write SaveFlags → savePath/flags.xml
```

---

## Load Flow

`GameState.Load()` both deserializes state from disk and applies it to the live game world. The only things it does not apply are character-specific setup steps driven by the new-game UI flow (e.g. `CharacterName`, model selection).

```
GameState.Load(savePath)
  │
  ├── 1. Deserialize WorldState ← savePath/world.xml
  │
  ├── 2. Deserialize PlayerState ← savePath/player.xml
  │
  ├── 3. Deserialize SaveFlags ← savePath/flags.xml
  │        Flags must be populated before entities are registered so that
  │        spawn conditions referencing flags evaluate correctly.
  │
  ├── 4. Deserialize and register all entities (no spawning yet)
  │        4a. VehicleRegistryState.Load(savePath)
  │              Deserialize PersistentVehicle; construct Vehicle; register.
  │        4b. PedRegistryState.Load(savePath)
  │              Deserialize PersistentPed; construct Ped; register.
  │        4c. PropRegistryState.Load(savePath)
  │              Deserialize PersistentProp; construct Prop; register.
  │
  ├── 5. Resolve cross-entity references
  │        All entities are now registered — Guids can be resolved to managed objects.
  │        (See Cross-Entity Reference Resolution below.)
  │
  ├── 6. Apply WorldState to the live game world
  │        6a. Set game weather:   _world.SetWeather(worldState.Weather)
  │        6b. Set game time:      _world.SetDateTime(worldState.DateTime)
  │        6c. Load worldspace:    _world.LoadWorldspace(worldState.WorldspaceId)
  │        6d. Load active map:    _world.LoadMap(worldState.ActiveMapId)
  │              This activates required interiors and spawns map-local entities
  │              (props, peds, vehicles defined in the map XML).
  │
  ├── 7. Apply PlayerState to the live player ped
  │        7a. Set player model:   _world.Player.SetModel(playerState.Ped.ModelName)
  │              Model change replaces the native ped — must happen before other properties.
  │        7b. Copy ped properties: position, heading, health, armor, current vehicle, etc.
  │
  └── 8. EntityRegistry.SpawnAll()
           Spawn all registered entities whose SpawnCondition is currently met,
           in dependency order: Vehicles → Peds → Props.
           When a ped with a CurrentVehicleId is spawned, its vehicle is already
           live in the SpawnedVehicleRegistry and the ped is seated immediately.
```

### Why Apply After Register

World application (step 6) and player application (step 7) are intentionally deferred until after all entities are deserialized and cross-references resolved (steps 4–5). This ensures:

- Spawn conditions that reference save flags, worldspace, or other entities evaluate against a fully populated world state.
- Player vehicle cross-references can be resolved before the player ped is placed in the world.
- Map loading (step 6d) and `SpawnAll()` (step 8) both operate on a complete, consistent registry.

---

## Cross-Entity Reference Resolution

After all entities are registered (step 7 above) but before spawning, cross-entity references are resolved. All Guids are in the registry at this point.

```csharp
// Resolve Ped.CurrentVehicle after all entities are registered
foreach (var ped in _world.EntityRegistry.Peds)
{
    if (ped.Persistent.CurrentVehicleId is Guid vehicleId)
    {
        var vehicle = _world.EntityRegistry.GetVehicle(vehicleId);
        ped.SetPendingVehicle(vehicle, ped.Persistent.CurrentVehicleSeatIndex ?? 0);
    }
}
```

The vehicle reference and seat index are stored on the ped before spawning. Because `SpawnAll()` always spawns vehicles before peds, the vehicle is guaranteed to be live in `SpawnedVehicleRegistry` when the ped is spawned, and the ped is seated immediately. The reference is never a nested object and never a GTA handle.

---

## Templates and New-Game Flow

### Template Format

Templates use the **identical folder structure** as saves. `GameState.Load()` makes no distinction between a template path and a save path — the caller decides which directory to pass.

```
JMF/Templates/
  SanAndreas_Default/
    world.xml
    player.xml        ← CharacterName is empty
    flags.xml         ← empty or minimal starting flags
    Vehicles/
    Peds/
    Props/
```

Using the same format means:
- The same `GameState.Load()` code path handles both cases.
- Contributors manage templates as a collection of individual XML files, so entity additions and removals merge cleanly in git.

### New-Game Flow

`GameState.Load()` is pure deserialization — it does not prompt for input or apply character customization. The new-game flow, implemented in the UI layer, wraps it:

```
1. Player selects a template (e.g. "SanAndreas_Default")
2. UI prompts: character name, model selection, and any other character setup
3. GameState.Load(templatePath)          ← pure deserialization
4. world.Player.SetName(characterName)   ← set name on the loaded state
5. world.Player.SetModel(modelName)      ← apply model selection
   (any additional character setup steps)
6. SaveSlotManager.Save()                ← writes first save slot: e.g. Michael_1/
```

This keeps `GameState.Load()` free of UI concerns and makes each character setup step independently testable.

---

## Save Slot Management

### Slot Naming

Save folders are named `{CharacterName}_{n}`, where `n` is a 1-based slot index. Each character name has its own independent set of slots.

```
JMF/Saves/
  Michael_1/
  Michael_2/
  Michael_3/
  Alex_1/
  Alex_2/
```

### SaveSlot

```csharp
public class SaveSlot
{
    public string CharacterName { get; }
    public int SlotIndex { get; }           // 1-based
    public string Path { get; }             // absolute path to the save folder
    public DateTime LastSaved { get; }      // folder last-modified time
    public bool Exists { get; }
}
```

### SaveSlotManager

`SaveSlotManager` handles listing, selecting, and rotating slots. It reads slot state from the filesystem — no separate index file.

```csharp
public class SaveSlotManager
{
    private readonly string _savesRoot;       // JMF/Saves/
    private readonly int _maxSlotsPerCharacter;  // from Framework settings

    // All existing slots for a character, sorted oldest → newest by LastSaved
    public IReadOnlyList<SaveSlot> GetSlots(string characterName);

    // The slot to write to next:
    //   - if fewer than maxSlots exist, returns the next empty slot
    //   - if all slots are full, returns the oldest slot (to be overwritten)
    public SaveSlot GetNextSlot(string characterName);

    // Save current world state into the next slot for the active character
    public void Save(GameState gameState, string characterName);

    // Delete a specific slot
    public void Delete(SaveSlot slot);
}
```

### Slot Rotation

Slot rotation is a circular buffer keyed by `LastSaved` timestamp. No explicit slot-age tracking is needed — the filesystem timestamp is the source of truth.

```
Michael has 3 slots (maxSlots = 3):
  Michael_1  LastSaved: 10:00
  Michael_2  LastSaved: 10:15
  Michael_3  LastSaved: 10:30

Next save → overwrites Michael_1 (oldest):
  Michael_1  LastSaved: 10:45   ← overwritten
  Michael_2  LastSaved: 10:15
  Michael_3  LastSaved: 10:30

Next save → overwrites Michael_2:
  Michael_1  LastSaved: 10:45
  Michael_2  LastSaved: 11:00   ← overwritten
  Michael_3  LastSaved: 10:30
```

### Configuration

The maximum slots per character is configured in `config.xml` under `<Framework>`:

```xml
<Framework>
  <SaveSlotsPerCharacter>3</SaveSlotsPerCharacter>
</Framework>
```

Default value: `3`.

---

## Open Questions

- **Outfit and inventory persistence**: these systems need to be serialized as part of `PlayerState` and, for companion peds, as part of `PersistentPed`. Design TBD pending those systems' designs.
- **Worldspace and active map on load**: saved state is currently assumed authoritative — `world.xml` is always applied on load.
- **Load game UI**: listing slots across all characters, showing last-saved timestamps, and allowing manual slot selection is not designed here. Design TBD.

---

## Related Documentation

- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [World Architecture — Technical Design](../world-architecture/wip-technical-design.md)
- [Data Model](../../architecture/wip-data-model.md)
- [File Structure](../../architecture/file-structure.md)
- [ADR-0004: One File Per Content Item](../../architecture/decisions/adr-0004-one-file-per-content-item.md)
