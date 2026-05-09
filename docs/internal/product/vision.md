---
type: product-vision
status: active
---

# Product Vision

## Mission

JaysModFramework (JMF) is a singleplayer GTA V modding framework that enables RPG-style game conversions on top of the base game.

The framework acts as an **engine layer**: it provides systems, and content is defined in data. Plugins built on the framework interact with clean interfaces rather than raw GTA natives.

## Core Value Proposition

- **For plugin authors**: write gameplay logic against stable, well-defined interfaces rather than GTA's low-level native functions.
- **For content creators**: add new vehicles, peds, props, outfits, and items by editing XML — no recompilation required.
- **For the project**: a single coherent save/load, entity, and world system that all plugins share.

## Long-Term Goal: GTA VI Portability

A secondary goal is portability to GTA VI when its modding tools mature.

All GTA-specific interactions are routed through abstraction interfaces. The RPH implementations of those interfaces are the only code that would need to be rewritten for a new game. Framework core and plugins remain intact.

This is an explicit architectural constraint, not a retrofit. See [ADR-0003](../architecture/decisions/adr-0003-gta6-portability.md).

## Explicit Scope Boundary

**Content is data; mechanics are code.**

Adding new vehicles, ped models, props, outfits, and weapons requires only XML edits. If a GTA update introduces new native functions or new gameplay systems, a framework code update is required. This boundary is accepted and by design.

## Related Documentation

- [Architecture Overview](../architecture/wip-overview.md)
- [Tech Stack](../architecture/wip-tech-stack.md)
- [ADR-0003: GTA VI Portability](../architecture/decisions/adr-0003-gta6-portability.md)
