---
type: feature-readme
feature: interior-system
status: planned
---

# Interior System

## Summary

The interior system manages activation and deactivation of GTA V interiors (MLOs, IPLs, entity sets). Because GTA interiors vary too widely in activation requirements to generalize into config, each interior is implemented as a code handler behind a common interface.

## Current Status

Planned. No implementation exists yet.

## Key Concepts

- Each interior is identified by an `InteriorId` enum value.
- Each interior's activation logic is encapsulated in a handler class implementing `IInteriorHandler`.
- Maps reference interiors by enum name — activation details never appear in content files.
- Common interiors (MLO, IPL) use a generic parameterized handler. Edge cases get a dedicated class.

## Related Systems

- [World Architecture](../world-architecture/README.md) — maps declare required interiors.
- [Entity System](../entity-system/README.md) — interiors activate before map entities spawn.

## Documents

- [Technical Design](wip-technical-design.md)
- [ADR-0002: Interiors Not Data-Driven](../../architecture/decisions/adr-0002-interiors-not-data-driven.md)
