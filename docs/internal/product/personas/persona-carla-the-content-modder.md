---
type: persona
name: Carla the Content Modder
status: active
---

# Persona: Carla the Content Modder

## Role

A content creator who adds vehicles, ped models, props, outfits, maps, and items to the game by editing XML files. Carla does not write C# code. Currently, Carla is also Jay — but the framework is designed so that content can be added without any compilation.

## Goals

- Add new content to the game (vehicles, outfits, map props, peds) without touching code.
- Have a clear, consistent XML format that is easy to learn and hard to break.
- Know immediately if her XML is invalid (ideally with a clear error message, not a silent failure or crash).
- Be able to add content from GTA Online updates or modded add-on assets without waiting for a framework update.

## Frustrations

- XML schema changes that invalidate existing content files.
- Silent failures when a model name is wrong — the game loads but nothing appears.
- Content that requires code changes to activate (e.g. interiors).
- Unclear documentation on what XML attributes are required vs. optional.

## Technical Sophistication

Moderate. Carla is comfortable editing structured text files and understands GTA model naming conventions. She does not know C# and should never need to.

## Workflow

1. Find the model name for the vehicle/ped/prop she wants to add.
2. Edit the relevant XML file (map, worldspace, content library).
3. Launch the game and verify the content appears correctly.

## Implications for Design

- XML schema must be stable. Breaking changes require migration tooling or versioning.
- Model names are opaque strings — Carla provides them, the framework resolves them at runtime.
- Validation should fail loudly at load time with clear messages, not silently at spawn time.
- Interiors are intentionally kept out of XML — Carla references them by name, Pete implements them.

## Related Documentation

- [Persona: Pete the Plugin Modder](persona-pete-the-plugin-modder.md)
- [Data Model](../../architecture/wip-data-model.md)
- [Product Vision](../vision.md)
