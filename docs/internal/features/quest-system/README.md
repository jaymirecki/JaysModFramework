---
type: feature-readme
feature: quest-system
status: stub
---

# Quest System

## Summary

A mission and quest system inspired by Skyrim's stage/condition model: quests are defined as a series of stages with conditions and world-state consequences, not purely scripted linear sequences.

## Current Status

**Stub.** Design has not started. This system is not a dependency for other core systems — those systems query quest state via save flags, which are a simpler primitive. The quest system will be designed after the core framework and initial plugins are established.

## Known Design Intent (from initial design conversation)

- Missions defined as stages and objectives in XML.
- Completion of a stage can trigger: loading a map, setting a save flag, unlocking another mission, spawning entities, modifying world state.
- Branching is a goal.
- A non-voiced dialogue system is a named dependency (quests can invoke dialogue; the two subsystems are otherwise separate).

## Dependency Note

Other systems (spawn conditions, map availability) do **not** depend on the quest system. They query save flags, which are a simpler primitive. This keeps those systems implementable before the quest system is designed.

## Related Documentation

- [Save/Load — Technical Design](../save-load/wip-technical-design.md) (save flags are the quest-system boundary)
- [Product Vision](../../product/vision.md)
