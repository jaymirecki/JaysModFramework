---
type: glossary
status: active
---

# Glossary

Shared terminology for JaysModFramework (JMF).

---

## JMF

**JaysModFramework.** The abbreviated name for the project, used throughout documentation and in conversation.

---

## Core

The `JaysModFramework.Core` project. Contains all interfaces and business logic. Has zero references to RPH or GTA dlls. See [ADR-0003](../architecture/decisions/adr-0003-gta6-portability.md).

---

## Entity

A framework-managed game object — a prop, vehicle, or ped. Every entity has a stable GUID (framework-assigned, lives in XML) and a runtime handle (GTA-assigned, valid for the current session only).

---

## Handle

A GTA native entity handle. Ephemeral — valid only for the current game session. Never stored in save files or used as a cross-reference. See [Stable ID](#stable-id).

---

## ITickable

An interface implemented by systems that need per-frame evaluation. Registered with the `TickManager`. See [Plugin System](../features/plugin-system/technical-design.md).

---

## Interior

A GTA V interior space. Activated by the framework via an `IInteriorHandler` before map entities spawn. Referenced in XML by `InteriorId` enum name only; activation logic is always code. See [Interior System](../features/interior-system/wip-technical-design.md).

---

## Map

A specific scene or location within a worldspace, defined entirely in XML. Contains required interiors, props, peds, and vehicles. See [World Architecture](../features/world-architecture/wip-technical-design.md).

---

## Plugin

A self-contained gameplay module implementing `IPlugin`. Registered with the `PluginRegistry` at framework startup. See [Plugin System](../features/plugin-system/technical-design.md).

---

## RPH

**RAGEPluginHook.** The chosen GTA V scripting runtime. Provides the GameFiber concurrency model. See [ADR-0001](../architecture/decisions/adr-0001-rph-vs-shvdn.md).

---

## Save Flag

A named boolean value stored in the save file. Used to communicate state across systems (quest progression, unlock states, spawn conditions) without creating direct dependencies between those systems.

---

## Stable ID

A `Guid` assigned by the framework to a managed entity. Permanent — survives sessions, stored in XML, used as the canonical cross-reference between entities. Contrasted with the ephemeral GTA [handle](#handle).

---

## Worldspace

A contiguous fictional region the player can traverse without a loading screen (e.g. San Andreas, Cayo Perico). A fictional geography concept, not a technical map-loading concept. See [World Architecture](../features/world-architecture/wip-technical-design.md).

---

## Related Documentation

- [Architecture Overview](../architecture/wip-overview.md)
- [Product Vision](vision.md)
