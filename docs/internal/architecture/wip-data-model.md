---
type: data-model
status: active
---

# Data Model

## Entity Identity

Every framework-managed entity has two identity values:

| Identity | Type | Lifetime | Purpose |
|---|---|---|---|
| Stable ID | `Guid` | Permanent — survives sessions | Source of truth; used in XML and cross-references |
| Runtime Handle | GTA native handle | Session only | Used for live native API calls |

The `EntityRegistry` maps between them.

## Entity Classes

The entity system has three layers: **native** (live game objects), **persistent** (serializable backing data), and **managed** (framework-owned, combining both).

### Native Interface Layer

Interfaces in Core expose live entity properties without depending on Rage.

```
INativeEntity
├── Position: Vector3
├── Heading: float
├── ModelName: string
├── Handle: int
└── IEquatable<INativeEntity>
         △                         △
         │                         │
INativePed : INativeEntity    INativeVehicle : INativeEntity
└── Vehicle: INativeVehicle?  ├── HasSirens: bool
                              └── SirenState: SirenState
```

Implemented by `RphEntity`, `RphPed`, `RphVehicle` in the Rph project. These types wrap live `Rage` entities and are never null internally.

### Managed Interface Layer

```
IManagedEntity : INativeEntity
├── Id: Guid
└── IsSpawned: bool
         △                         △
         │                         │
IManagedPed                   IManagedVehicle : INativeVehicle, IManagedEntity
  : INativePed, IManagedEntity └── Custody: EntityCustody
```

Plugins program against `IManagedVehicle` and `IManagedPed` exclusively. They have no concept of `RphVehicle` or `PersistentVehicle`.

### Persistent Layer (Core, serializable)

`PersistentEntity` holds backing fields for all `INativeEntity` properties, plus cell tracking and custody. It is the serializable snapshot written to and read from XML — no Rage dependency.

Fields beyond `INativeEntity`:
- `Id: Guid` — stable framework identity; used as the save filename and for cross-entity references.
- `SpawnCondition: EntitySpawnCondition` — evaluated by `SpawnAll()`.
- `BornInCellId: string` — the Cell that originally spawned this entity; never changes.
- `CurrentCellId: string?` — which Cell should respawn this entity; null for overworld entities.
- `IsInOverworld: bool` — true when the entity is in the open world, not inside a Cell.
- `Custody: EntityCustody` — governs cleanup and persistence rules.

- `PersistentVehicle : PersistentEntity` — adds `SirenState` and other vehicle backing fields.

### Managed Implementation Layer (Core)

```csharp
// Abstract base
Entity : IManagedEntity
├── _native: INativeEntity?   // null when unspawned
└── IsSpawned: bool => _native != null

// Concrete vehicle
Vehicle : Entity, IManagedVehicle
├── _native: INativeVehicle?
├── _persistent: PersistentVehicle   // always present; snapshotted from RphVehicle for ephemeral vehicles
│
├── SirenState.get => _native?.SirenState ?? _persistent.SirenState
└── SirenState.set => { _persistent.SirenState = value; _native?.SirenState = value; }
```

`SyncLiveToPersistent()` copies engine-mutable properties (position, heading) from `_native` to `_persistent` before despawn.

### Live-Backed Properties

Properties differ based on whether the game engine can mutate them independently:

```csharp
// Engine-mutable (physics, player input): read live from _native when spawned
SirenState.get => _native?.SirenState ?? _persistent.SirenState

// Write-through: update both backing store and live object
SirenState.set => { _persistent?.SirenState = value; _native?.SirenState = value; }
```

Position and heading are always read live from `_native` when spawned, and synced to `_persistent` before despawn.

## Spawn Conditions

```csharp
public class EntitySpawnCondition
{
    public float? MaxDistanceFromPlayer { get; set; }
    public string RequiredSaveFlag { get; set; }
    public TimeRange? ActiveTimeOfDay { get; set; }
    public WeatherCondition? RequiredWeather { get; set; }
}
```

The `TickManager` evaluates conditions each frame and despawns/respawns entities as conditions change.

## Entity Persistence

| Custody | In Save File | Notes |
|---|---|---|
| `Persistent` | Always | Restored on every session load. Never cleaned up by the framework. |
| `CellOwned` | Until cell reset | Saved between resets. Deregistered on cell reset; recreated from Map XML on next cell load. |
| `Unclaimed` | Until cleanup | Saved until the cleanup threshold is met (N in-game days beyond player range). |
| `Transient` | Never | Despawned when beyond player distance; not saved. Covers ambient traffic wrapped by the framework. |

## Entity Custody

Custody governs cleanup and persistence rules. It is separate from ownership — which character or player has a relationship to the entity is tracked elsewhere.

```csharp
public enum EntityCustody
{
    Transient,    // Despawn when beyond player distance threshold. Never saved.
    CellOwned,    // Belongs to its birth Cell. Deregistered on cell reset. Saved between resets.
    Unclaimed,    // Detached from birth Cell. Cleaned up after N in-game days beyond player range. Saved.
    Persistent,   // Never cleaned up by the framework. Always saved.
}
```

| Transition | Trigger |
|---|---|
| `CellOwned` → `Unclaimed` | Player takes the entity away from its birth Cell. |
| `Unclaimed` → `Persistent` | Player explicitly stores or claims the entity. |
| `Unclaimed` → deregistered | N in-game days beyond player range (nightly check). |
| `Transient` → despawned | Entity goes beyond distance threshold from the player. |

## Entity Registry

`EntityRegistry` maintains two dictionaries for vehicle lookup:

```csharp
// Framework-registered vehicles, keyed by stable Guid.
// Includes both spawned and unspawned managed vehicles.
Dictionary<Guid, Vehicle> VehicleRegistry

// Currently spawned vehicles (managed + ephemeral), keyed by native handle.
// Updated on every spawn and despawn.
Dictionary<int, Vehicle> SpawnedVehicleRegistry
```

`SpawnedVehicleRegistry` is the bridge between the native layer and the managed layer. It allows any code holding a raw `INativeVehicle` (e.g. from `RphPed.Vehicle`) to retrieve the corresponding managed `Vehicle` if one exists.

Cross-references between entities (e.g. a ped assigned to a vehicle) use stable GUIDs, resolved after all entities are registered.

## Save File Structure

Save files serialize `PersistentVehicle` (and equivalent persistent types) only — never handles. On load:
1. Deserialize from XML into `PersistentVehicle`.
2. Construct `Vehicle` from persistent data and register.
3. Call `SpawnAll()` — spawns entities whose conditions are met.

## World Entities

### WorldspaceDefinition and CellDefinition

A **Map** is a data definition (`Data/Maps/`). A **Cell** is a runtime instance of a Map, defined inline in the worldspace. Multiple Cells may reference the same Map.

```csharp
public class WorldspaceDefinition
{
    public string Id { get; set; }
    public string DisplayName { get; set; }
    public GtaMapRegion BaseMapRegion { get; set; }  // SanAndreas, CayoPerico, NorthYankton
    public List<CellDefinition> Cells { get; set; }
    public WorldspaceAmbientConfig Ambient { get; set; }
    public List<TransitionPointDefinition> TransitionPoints { get; set; }
    public WorldspaceTravelRestrictions TravelRestrictions { get; set; }
}

public class CellDefinition
{
    public string Id { get; set; }
    public string MapId { get; set; }

    // Overworld cells only
    public Vector3? SpawnPoint { get; set; }    // presence zone center; player placement on first visit
    public float? PresenceRadius { get; set; }  // null for interior cells
}
```

### Map XML Example

```xml
<Map id="police_hq" displayName="Mission Row Police HQ">
  <ResetPeriodDays>3</ResetPeriodDays>
  <RequiredInteriors>
    <Interior ref="PoliceStation_MissionRow" />
  </RequiredInteriors>
  <Props>
    <Prop model="prop_cs_police_radio" x="432.1" y="-980.3" z="30.7" />
  </Props>
  <Peds>
    <Ped model="mp_m_freemode_01" tag="Desk_Sergeant" outfit="police_standard" />
  </Peds>
</Map>
```

## Related Documentation

- [Entity System — Technical Design](../features/entity-system/wip-technical-design.md)
- [Save/Load — Technical Design](../features/save-load/wip-technical-design.md)
- [World Architecture — Technical Design](../features/world-architecture/wip-technical-design.md)
