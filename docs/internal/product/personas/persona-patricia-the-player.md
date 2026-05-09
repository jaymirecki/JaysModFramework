---
type: persona
name: Patricia the Player
status: active
---

# Persona: Patricia the Player

## Role

The end user. Patricia plays games built on top of JMF. She has no awareness of the framework itself — she interacts with the game experience the framework enables.

## Goals

- Play an immersive RPG-style game in GTA V.
- Customize her character's appearance and own vehicles.
- Progress through missions and experience a coherent world.
- Have a stable, crash-free experience.

## Frustrations

- Bugs that break immersion (NPCs in wrong outfits, vehicles disappearing, save data lost).
- Jarring transitions between locations.
- Mods that conflict with each other or with base GTA V behavior.

## Technical Sophistication

Low to none regarding modding. She installs the mod and plays. She should never need to edit a file or understand GTA native concepts.

## Relationship to the Framework

Patricia interacts with **games built on** the framework, not the framework itself. Her experience is the ultimate measure of framework correctness, but her needs are expressed through plugin and content design — not framework APIs.

## Implications for Design

- The entity system must be robust enough that Patricia never loses a vehicle or companion she cares about.
- Transitions between worldspaces must feel smooth and intentional.
- Save/load must be invisible — the game should always restore exactly as she left it.
- Performance overhead of the framework must not cause dropped frames in gameplay.

## Related Documentation

- [Persona: Pete the Plugin Modder](persona-pete-the-plugin-modder.md)
- [Product Vision](../vision.md)
