---
type: requirements
feature: interaction-menu
status: active
---

# Interaction Menu — Requirements

## Overview

`Framework.InteractionMenu` is the JMF root menu — the primary in-game UI surface for the framework. It is a Framework layer service, not a plugin. It uses `Framework.MenuService` for menu structure and `INativeFramework.Lifecycle` for tick-driven rendering and input.

## Functional Requirements

### Opening and Closing

- The menu opens and closes when `Lifecycle.ControlHeld` fires for `Settings.Framework.MenuOpenControl`.
- The default open control is `JmfControl.InteractionMenu` — the same control GTA V uses for its native interaction menu (M on keyboard, touchpad on controller). This is intentional: because `InteractionMenu` suppresses the native menu every tick, there is no conflict, and players use the same familiar control.
- `JmfControl.InteractionMenu` maps to `GameControl.InteractionMenu` (value 244) in RPH.
- Hold timing is managed entirely by `Lifecycle` — `InteractionMenu` does not track timers itself.

### Structure (Step 2 Scope)

```
Interaction Menu (root)        BannerText: "JMF", Title: "Interaction Menu"
│
└── Debug                      Only present when Settings.Framework.DebugMode is true.
    ├── Show Position           Logs a hardcoded position to Framework.Logger.
    └── Log Current Model       Logs a hardcoded model name to Framework.Logger.
```

The following submenus are deferred:

| Submenu | Deferred to |
|---|---|
| Plugins | Step 3 (requires PluginService) |
| Game (New/Save/Load) | Phase 3 (requires Save/Load system) |
| Plugin top-level items | Step 3 |

### Debug Submenu

- Present only when `Settings.Framework.DebugMode` is `true`. Absent otherwise.
- **Show Position**: calls `Framework.Logger.Info("Player position: X=0.00, Y=0.00, Z=0.00")`. Position is hardcoded for now; replaced with live player position when the entity system is available.
- **Log Current Model**: calls `Framework.Logger.Info("Current model: player_zero")`. Model name is hardcoded for now; replaced with live model lookup when the entity system is available.

### Rendering and Native Menu Suppression

- `InteractionMenu` subscribes to `Lifecycle.Tick` and `Lifecycle.ControlHeld` on construction.
- Each tick it calls:
  1. `INativeUIService.SuppressNativeMenu()` — prevents the native GTA interaction menu from appearing.
  2. `INativeUIService.ProcessFrame()` — drives LemonUI rendering and input.
- On `ControlHeld` for `MenuOpenControl`: toggles the JMF menu open or closed. Hold timing is owned by `Lifecycle`, not `InteractionMenu`.

### Framework Integration

`Framework.InteractionMenu` is a property on `Framework`, constructed after `MenuService`:

```csharp
InteractionMenu = new InteractionMenu(this);
```

On construction, `InteractionMenu` builds its menu structure via `MenuService` and subscribes to `Lifecycle.Tick`.

## Out of Scope (Step 2)

- Plugin submenu and plugin top-level items.
- Game submenu (New/Save/Load).
- Live player position and model in Debug items.
- Configurable hold duration (owned by Lifecycle, not InteractionMenu).

## Related Documentation

- [MenuService — Requirements](../menu-service/requirements.md)
- [Lifecycle — Requirements](../lifecycle/requirements.md)
- [Interaction Menu — Technical Design](technical-design.md)
- [Settings — Requirements](../settings/requirements.md)
