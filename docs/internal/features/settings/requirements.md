---
type: requirements
feature: settings
status: active
---

# Settings — Requirements

## Overview

`Framework.Settings` loads and exposes configuration for the framework and all plugins. It is initialized first at framework startup, before Logger, since Logger depends on it for log location and level configuration.

## Functional Requirements

### Loading

- Settings are loaded from `config.xml` in the `JMF` folder at framework initialization.
- If `config.xml` does not exist, defaults are used and the file is created.
- Settings are read-only at runtime. A future interaction menu item may trigger a reload.

### Structure

`Framework.Settings` is a `FrameworkConfig` instance and exposes settings in named groups:

**Logger group** (`Settings.Logger`):
- `LogLocation` — path to the log file. Default: `JMF/JaysModFramework.log`.
- `LogLevel` — minimum level written to the log file. Default: `Info`.
- `NotificationLevel` — minimum level surfaced as an in-game notification. Default: `Error`.

**Framework group** (`Settings.Framework`):
- `DebugMode` — enables the Debug submenu in the interaction menu. Default: `false`.
- `MenuOpenControl` — game control that opens the interaction menu. Typed as `JmfControl`. Default: `JmfControl.InteractionMenu`.

**Plugins** (`Settings.Plugins`):
- A collection of per-plugin settings keyed by plugin name (`IPlugin.Name`).
- Base type `IPluginSettings` provides `DefaultActivatedStatus`.
- Plugins extend `IPluginSettings` with additional typed properties (e.g. `SirensSettings` adds `ControllerButton` and `KeyboardKey`).

## Out of Scope

- Writing settings back to `config.xml` at runtime.
- Hot reload via file system watcher.
- Per-user settings or profiles.

## Open Questions

- Should `LogLocation` be relative to the GTA V root folder, relative to the JMF folder, or support absolute paths? Relative to GTA V root is simplest for players.

## Related Documentation

- [File Structure](../../architecture/file-structure.md)
- [Logger — Requirements](../logger/requirements.md)
