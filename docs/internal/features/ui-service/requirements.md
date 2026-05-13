---
type: requirements
feature: ui-service
status: active
---

# UIService — Requirements

## Overview

`INativeFramework.UIService` is the Native layer interface for rendering information to the player. It wraps RPH/GTA native UI calls and exposes them to the Framework layer without introducing a GTA dependency in Core.

## Functional Requirements

### Notify

```csharp
UIService.Notify(string message);
```

Renders a notification to the player above the minimap containing the provided message. Duration and styling follow GTA V defaults.

## Out of Scope

- Custom notification duration or styling.
- Rendering to other screen locations (subtitle area, help text, etc.). These will be added as separate methods when a consumer requires them.
- Menu rendering. Menus are the responsibility of `Framework.MenuService`, which will use UIService as a building block in Step 2.

## Related Documentation

- [Logger — Requirements](../logger/requirements.md) — primary consumer of `Notify` in Step 1.
- [ADR-0005: Framework Layer Architecture](../../architecture/decisions/adr-0005-framework-layer-architecture.md)
