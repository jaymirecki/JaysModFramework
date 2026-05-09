---
type: feature-readme
feature: entity-system
status: planned
---

# Entity System

## Summary

The entity system is the foundation of the framework. It manages all game objects the framework owns — props, vehicles, and peds — bridging their stable framework identity (GUID) with their ephemeral GTA runtime handle.

## Current Status

Planned. No implementation exists yet.

## Key Concepts

- Every managed entity has a **stable GUID** (lives in XML, survives sessions) and a **runtime handle** (valid for this session only).
- Properties backed by GTA's physics engine (position, heading) always read live from the handle when spawned.
- Entities are **registered first, spawned when conditions are met** — not spawned immediately on creation.
- Vehicles have a three-state **custody model** to handle the case of a player driving off in a map-owned vehicle.

## Related Systems

- [Save/Load](../save-load/README.md) — entity definitions are the unit of save/restore.
- [World Architecture](../world-architecture/README.md) — maps register map-local entities via the registry.
- [Interior System](../interior-system/README.md) — interiors activate before their entities spawn.

## Documents

- [Technical Design](wip-technical-design.md)
- [Data Model](../../architecture/wip-data-model.md)
