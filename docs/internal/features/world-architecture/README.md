---
type: feature-readme
feature: world-architecture
status: planned
---

# World Architecture

## Summary

The world architecture defines how the framework organizes fictional geography (worldspaces), specific scenes within them (maps), and how players move between them (transition points).

## Current Status

Planned. No implementation exists yet.

## Key Concepts

- A **worldspace** is a contiguous fictional region the player can traverse without loading screens (San Andreas, Cayo Perico, etc.). It is a _fictional geography concept_, not a technical map-loading concept.
- A **map** is a specific scene or location within a worldspace, defined in XML with its props, peds, vehicles, and required interiors.
- **Transition points** connect worldspaces via fade, tunnel, seamless air crossing, or loading screen.

## Hierarchy

```
Worldspace
  └── Maps (one or more)
        ├── Required Interiors (by InteriorId enum)
        ├── Props
        ├── Peds (map-local)
        └── Vehicles (map-local)
```

## Open Questions

- Entity handoff across transitions (owned vehicle, companion peds).
- Ambient config transitions (immediate vs. gradual weather change on worldspace transition).
- Worldspace streaming (proximity-based map activation vs. all-at-once load).

## Related Systems

- [Entity System](../entity-system/README.md) — maps register entities through the entity registry.
- [Interior System](../interior-system/README.md) — maps declare required interiors by enum name.
- [Save/Load](../save-load/README.md) — session-persistent entities travel with the player.

## Documents

- [Technical Design](wip-technical-design.md)
