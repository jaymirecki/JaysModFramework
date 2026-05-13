---
type: adr
id: ADR-0005
status: accepted
---

# ADR-0005: Framework Layer Architecture and INativeFramework

## Context

JMF needs a clean boundary between engine-specific code (RPH natives, LemonUI) and engine-free business logic (plugin management, entity registry, menus). This boundary must support:

- Unit testing without a running game process.
- Parallel test execution with different fake configurations per test.
- A minimal installation footprint for players (as few DLLs as possible).
- A simple entry point for external plugin authors.

## Decision

### Three-Layer Model

```
Plugin Layer      — core plugins (bundled) + external plugins; receive IFrameworkServices
Framework Layer   — Framework, PluginManager, services; no RPH/GTA references (Core project)
Native Layer      — RphNativeFramework; all RPH/GTA calls; (Rph project)
```

### INativeFramework

`INativeFramework` (defined in `Core`) is the sole interface between the Framework and Native layers. `Framework` accepts it via constructor injection:

```csharp
// Production: RphEntryPoint.cs
var framework = new Framework(new RphNativeFramework());

// Tests: each test constructs its own instance
var framework = new Framework(new FakeNativeFramework { ... });
```

`Framework` is an **instanced class**, not a static class. This allows each unit test to hold its own `Framework` with its own `FakeNativeFramework`, enabling parallel test execution with different fake configurations.

### PluginManager is a Framework Concern

The RPH entry point constructs `INativeFramework` and passes it to `Framework`. Plugin registration, lifecycle, and service wiring are handled inside the `Framework` constructor. The RPH entry point has no direct knowledge of plugins.

### Bundled Deployment

Core plugins (maintained alongside the framework) are compiled into `JaysModFramework.Core` and ship in a single JMF DLL alongside the `Rph` project. Players install two DLLs: the RPH runtime and the JMF DLL.

External plugins ship as separate DLLs referencing `JaysModFramework.Core`.

## Consequences

- The RPH entry point is minimal: construct `RphNativeFramework`, construct `Framework`, done.
- Tests construct `Framework` with a `FakeNativeFramework` — no global state to reset between tests.
- External plugin authors test their plugins the same way: `new Framework(new FakeNativeFramework(...))`.
- Tests that use different fake configurations can run in parallel, since each test owns a separate `Framework` instance.
- Plugin authors receive `IFrameworkServices` via `IPlugin.Initialize` rather than accessing a static class — this is slightly more explicit than a static API but is familiar from other DI patterns.

## Alternatives Considered

**Static `Framework` class** — simpler plugin authoring API (`Framework.MenuService` vs `services.MenuService`). Rejected because a static `Framework` introduces global state: tests with different fake configurations cannot run in parallel, and reinitializing between tests requires discipline.

**Static `Framework.Initialize` with instanced plugins** — a hybrid where `Framework` is static but `INativeFramework` is set via a static `Initialize` method. Rejected for the same reason: global state reintroduced.

## Related Documentation

- [Architecture Overview](../wip-overview.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
- [Plugin System — Technical Design](../../features/plugin-system/technical-design.md)
- [ADR-0003: Engine-Free Core](adr-0003-gta6-portability.md)
