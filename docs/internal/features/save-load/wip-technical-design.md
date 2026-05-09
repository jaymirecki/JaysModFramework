---
type: technical-design
feature: save-load
status: planned
related:
  - entity-system
  - world-architecture
---

# Save/Load — Technical Design

## Core Principle

Save files serialize **definitions**, not runtime handles.

GTA native entity handles are ephemeral — they are only valid for the current game session and cannot be stored or restored. The framework stores the information needed to re-create each entity from scratch.

## Save File Structure

```csharp
public class RegistrySnapshot
{
    public List<PropDefinition> Props { get; set; }
    public List<VehicleDefinition> Vehicles { get; set; }
    public List<PedDefinition> Peds { get; set; }
}
```

The snapshot is serialized to XML.

## What Is Saved

| Category | Saved | Notes |
|---|---|---|
| Session-persistent entities | Yes | Player's owned vehicle, companions, quest-critical peds |
| Map-local (transient) entities | No | Ambient peds, decorative props; spawned fresh from map XML on load |
| Engine-mutable property values | Yes (if spawned) | Position and heading are read from the live handle before saving |
| Save flags | Yes | Quest progression, unlock states |

## Save Flow

1. For each session-persistent entity that is currently spawned, read engine-mutable properties (position, heading) from the live handle.
2. Serialize all session-persistent entity definitions to `RegistrySnapshot`.
3. Write snapshot to XML file.

## Load Flow

1. Deserialize definitions from the save XML.
2. Register all entities with the `EntityRegistry` — **no spawning yet**.
3. Call `SpawnAll()` — entities whose `SpawnCondition` is currently met are spawned.
4. Activate required interiors for the current map before spawning.

This "register then spawn" separation allows all cross-references between entities (via stable GUID) to be resolved before any entity is created in GTA.

## Engine-Mutable Property Handling

Position and heading can be changed by GTA's physics engine independently of framework code. On save:

```csharp
// Read from live handle if spawned; use backing field if not
public Vector3 GetSavePosition() =>
    IsSpawned ? NativeEntity.Position : _position;
```

This avoids a separate sync step — the property getter already handles this correctly.

## Save Flags

Save flags are a simple key-value store of boolean states:

```xml
<SaveFlags>
  <Flag key="mission_01_complete" value="true" />
  <Flag key="apartment_owned" value="true" />
</SaveFlags>
```

Other systems (spawn conditions, map availability, quest progression) query save flags rather than depending directly on each other.

## Open Questions

- **Outfit and inventory persistence**: these systems will also need to be serialized. Design TBD pending those systems' designs.
- **Worldspace / active map state**: whether the current worldspace and active map are part of the save file, or always re-derived on load. Design TBD.

## Related Documentation

- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [Data Model](../../architecture/wip-data-model.md)
- [World Architecture — Technical Design](../world-architecture/wip-technical-design.md)
