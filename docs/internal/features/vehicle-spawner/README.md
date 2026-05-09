---
type: feature-readme
feature: vehicle-spawner
status: planned
---

# Vehicle Spawner (Plugin)

## Summary

A plugin that spawns vehicles at configurable locations relative to the player. Handles async model loading and maintains a favorites/history list.

## Current Status

Planned. No implementation exists yet.

## Key Design Notes

- Async model loading pattern: request model → yield (GameFiber) → spawn once loaded.
- Spawn position validation (road surface, not inside a building, not blocking traffic) — specifics TBD.
- Favorites and history list persisted in XML.
- Spawn position is relative to the player (in front, behind, nearby road node, etc.) — exact modes TBD.

## Open Questions

- Plugin registration mechanism — depends on plugin architecture design. Design TBD.
- Spawn position modes and validation rules — design TBD.
- UI/menu design — design TBD.

## Related Documentation

- [Architecture Overview](../../architecture/wip-overview.md)
- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
