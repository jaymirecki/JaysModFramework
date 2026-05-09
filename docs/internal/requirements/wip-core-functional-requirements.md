---
type: requirements
status: draft
---

# Core Functional Requirements

> **Status: Stub** — needs further specification of acceptance criteria.

## Known Requirements (from design)

The following are derived from the architecture design conversation. They need to be refined into testable acceptance criteria.

### Entity System

- The framework must assign a stable GUID to every managed entity.
- Entity definitions must be serializable to and from XML.
- Entities must be spawnable and despawnable independently of their definitions.
- Spawn conditions must be evaluable without spawning the entity.
- Vehicle custody must transition correctly when a player enters and drives away a map-owned vehicle.

### World Architecture

- Maps must be loadable from XML with no code changes.
- Adding a new map must require only an XML file addition.
- Required interiors must activate before map entities spawn.

### Save/Load

- A save file must contain enough information to fully restore session-persistent entities after a game restart.
- Engine-mutable properties (position, heading) must reflect their live values at save time.
- Loading a save must not require spawning all entities immediately — spawn must be condition-gated.

### Interior System

- Each interior's activation must be fully encapsulated and not leak activation details into XML.

## Open Questions

- What are the non-functional performance requirements? (e.g. max entity count before frame impact?)
- What are the failure modes that must be handled gracefully? (e.g. model fails to load, save file corrupt?)

## Related Documentation

- [Architecture Overview](../architecture/wip-overview.md)
- [Non-Functional Requirements](wip-non-functional-requirements.md)
