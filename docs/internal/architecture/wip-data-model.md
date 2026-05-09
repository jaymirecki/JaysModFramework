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

### Definition Layer

All definitions inherit from `EntityDefinition`:

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

Concrete definitions:
- `PropDefinition`
- `VehicleDefinition`
- `PedDefinition`

### Managed Entity Layer

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

Concrete types:
- `ManagedProp` / `PropDefinition`
- `ManagedVehicle` / `VehicleDefinition`
- `ManagedPed` / `PedDefinition`

### Live-Backed Properties

Properties differ based on whether the game engine can mutate them independently:

```csharp
// Framework-controlled: write-through to native when spawned
public VehicleColor PrimaryColor
{
    get => _primaryColor;
    set { _primaryColor = value; if (IsSpawned) NativeEntity.SetPrimaryColor(value); }
}

// Engine-mutable (physics, player input): always read live from handle
public Vector3 Position
{
    get => IsSpawned ? NativeEntity.Position : _position;
    set { _position = value; if (IsSpawned) NativeEntity.Position = value; }
}
```

Position and heading are always read live from the handle when spawned. On save, these are read from the handle directly if spawned, from the backing field if not.

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

| Type | Description | Saved? |
|---|---|---|
| Session-persistent | Player's owned vehicle, companions, quest-critical peds | Yes — tracked in save file, restored on load |
| Map-local (transient) | Ambient peds, decorative props, map vehicles | No — spawned when map loads, reset when map reloads |

## Vehicle Custody Model

```csharp
public enum VehicleCustody
{
    MapOwned,       // spawned by map; player hasn't interacted
    PlayerCustody,  // player has driven it away; cannot despawn
    PlayerOwned,    // explicitly stored/claimed by player
}
```

Transitions:
- `MapOwned` → `PlayerCustody`: player enters and drives beyond a distance threshold, or map tries to reset while player is in it.
- `PlayerCustody` → `PlayerOwned`: player explicitly stores it.
- `PlayerCustody` → cleanup: player has been out of vehicle for X time AND is beyond Y distance.
- `PlayerOwned` is never cleaned up by map resets.

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

Cross-references between entities (e.g. a ped assigned to a vehicle) use stable GUIDs, resolved after all entities are registered.

## Save File Structure

```csharp
public class RegistrySnapshot
{
    public List<PropDefinition> Props { get; set; }
    public List<VehicleDefinition> Vehicles { get; set; }
    public List<PedDefinition> Peds { get; set; }
}
```

Save files serialize **definitions only** — never handles. On load:
1. Deserialize definitions from XML.
2. Register all entities (no spawning yet).
3. Call `SpawnAll()` — spawns entities whose conditions are met.

## World Entities

### WorldspaceDefinition

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

### Map XML Example

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
    <Ped model="mp_m_freemode_01" tag="Desk_Sergeant" outfit="police_standard" />
  </Peds>
</Map>
```

## Related Documentation

- [Entity System — Technical Design](../features/entity-system/wip-technical-design.md)
- [Save/Load — Technical Design](../features/save-load/wip-technical-design.md)
- [World Architecture — Technical Design](../features/world-architecture/wip-technical-design.md)
