---
type: feature-readme
feature: plugin-interaction-menu
status: active
---

# Interaction Menu

## Summary

JMF provides its own interaction menu, activated on a custom control (separate from GTA's native M menu). It serves as the primary UI surface for plugin management, game state persistence, and debug tooling.

## Current Status

Design phase. No implementation yet.

## Key Concepts

- Implemented as a core framework service (not a plugin), but uses `ITickable` to check for the open-menu control each frame.
- Built on [LemonUI.RagePluginHook](https://www.nuget.org/packages/LemonUI.RagePluginHook) v2.2.0.
- The menu is the primary driver of the plugin activation lifecycle and plugin settings surface.

## Menu Structure

```
Interaction Menu
├── [Plugin-defined top-level items]   (priority-ordered, then alphabetical)
├── Plugins
│   ├── Siren Manager
│   │   ├── Enabled: [checkbox]
│   │   └── [plugin-defined settings items]
│   └── ...
├── Game
│   ├── New Game
│   ├── Save Game
│   └── Load Game
└── Debug                              (only when debug mode is enabled)
    ├── Show Position
    ├── Log Current Model
    └── ...
```

## Related Systems

- [Plugin System](../plugin-system/README.md) — menu drives plugin activation; plugins declare their settings and top-level items.
- [Save/Load](../save-load/README.md) — Game submenu surfaces save/load operations.

## Documents

- [Technical Design](technical-design.md)
- [Requirements](requirements.md)
