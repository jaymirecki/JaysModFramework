---
type: technical-design
feature: plugin-system
status: planned
related:
  - entity-system
  - siren-manager
---

# Plugin System — Technical Design

## Overview

The plugin system is a lightweight registration and lifecycle pattern. Core plugins (maintained alongside the framework) are compiled into the framework DLL. External plugins ship as separate DLLs and reference `JaysModFramework.Core`. Plugins are registered and initialized by `Framework` internally — the RPH entry point has no direct knowledge of plugins.

## IPlugin Interface

```csharp
public interface IPlugin
{
    string Name { get; }
    void Initialize(IFrameworkServices services);
    void Shutdown();
}
```

- `Initialize` is called once at framework startup, after core services are ready.
- `Shutdown` is called when the framework is unloaded (e.g. RPH plugin unload).
- Plugins should not subscribe to lifecycle events or start fibers before `Initialize` is called.

## PluginManager

```csharp
public class PluginManager
{
    private readonly List<IPlugin> _plugins = new();

    public void Register(IPlugin plugin);
    public void InitializeAll(IFrameworkServices services);
    public void ShutdownAll();
}
```

### Registration Pattern

Core plugins are registered inside the `Framework` constructor, not by the RPH entry point:

```csharp
// Framework.cs (Core) — RPH entry point never touches plugin registration
public Framework(INativeFramework nativeFramework)
{
    // ... wire up services ...
    _pluginManager = new PluginManager();
    _pluginManager.Register(new SirenManagerPlugin());
    _pluginManager.InitializeAll(this);
}
```

```csharp
// RphEntryPoint.cs — knows nothing about plugins
var nativeFramework = new RphNativeFramework();
var framework = new Framework(nativeFramework);
```

Registration is explicit and compile-checked — no reflection, no assembly scanning, no manifest file.

## IFrameworkServices

The service handle passed to each plugin on initialization. Exact surface is being designed for Step 3 (PluginService); the shape below is indicative and will be updated when the plugin system is built.

`Framework` is organized into three sub-objects that plugins access through `IFrameworkServices`:

```csharp
public interface IFrameworkServices
{
    GameServices Game { get; }   // Logger, Settings, MenuService, PluginService
    WorldServices World { get; } // EntityRegistry, active map, player state
    DataServices Data { get; }   // Content definitions loaded from XML
}
```

Plugins hold a reference to the services they need for the duration of their lifetime. Per-frame logic is implemented by subscribing to `Game.Lifecycle.Tick` — there is no `ITickable` registration pattern.

Plugin controls use `JmfControl` (not RPH's `GameControl`) so Core plugins have no native dependency.

## Plugin Lifecycle

```
Framework bootstrap
    │
    ▼
PluginManager.Register(plugin) × N
    │
    ▼
PluginManager.InitializeAll(services)
    │  └── plugin.Initialize(services) for each plugin
    │      └── plugin subscribes to Lifecycle events, starts fibers, etc.
    │
    ▼
RphLifecycleService running (GameFiber yield loop)
    │
    ▼ (RPH unload / game exit)
PluginManager.ShutdownAll()
    └── plugin.Shutdown() for each plugin
```

## Testing

The plugin system is fully testable in Core:

- `FakeNativeFramework` provides a `FakeNativeLifecycle` that exposes methods to fire `Tick`, `ControlClicked`, `ControlHeld`, and `ControlDoubleClicked` events directly from tests.
- `FakeFiberService.StartNew()` runs fibers synchronously.
- Plugin `Initialize` can be called in tests with a fully fake `IFrameworkServices`.

## Related Documentation

- [Siren Manager — Technical Design](../plugin-siren-manager/technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
- [Architecture Overview](../../architecture/wip-overview.md)
