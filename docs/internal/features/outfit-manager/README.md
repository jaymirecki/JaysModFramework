---
type: feature-readme
feature: outfit-manager
status: planned
---

# Outfit Manager (Plugin)

## Summary

A menu-driven plugin for switching outfits on the player and mod-managed peds. Tied to the save system for outfit ownership states.

## Current Status

Planned. No implementation exists yet.

## Key Design Notes

- Player always uses the multiplayer freemode ped model (`mp_m_freemode_01` / `mp_f_freemode_01`) to support full customization.
- Outfits are composed of:
  - Drawable components (slots 0–11).
  - Prop components (hat, glasses, watch, bracelet, etc.).
  - Head blend data (face shape / skin tone).
  - Head overlays (hair color, makeup, tattoos).
- Outfit ownership states: `Owned`, `Locked`, `Preview`.
- Unlock conditions tied to save flags or mission progression.
- The `PedRegistry` tracks all mod-managed peds and their current outfit for save/restore.

## Open Questions

- Plugin registration mechanism — depends on plugin architecture design. Design TBD.
- Menu/UI system — design TBD.
- Whether outfits are per-ped or from a shared library — design TBD.
- Technical design for head blend / overlay serialization — design TBD.

## Related Documentation

- [Architecture Overview](../../architecture/wip-overview.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
