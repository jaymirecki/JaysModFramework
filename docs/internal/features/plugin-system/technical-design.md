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
- Plugins should not start fibers or register tickables before `Initialize` is called.

## PluginRegistry

```csharp
public class PluginRegistry
{
    private readonly List<IPlugin> _plugins = new();

    public void Register(IPlugin plugin);
    public void InitializeAll(IFrameworkServices services);
    public void ShutdownAll();
}
```

### Registration Pattern

Plugins self-register. Core plugins are registered inside the `Framework` constructor, not by the RPH entry point:

```csharp
// Framework.cs (Core) — RPH entry point never touches plugin registration
public Framework(INativeFramework nativeFramework)
{
    // ... wire up services ...
    _pluginManager = new PluginManager();
    _pluginManager.Register(new SirenManagerPlugin());
    // _pluginManager.Register(new VehicleSpawnerPlugin());
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

The service handle passed to each plugin on initialization:

```csharp
public interface IFrameworkServices
{
    ITickManager TickManager { get; }
    IEntityRegistry EntityRegistry { get; }
    IFiberService FiberService { get; }
    IGameWorld GameWorld { get; }
}
```

| Service | Purpose |
|---|---|
| `ITickManager` | Register per-frame tick logic |
| `IEntityRegistry` | Access and manage framework entities |
| `IFiberService` | Start background GameFibers |
| `IGameWorld` | Query live game state (player vehicle, player position, etc.) |

Plugins hold a reference to the services they need for the duration of their lifetime.

## ITickable and TickManager

Per-frame logic is registered via `ITickable`:

```csharp
public interface ITickable
{
    void Tick();
}

public interface ITickManager
{
    void Register(ITickable tickable);
    void Unregister(ITickable tickable);
}
```

The `TickManager` implementation runs inside a GameFiber yield loop, calling `Tick()` on all registered `ITickable` instances each frame:

```csharp
// RPH implementation (conceptual)
GameFiber.StartNew(() =>
{
    while (true)
    {
        foreach (var tickable in _tickables)
            tickable.Tick();
        GameFiber.Yield();
    }
});
```

Plugins register their tick implementations during `Initialize`:

```csharp
public void Initialize(IFrameworkServices services)
{
    _gameWorld = services.GameWorld;
    services.TickManager.Register(new SirenManagerTick(this, services.GameWorld));
}
```

## IGameWorld

A minimal interface for querying live game state that is not managed by the entity registry:

```csharp
public interface IGameWorld
{
    IVehicle GetPlayerVehicle();   // null if player is on foot
    bool IsPlayerInVehicle { get; }
    // expand as additional systems require it
}
```

## Plugin Lifecycle

```
Framework bootstrap
    │
    ▼
PluginRegistry.Register(plugin) × N
    │
    ▼
PluginRegistry.InitializeAll(services)
    │  └── plugin.Initialize(services) for each plugin
    │      └── plugin registers ITickables, starts fibers, etc.
    │
    ▼
TickManager running (GameFiber yield loop)
    │
    ▼ (RPH unload / game exit)
PluginRegistry.ShutdownAll()
    └── plugin.Shutdown() for each plugin
```

## Testing

The plugin system is fully testable in Core:

- `FakeTickManager` records registered tickables and exposes them for assertion.
- `FakeGameWorld` returns controlled values (e.g. a `FakeVehicle` as the player vehicle).
- `FakeFiberService.StartNew()` runs fibers synchronously.
- Plugin `Initialize` can be called in tests with a fully fake `IFrameworkServices`.

## Open Questions

- **Tick ordering**: if multiple plugins register tickables, is order significant? If so, should `Register` accept a priority? Design TBD.
- **Conditional tick registration**: should plugins be able to enable/disable their tickables at runtime, or should the `ITickable.Tick()` implementation handle its own guard logic?

## Related Documentation

- [Siren Manager — Technical Design](../plugin-siren-manager/technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
- [Architecture Overview](../../architecture/wip-overview.md)
