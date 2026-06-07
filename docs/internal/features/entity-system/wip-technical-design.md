---
type: technical-design
feature: entity-system
status: active
related:
  - data-model
  - save-load
  - world-architecture
---

# Entity System — Technical Design

## Overview

The entity system manages framework-owned game objects (props, vehicles, peds). It provides:

- A stable GUID identity that survives sessions.
- Bridging between stable IDs and ephemeral GTA runtime handles.
- Conditional spawning based on world state.
- A vehicle custody model for player-map ownership handoff.
- Transparent access to entity properties whether or not the entity is currently spawned in the world.

---

## Interface Hierarchy

Two parallel interface families represent the two distinct concerns: **native** (live game objects) and **managed** (framework-tracked objects). `IManagedEntity` extends `INativeEntity` — a managed entity always answers live entity questions, sourcing answers from its backing fields when unspawned.

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

IManagedEntity : INativeEntity
├── Id: Guid
└── IsSpawned: bool
         △                         △
         │                         │
IManagedPed                   IManagedVehicle : INativeVehicle, IManagedEntity
  : INativePed, IManagedEntity └── Custody: VehicleCustody
```

Plugins and other consumers program against `IManagedVehicle` and `IManagedPed`. They have no concept of `RphVehicle` or `PersistentVehicle` — they simply call `vehicle.SirenState` and check `vehicle.IsSpawned` if they need to guard against an unspawned entity.

---

## Implementation Hierarchy

### RPH Layer (Rph project — depends on Rage)

The RPH layer provides thin, always-live wrappers around Rage entities. These types are **never null internally** — an `RphVehicle` always wraps a live `Rage.Vehicle`.

```
RphEntity (abstract) : INativeEntity
└── _entity: Rage.Entity
    Implements position, heading, modelName, handle, and handle-based equality.

RphPed : RphEntity, INativePed
├── _ped: Rage.Ped
└── Vehicle: INativeVehicle?
    Returns a raw RphVehicle for the ped's current vehicle,
    or null. No registry lookup — that is the managed layer's job.

RphVehicle : RphEntity, INativeVehicle
├── _vehicle: Rage.Vehicle
├── HasSirens: bool
└── SirenState: SirenState { get; set; }
    Reads/writes IsSirenOn and IsSirenSilent directly on the Rage vehicle.
```

### Core Layer (Core project — no Rage dependency)

The Core layer owns persistence, identity, and lifecycle. It references Rph types only via interfaces.

```
PersistentEntity (abstract)
└── Backing fields for all INativeEntity properties (position, heading, etc.)
    This is the serializable snapshot — what gets written to and read from XML.

PersistentVehicle : PersistentEntity
└── Backing fields for all INativeVehicle properties (SirenState, etc.)

Entity (abstract) : IManagedEntity
├── _native: INativeEntity?   ← null when unspawned
└── IsSpawned: bool => _native != null

Vehicle : Entity, IManagedVehicle
├── _native: INativeVehicle?      ← set by EntityRegistry on spawn
├── _persistent: PersistentVehicle?
│       Null for ephemeral (unregistered) vehicles such as ambient traffic.
│       Always set for framework-registered vehicles.
│
├── SirenState.get => _native?.SirenState ?? _persistent.SirenState
├── SirenState.set => { _persistent?.SirenState = value; _native?.SirenState = value; }
└── SyncLiveToPersistent()
        Called before despawn. Copies engine-mutable properties
        (position, heading) from _native to _persistent.
```

---

## Registry Design

`EntityRegistry` maintains two dictionaries for vehicle lookup:

```csharp
// Framework-registered vehicles, keyed by stable Guid.
// Includes both spawned and unspawned managed vehicles.
Dictionary<Guid, Vehicle> VehicleRegistry

// Currently spawned vehicles (managed + ephemeral), keyed by native handle.
// Updated on every spawn and despawn.
Dictionary<int, Vehicle> SpawnedVehicleRegistry
```

The `SpawnedVehicleRegistry` is the bridge between the native layer and the managed layer. It allows any code that holds a raw `INativeVehicle` (e.g. from `RphPed.Vehicle`) to retrieve the corresponding managed `Vehicle` if one exists.

---

## Ped.Vehicle Lookup Flow

`Ped` (the managed ped, `IManagedPed`) owns the registry lookup. `RphPed` stays dumb.

```
Ped.Vehicle (Core):
  1. rphVehicle = _native.Vehicle          // RphPed returns raw INativeVehicle?
  2. if rphVehicle == null → return null
  3. vehicle = SpawnedVehicleRegistry[rphVehicle.Handle]
  4a. found  → return registered Vehicle (managed, has Guid, Custody, etc.)
  4b. not found → return new ephemeral Vehicle(_native: rphVehicle, _persistent: null)
                  IsSpawned always true; reads go directly to native.
                  Used for ambient traffic the framework did not spawn.
```

Plugins always receive an `IManagedVehicle` regardless of whether the vehicle is framework-managed or ambient. For ambient traffic `IsSpawned` is always true. For managed vehicles, `IsSpawned` reflects whether the framework has spawned it.

---

## Spawn / Despawn Lifecycle

### Spawn

```
EntityRegistry.Spawn(vehicle: Vehicle):
  1. native = IGameWorld.SpawnVehicle(vehicle.ModelName, vehicle.Position, vehicle.Heading)
         RPH implementation: Model.Request() → GameFiber.Yield → new Rage.Vehicle(...)
  2. vehicle._native = native
  3. SpawnedVehicleRegistry[native.Handle] = vehicle
```

### Despawn

```
EntityRegistry.Despawn(vehicle: Vehicle):
  1. SpawnedVehicleRegistry.Remove(vehicle._native.Handle)
  2. vehicle.SyncLiveToPersistent()   // copy position, heading from _native → _persistent
  3. vehicle._native = null
```

---

## Vehicle Custody Model

```csharp
public enum VehicleCustody
{
    MapOwned,       // Spawned by map; player has not interacted with it.
    PlayerCustody,  // Player has driven it away; framework will not despawn it.
    PlayerOwned,    // Player has explicitly claimed it; persists across sessions.
}
```

| From | To | Trigger |
|---|---|---|
| `MapOwned` | `PlayerCustody` | Player enters and drives beyond a distance threshold, or map tries to reset while player is inside |
| `PlayerCustody` | `PlayerOwned` | Player explicitly stores the vehicle |
| `PlayerCustody` | Cleanup | Player out of vehicle for X time AND beyond Y distance |
| `PlayerOwned` | — | Never cleaned up by map resets |

Trainer-spawned vehicles are set to `PlayerOwned` immediately on spawn.

---

## Entity Persistence

| Category | PersistAcrossSessions | Saved | Notes |
|---|---|---|---|
| Player-owned | `true` | Yes | Restored on next session load |
| Map-local | `false` | No | Spawned when map loads; reset on map reload |
| Ephemeral (ambient) | N/A | No | Not in VehicleRegistry; no PersistentVehicle |

Save files serialize the `PersistentVehicle` (and equivalent persistent types) only — never handles. On load:
1. Deserialize from XML into `PersistentVehicle`.
2. Construct `Vehicle` from persistent data and register.
3. Call `SpawnAll()` — spawns entities whose conditions are met.

---

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

A `TickManager` evaluates spawn conditions each frame. Entities whose conditions become false are despawned (syncing live state first); entities whose conditions become true are spawned.

---

## Data Layer — Vehicle Model Catalog

The vehicle model catalog is separate from the entity system. It describes vehicle *types* that can be spawned — not instances.

```
Data/
  Models/
    Vehicles/
      Blista.xml
      Adder.xml
      ...
```

```xml
<!-- Data/Models/Vehicles/Blista.xml -->
<VehicleModelDefinition>
  <Name>Blista</Name>
  <ModelName>blista</ModelName>
  <Class>Compacts</Class>
</VehicleModelDefinition>
```

`VehicleModelRepository` scans `Data/Models/Vehicles/` at startup and provides:
- `IReadOnlyList<string> Classes` — sorted list of all class names found
- `IReadOnlyList<VehicleModelDefinition> GetByClass(string className)`

---

## Related Documentation

- [Data Model](../../architecture/wip-data-model.md)
- [File Structure](../../architecture/file-structure.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [Vehicle Spawner (Trainer Plugin)](../vehicle-spawner/README.md)
- [ADR-0004: One File Per Content Item](../../architecture/decisions/adr-0004-one-file-per-content-item.md)
