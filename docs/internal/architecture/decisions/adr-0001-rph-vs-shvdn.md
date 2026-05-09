---
type: adr
status: accepted
---

# ADR-0001: RAGEPluginHook over ScriptHookV.NET

## Context

GTA V modding has two primary scripting runtimes: RAGEPluginHook (RPH) and ScriptHookV.NET (SHVDN). The framework needs a runtime that supports the kinds of concurrent, long-running simulations central to its design (e.g. airport traffic where multiple planes have independent lifecycles).

## Decision

Use **RAGEPluginHook (RPH)** as the scripting runtime.

## Consequences

### Positive

- **GameFiber threading model** allows long-running logic to be written as sequential blocking code, with no manual state machines required.

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

- Multiple concurrent lifecycles (e.g. N planes) each get their own fiber with no shared state.
- Per-frame evaluation is still available via a GameFiber yield loop (`TickManager`), so frame-rate-dependent logic is not sacrificed.

### Negative

- RPH has a smaller user base than SHVDN.
- Players must install RPH in addition to the mod.

## Alternatives Considered

### ScriptHookV.NET (SHVDN)

SHVDN uses a tick-based `OnTick()` callback model. All logic must be decomposed into per-frame state machines, which makes concurrent background simulations significantly harder to reason about and maintain.

SHVDN support could be added later by implementing the Core interfaces against the SHVDN API — the engine-agnostic design of the framework makes this possible. It is not a priority.

## Related Documentation

- [Tech Stack](../wip-tech-stack.md)
- [ADR-0003: GTA VI Portability](adr-0003-gta6-portability.md)
