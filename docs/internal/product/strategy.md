---
type: product-strategy
status: active
---

# Product Strategy

## Build Order

### Phase 1: Plugin Foundation (current focus)

Goal: get the Siren Manager plugin running end-to-end against a working interaction menu and logging system. This forces concrete implementations of the layer architecture, native lifecycle, menu system, plugin system, and vehicle model.

Phase 1 is sequenced into three steps, each producing something testable before the next begins.

#### Step 1 — Framework.Logger

Goal: structured logging to file and optionally to the in-game UI, with configurable verbosity and file path.

Required systems:
- `Framework.Settings` — XML-backed settings load/save; shared config for the whole framework.
- `INativeFramework.UIService` — Native layer interface for rendering text to the game UI.
- `Framework.Logger` — writes to file (always) and to UIService (if verbosity setting enables it).

This step is the entry point for verifying that settings load and that the native UI service works end-to-end.

#### Step 2 — Framework.InteractionMenu

Goal: a working in-game root menu usable for debugging and testing subsequent steps.

Required systems:
- `IMenu` / `IMenuItem` — Core abstractions for menus and menu items.
- `Framework.MenuService` — Framework-layer service for defining menus, adding items, and registering callbacks. Uses `INativeFramework.UIService` for rendering and navigation; UIService converts between `IMenu`/`IMenuItem` and LemonUI equivalents.
- `INativeFramework.Lifecycle` — Native layer interface exposing `Tick` and `KeyPressed` as events. InteractionMenu and PluginService subscribe to these to drive per-frame rendering and input handling.
- `Framework.InteractionMenu` — the specific JMF root menu, built on MenuService. Includes Debug submenu at minimum for testing. Plugin submenu is deferred to Step 3.

#### Step 3 — Framework.Plugins.Sirens

Goal: first real plugin — toggle between siren + lights, lights only, and no lights or siren on equipped vehicles.

Required systems:
- `Framework.PluginService` — plugin registration, initialization, and lifecycle (activate/deactivate). InteractionMenu gains a Plugin submenu once PluginService is available.
- `Framework.Player` / `Framework.Ped` / `Framework.Vehicle` — minimal entity access: get the player's current vehicle, read and write siren state. This is a skeleton, not the full entity system.
- `Framework.Plugins.Sirens` — the Siren Manager plugin, registered with PluginService and exposed via the Plugin submenu.

At the end of Phase 1: logging, settings, a working interaction menu, plugin management, and one concrete plugin are all running end-to-end.

### Phase 2: Entity System

Goal: full entity management — props, vehicles, peds — with registration, spawning, despawning, and spawn conditions. A skeleton Trainer plugin (vehicle spawner) will drive this phase, providing an in-game surface for testing spawning and entity state.

Required systems:
1. `EntityDefinition` hierarchy and `ManagedEntity<,>`.
2. `EntityRegistry` with register/spawn/despawn.
3. `EntitySpawnCondition` with `Lifecycle.Tick` evaluation.
4. Vehicle custody model.
5. `Framework.Plugins.Trainer` — skeleton plugin with vehicle spawner; exercises the entity system end-to-end.

### Phase 3: Save/Load

Goal: session persistence — owned vehicles and companions survive a game restart.

Requires: Entity System complete.

### Phase 4: World Architecture

Goal: map loading from XML with interior activation, map-local entities, and worldspace definition.

Requires: Entity System and Interior System.

### Phase 5: Plugins

With the framework core stable, additional plugins:
- Outfit Manager

### Phase 6: Quest System

Lowest priority among core systems. Other systems are insulated from the quest system via save flags.

## Guiding Constraint

Each phase should produce something testable end-to-end (unit tests for Core logic, in-game verification for RPH implementations). No phase should be so large that it can't be shipped to a working state.

## Related Documentation

- [Product Vision](vision.md)
- [Plugin System — Technical Design](../features/plugin-system/technical-design.md)
- [Architecture Overview](../architecture/wip-overview.md)
