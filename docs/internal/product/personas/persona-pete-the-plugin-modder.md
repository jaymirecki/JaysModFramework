---
type: persona
name: Pete the Plugin Modder
status: active
---

# Persona: Pete the Plugin Modder

## Role

A C# developer building plugins on top of the framework. Pete writes gameplay logic (siren management, vehicle spawning, outfit systems, missions) against the framework's Core interfaces. Currently, Pete is Jay — but the framework is designed with Pete as a distinct role in mind, so that future contributors or future-Jay returning after a break can be productive.

## Goals

- Implement gameplay features without touching GTA native APIs directly.
- Write testable logic that can be verified without a running game.
- Understand what the framework provides and where the boundaries are.
- Rely on stable, documented interfaces that don't change unexpectedly.

## Frustrations

- Interfaces that expose GTA-specific concepts, forcing him to reason about natives.
- No documentation on what the framework provides vs. what he must implement himself.
- Business logic that can't be tested without launching GTA V.
- Framework internals that he needs to change to make his plugin work.

## Technical Sophistication

High. Pete knows C# and .NET well. He has working knowledge of GTA V modding concepts (natives, handles, models, IPLs). He does not need to be protected from complexity, but he does need clear contracts.

## Workflow

1. Identify what gameplay behavior is needed.
2. Check if the framework provides a service or system for it.
3. Implement plugin logic against Core interfaces.
4. Write unit tests with fake implementations.
5. Register the plugin; test in-game with the RPH implementation.

## Implications for Design

- Core interfaces must be clean and complete enough that Pete never needs to reach into `Rph` directly.
- The plugin registration pattern must be simple — Pete should be able to add a new plugin in a few lines.
- Framework documentation (these docs) must be Pete's primary reference, not the source code.
- `IFrameworkServices` must expose all common services Pete will need without being a grab-bag.

## Related Documentation

- [Persona: Carla the Content Modder](persona-carla-the-content-modder.md)
- [Plugin System — Technical Design](../../features/plugin-system/technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
- [Product Vision](../vision.md)
