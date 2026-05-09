---
type: tech-stack
status: active
---

# Tech Stack

## Runtime: RAGEPluginHook (RPH)

RPH is the chosen scripting runtime for GTA V. It provides the **GameFiber** threading model, which allows long-running logic to be written as sequential blocking code rather than tick-based state machines.

See [ADR-0001](decisions/adr-0001-rph-vs-shvdn.md) for the decision rationale.

## Language: C# / .NET

The framework and all plugins are written in C#, targeting the .NET version compatible with RPH.

## Concurrency: GameFiber

Background simulations (e.g. traffic patterns, ambient NPC lifecycles) use individual GameFibers. Each fiber runs its own sequential lifecycle loop. There is no shared state machine.

```csharp
GameFiber.StartNew(() =>
{
    while (!runway.HasFreeSlot())
        GameFiber.Yield();

    var plane = SpawnPlane(spawnPoint);
    TaxiToRunway(plane);
    GameFiber.Sleep(15000);
    plane.Delete();
});
```

## Per-Frame Evaluation: TickManager

The framework implements a central `TickManager` that runs inside a GameFiber yield loop and dispatches to registered `ITickable` systems each frame. This handles spawn condition evaluation and other frame-rate-dependent logic.

## Content: XML

All content definitions (vehicles, ped models, props, outfits, weapons, maps, worldspaces) are stored in XML. Model names are treated as opaque strings resolved at runtime.

## Testing: xUnit / NUnit

Tests run in a standard .NET test runner against the `YourFramework.Core` project, which has **zero references** to RPH or GTA dlls. See [Testing Strategy](../workflows/wip-testing-strategy.md).

## Project Layout

```
JaysModFramework.Core       // interfaces + business logic; no RPH/GTA references
JaysModFramework.Rph        // RPH implementations of Core interfaces
JaysModFramework.Tests      // xUnit/NUnit; references Core only
Plugins/*                   // plugins reference Core; use injected interfaces
```

## Related Documentation

- [ADR-0001: RPH vs SHVDN](decisions/adr-0001-rph-vs-shvdn.md)
- [Testing Strategy](../workflows/wip-testing-strategy.md)
- [Architecture Overview](wip-overview.md)
