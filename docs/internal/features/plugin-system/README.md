---
type: feature-readme
feature: plugin-system
status: planned
---

# Plugin System

## Summary

The plugin system provides a pattern for registering gameplay modules (plugins) with the framework. Plugins declare themselves through a registry, receive access to framework services on initialization, and can register per-frame tick logic.

## Current Status

Planned. No implementation exists yet. This is the **first system to implement**, as it is a prerequisite for the Siren Manager plugin.

## Key Concepts

- A **plugin** is a self-contained gameplay module implementing `IPlugin`.
- Plugins register with the `PluginRegistry` at startup.
- Plugins receive an `IFrameworkServices` handle on initialization, which gives access to shared systems (entity registry, tick manager, fiber service).
- Plugins that need per-frame logic register one or more `ITickable` instances with the `TickManager`.

## Build Order Note

The plugin system is the first target. Building it requires:
1. `IPlugin` / `PluginRegistry` — plugin lifecycle.
2. `ITickable` / `TickManager` — per-frame dispatch.
3. `IFrameworkServices` — service access for plugins.
4. Enough of the vehicle model (`IVehicle`, `ManagedVehicle`) for the Siren Manager to be the first concrete plugin.

## Related Systems

- [Siren Manager](../plugin-siren-manager/README.md) — first plugin; drives the initial plugin system design.
- [Entity System](../entity-system/README.md) — accessed by plugins via `IFrameworkServices`.

## Documents

- [Technical Design](technical-design.md)
