---
type: feature-readme
feature: siren-manager
status: planned
---

# Siren Manager (Plugin)

## Summary

A plugin that allows siren lights to remain active while the siren sound is muted. Models siren state (off, lights only, slow wail, yelp, manual) as a state machine.

## Current Status

Planned. No implementation exists yet.

## Key Design Notes

- Key native: `SET_VEHICLE_HAS_MUTED_SIRENS`.
- Siren patterns modelled as a state machine — fully testable in Core with no real native calls.
- Only the final native call (applying the pattern to the vehicle) requires a real RPH implementation.

## Open Questions

- Input system design (key polling vs. event-based) — see technical design.
- Sound pattern selection for SlowWail/Yelp/Manual modes — requires native research.

## Documents

- [Technical Design](technical-design.md)

## Related Documentation

- [Plugin System — Technical Design](../plugin-system/technical-design.md)
- [Architecture Overview](../../architecture/wip-overview.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
