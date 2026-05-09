---
type: technical-design
feature: entity-system
status: planned
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

## Dual Identity

Every managed entity carries two identity values simultaneously:

| Identity | Type | Lifetime |
|---|---|---|
| Stable ID | `Guid` | Permanent — assigned by framework, stored in XML |
| Runtime Handle | GTA native handle | Session only — assigned by GTA on spawn |

The `EntityRegistry` is responsible for mapping between them and for re-spawning entities when a session is loaded.

## Class Hierarchy

```
EntityDefinition (abstract)
  ├── PropDefinition
  ├── VehicleDefinition
  └── PedDefinition

ManagedEntity<TDefinition, TNativeEntity> (abstract)
  ├── ManagedProp
  ├── ManagedVehicle
  └── ManagedPed
```

### EntityDefinition

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
```

### ManagedEntity

```csharp
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

## Live-Backed Properties

Not all properties behave the same when the entity is spawned.

### Framework-Controlled Properties

Properties the framework owns exclusively (e.g. vehicle color) use **write-through**: writing the property immediately updates both the backing field and the native entity.

```csharp
public VehicleColor PrimaryColor
{
    get => _primaryColor;
    set
    {
        _primaryColor = value;
        if (IsSpawned) NativeEntity.SetPrimaryColor(value);
    }
}
```

### Engine-Mutable Properties

Properties the game engine can change independently (position, heading due to physics and player input) always **read live from the handle** when spawned. Writes update both the backing field and the handle.

```csharp
public Vector3 Position
{
    get => IsSpawned ? NativeEntity.Position : _position;
    set
    {
        _position = value;
        if (IsSpawned) NativeEntity.Position = value;
    }
}
```

On save, engine-mutable properties are read from the handle directly if spawned, or from the backing field if not.

## Entity Persistence

| Category | Description | Save behavior |
|---|---|---|
| Session-persistent | Player's owned vehicle, companions, quest-critical peds | Saved to save file; re-spawned on load |
| Map-local (transient) | Ambient peds, decorative props, map vehicles | Not saved; spawned when map loads; reset when map reloads |

Controlled by `PersistAcrossSessions` on the definition.

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

The `TickManager` evaluates spawn conditions each frame. Entities whose conditions become false are despawned; entities whose conditions become true are spawned. This provides a lightweight streaming layer on top of GTA's own.

## Entity Registry

```csharp
public class EntityRegistry
{
    public ManagedProp RegisterProp(PropDefinition definition);
    public ManagedVehicle RegisterVehicle(VehicleDefinition definition);
    public ManagedPed RegisterPed(PedDefinition definition);

    public void SpawnAll();
    public void DespawnAll();

    public ManagedPed GetPed(Guid id);
    public ManagedVehicle GetVehicle(Guid id);
    public ManagedProp GetProp(Guid id);
}
```

Cross-references between entities (e.g. a ped assigned to drive a vehicle) use stable GUIDs, resolved after all entities are registered — never during registration.

## Vehicle Custody Model

Vehicles spawned by maps can be taken by the player. A three-state model handles this:

```csharp
public enum VehicleCustody
{
    MapOwned,       // spawned by map; player hasn't interacted
    PlayerCustody,  // player has driven it away; cannot despawn
    PlayerOwned,    // explicitly stored/claimed by player
}
```

Transitions:

| From | To | Trigger |
|---|---|---|
| `MapOwned` | `PlayerCustody` | Player enters and drives beyond distance threshold, OR map reset while player is inside |
| `PlayerCustody` | `PlayerOwned` | Player explicitly stores the vehicle |
| `PlayerCustody` | Cleanup | Player out of vehicle for X time AND beyond Y distance |
| `PlayerOwned` | — | Never cleaned up by map resets |

## Spawning Lifecycle

```
Register(definition)
    │
    ▼
SpawnAll() / TickManager condition evaluation
    │
    ▼ (condition met)
AttachNativeEntity(native)   ← game object created by spawner
    │
    ▼
IsSpawned = true; live-backed reads begin
    │
    ▼ (condition no longer met, or DespawnAll())
Detach()
    │
    ▼
IsSpawned = false; backing field reads resume
```

## Open Questions

- None at this time. Spawn condition extension points (custom conditions via delegate/interface) may be worth adding but are not a current requirement.

## Related Documentation

- [Data Model](../../architecture/wip-data-model.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [World Architecture — Technical Design](../world-architecture/wip-technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
