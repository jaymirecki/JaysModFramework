---
type: feature-readme
feature: save-load
status: planned
---

# Save/Load

## Summary

The save/load system serializes and restores the game state between sessions. It operates on **definitions**, not runtime handles — entities are re-spawned from their stored definitions on load.

## Current Status

Planned. No implementation exists yet.

## Key Concepts

- Save files contain entity definitions (position, model, spawn conditions, etc.), not GTA handle values.
- On load: deserialize definitions → register all entities → spawn those whose conditions are met.
- Session-persistent entities (player's vehicles, companions, quest-critical peds) are tracked in the save file. Map-local (transient) entities are not.

## Related Systems

- [Entity System](../entity-system/README.md) — definitions are the unit of save/restore.
- [World Architecture](../world-architecture/README.md) — worldspace and map state may also be saved.

## Documents

- [Technical Design](wip-technical-design.md)
