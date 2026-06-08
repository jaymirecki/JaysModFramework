---
type: feature-readme
feature: vehicle-spawner
status: planned
---

# Vehicle Spawner (Plugin)

## Summary

A `MenuPlugin` that lets the player browse available vehicle models by class and spawn them at their current position, warping automatically into the driver's seat. Handles async model loading and maintains a favorites/history list.

## Current Status

Planned. No implementation exists yet.

---

## Key Design Notes

### Menu Structure

```
Plugins
└── Vehicle Spawner
    ├── [Favorites]     (omitted when empty)
    ├── [Recent]        (omitted when empty)
    ├── Compacts
    │   ├── Blista
    │   ├── Issi
    │   └── ...
    ├── Coupes
    │   └── ...
    ├── Emergency
    │   └── ...
    └── ... (one submenu per class)
```

Classes and their items are built at plugin initialization from `VehicleModelRepository`. Selecting a model item triggers the spawn flow.

### Data Source

`VehicleModelRepository` scans `Data/Models/Vehicles/` at startup. Each `VehicleModelDefinition` provides `Name`, `ModelName` (the GTA hash name), and `Class`. The repository exposes:

```csharp
IReadOnlyList<string> Classes          // sorted alphabetically
IReadOnlyList<VehicleModelDefinition> GetByClass(string className)
```

See [Data Layer — Vehicle Model Catalog](../entity-system/wip-technical-design.md#data-layer--vehicle-model-catalog) and [File Structure](../../architecture/file-structure.md#datamodelsvehicles) for XML format and directory layout.

### Spawn Flow

```
Player selects a model item:
  1. Close menu.
  2. Request model (async — GameFiber.Yield until loaded).
  3. Call EntityRegistry.Spawn(vehicle) at player's current position.
     EntityRegistry sets vehicle._native, adds to SpawnedVehicleRegistry.
  4. Set vehicle.Custody = VehicleCustody.PlayerOwned.
  5. Warp player ped into driver's seat.
  6. Add model to recent list (persist to XML).
```

Trainer-spawned vehicles are set to `PlayerOwned` immediately — they are never cleaned up by map resets.

### Async Model Loading

Model loading blocks the game fiber:

```csharp
// RPH implementation (IGameWorld.SpawnVehicle):
model.Request();
while (!model.IsLoaded)
    GameFiber.Yield();
var vehicle = new Rage.Vehicle(model, position);
```

The menu is closed before the load starts so the player sees the world while the model loads.

### Spawn Position

The vehicle is spawned at the player ped's current position. Exact placement (road surface snapping, clearance checks) is TBD.

### Favorites and Recent Lists

Both lists are persisted in XML as ordered lists of `ModelName` strings. The recent list caps at a configurable maximum (default: 10). Favorites are user-managed (add/remove from model item context action).

---

## Open Questions

- **Spawn position modes**: Spawn at player, spawn on nearest road node, spawn behind player — design TBD.
- **Spawn position validation**: Road surface snapping, clearance check, avoid blocking traffic — specifics TBD.
- **Plugin registration mechanism**: Depends on plugin architecture design. TBD.
- **UI/menu design**: Sub-item actions (favorite, info) — design TBD.

---

## Related Documentation

- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [File Structure — Data/Models/Vehicles/](../../architecture/file-structure.md#datamodelsvehicles)
- [Architecture Overview](../../architecture/wip-overview.md)
- [ADR-0004: One File Per Content Item](../../architecture/decisions/adr-0004-one-file-per-content-item.md)
