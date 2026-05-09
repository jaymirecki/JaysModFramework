---
type: product-strategy
status: active
---

# Product Strategy

## Build Order

### Phase 1: Plugin Foundation (current focus)

Goal: get the Siren Manager plugin running end-to-end. This forces the first concrete implementation of the plugin system, tick manager, and vehicle model.

Required systems:
1. `IPlugin` / `PluginRegistry` — plugin lifecycle.
2. `ITickable` / `TickManager` — per-frame dispatch.
3. `IFrameworkServices` — service access for plugins.
4. `IVehicle` (minimum surface: `HasSirens`, `SetSirenActive`, `SetSirenMuted`).
5. `IGameWorld.GetPlayerVehicle()`.
6. `SirenManagerPlugin` — the first concrete plugin.
7. RPH implementations of all the above.

See [Plugin System — Technical Design](../features/plugin-system/technical-design.md) and [Siren Manager — Technical Design](../features/plugin-siren-manager/technical-design.md).

### Phase 2: Entity System

Goal: full entity management — props, vehicles, peds — with registration, spawning, despawning, and spawn conditions.

Required systems:
1. `EntityDefinition` hierarchy and `ManagedEntity<,>`.
2. `EntityRegistry` with register/spawn/despawn.
3. `EntitySpawnCondition` with `TickManager` evaluation.
4. Vehicle custody model.

### Phase 3: Save/Load

Goal: session persistence — owned vehicles and companions survive a game restart.

Requires: Entity System complete.

### Phase 4: World Architecture

Goal: map loading from XML with interior activation, map-local entities, and worldspace definition.

Requires: Entity System and Interior System.

### Phase 5: Plugins

With the framework core stable, additional plugins:
- Vehicle Spawner
- Outfit Manager

### Phase 6: Quest System

Lowest priority among core systems. Other systems are insulated from the quest system via save flags.

## Guiding Constraint

Each phase should produce something testable end-to-end (unit tests for Core logic, in-game verification for RPH implementations). No phase should be so large that it can't be shipped to a working state.

## Related Documentation

- [Product Vision](vision.md)
- [Plugin System — Technical Design](../features/plugin-system/technical-design.md)
- [Architecture Overview](../architecture/wip-overview.md)
