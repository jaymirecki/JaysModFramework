---
type: architecture-overview
status: active
---

# Architecture Overview

## Design Philosophy

JMF is organized around three principles:

1. **Business logic is engine-free.** The `Core` project has zero references to RPH or GTA dlls. All GTA interactions are behind interfaces with fake implementations used in tests.
2. **Stable IDs over native handles.** GUIDs are the source of truth for entities. GTA handle values are ephemeral and trusted only within a session.
3. **Content is data; mechanics are code.** New vehicles, peds, and props are added via XML. New gameplay systems require compilation.

## Project Structure

```
JaysModFramework.Core       // interfaces + business logic; no RPH/GTA references
JaysModFramework.Rph        // RPH implementations of Core interfaces
JaysModFramework.Tests      // xUnit/NUnit; references Core only
Plugins/*                   // plugins reference Core; use injected interfaces
```

See [Tech Stack](tech-stack.md) for language and runtime details.

## Core Systems

### Entity System

Every game object the framework manages (prop, vehicle, ped) has:
- A **stable GUID** — assigned by the framework, lives in XML, survives sessions.
- A **runtime handle** — GTA's native entity handle, valid only for the current session.

The `EntityRegistry` maps between them. On session load, entities are re-spawned from their stored definitions.

See [Entity System — Technical Design](../features/entity-system/wip-technical-design.md).

### World Architecture

The world is organized as:

```
Worldspace
  └── Maps (one or more)
        ├── Required Interiors (by InteriorId enum)
        ├── Props
        ├── Peds (map-local)
        └── Vehicles (map-local)
```

A **worldspace** is a contiguous fictional region (San Andreas, Cayo Perico, a re-dressed Liberty City). A **map** is a specific scene within a worldspace defined in XML.

See [World Architecture — Technical Design](../features/world-architecture/wip-technical-design.md).

### Interior System

GTA V interiors vary too widely in activation requirements to generalize into config. Each interior is represented by an `InteriorId` enum value and fully encapsulated in a handler class. Maps reference interiors by enum name; activation details are never in content files.

See [Interior System — Technical Design](../features/interior-system/wip-technical-design.md).

### Save/Load

Save files serialize **definitions**, not handles. On load, entities are re-registered from definitions and then spawned when conditions are met.

See [Save/Load — Technical Design](../features/save-load/wip-technical-design.md).

### Tick Manager

A central `TickManager` runs in a GameFiber yield loop and dispatches to registered `ITickable` systems each frame. Used for: spawn condition evaluation, streaming, ambient system updates.

## Key Architectural Decisions

| Decision | Document |
|---|---|
| RPH chosen over SHVDN | [ADR-0001](decisions/adr-0001-rph-vs-shvdn.md) |
| Interiors are code, not config | [ADR-0002](decisions/adr-0002-interiors-not-data-driven.md) |
| Engine-free core for GTA VI portability | [ADR-0003](decisions/adr-0003-gta6-portability.md) |

## Principles Summary

1. **Stable IDs over native handles** — GUIDs are the source of truth; handles are ephemeral.
2. **Definitions are serialized, not handles** — save files capture definitions; entities are re-spawned on load.
3. **Engine-mutable properties read live** — position/heading always read from handle when spawned.
4. **Register then spawn** — entities are defined before the world is ready; spawned when conditions are met.
5. **Business logic is engine-free** — core framework has no RPH/GTA dependency; fully unit-testable.
6. **Content is data; mechanics are code** — new models via XML; new game systems require compilation.
7. **Interiors are code, not config** — too varied to generalize; enum + factory + handler pattern.
8. **Worldspace is fiction; map is technical** — the fictional region and the GTA geometry it uses are separate concerns.
9. **GTA VI portability** — the abstraction layer is the porting boundary; only RPH implementations get rewritten.
