---
type: requirements
feature: lifecycle
status: active
---

# Lifecycle — Requirements

## Overview

`INativeFramework.Lifecycle` is the Native layer interface that exposes the game's tick cycle and player control interactions as events. It abstracts raw native press/release states into meaningful interaction types (clicked, held, double-clicked) using timers, so Framework consumers never deal with raw input states or timing logic.

## Functional Requirements

### Tick

- `Lifecycle` exposes a `Tick` event that fires once per game frame.
- The RPH implementation drives this from inside the GameFiber yield loop.
- Subscribers use `Tick` for per-frame work: rendering menus, suppressing the native interaction menu, evaluating conditions, etc.

### Control Interaction Events

`Lifecycle` exposes three derived control interaction events, evaluated each frame from raw native pressed/released states and per-control timers:

```csharp
public interface INativeLifecycle
{
    event Action Tick;
    event Action<JmfControl> ControlClicked;       // quick press and release
    event Action<JmfControl> ControlHeld;          // held beyond the hold threshold
    event Action<JmfControl> ControlDoubleClicked; // two clicks within the double-click window
}
```

#### Clicked
Fired when a control is pressed and released within the hold threshold duration, and is not the second press of a double-click sequence.

#### Held
Fired once when a control has been continuously pressed for at least the hold threshold duration. Not fired again until the control is released and re-pressed.

#### DoubleClicked
Fired when a control is clicked twice within the double-click window. The second click must begin before the window expires after the first click. A double-click does not also fire two `ControlClicked` events.

### Interaction Thresholds

| Threshold | Default | Purpose |
|---|---|---|
| Hold threshold | 500ms | Distinguishes click from hold |
| Double-click window | 300ms | Maximum time between two clicks for a double-click |

Thresholds are hardcoded for now; configurable in a future settings group if needed.

### JmfControl

A Core enum representing the subset of game controls JMF cares about. The RPH implementation maps `JmfControl` values to RPH `GameControl` values and checks only mapped controls each frame.

```csharp
public enum JmfControl
{
    InteractionMenu,  // M on keyboard / touchpad on controller; maps to GameControl.InteractionMenu (244) in RPH
    // expanded as plugins require additional controls
}
```

### INativeFramework

`INativeFramework` gains a `Lifecycle` property:

```csharp
public interface INativeFramework
{
    string GameDirectory { get; }
    INativeUIService UIService { get; }
    INativeLifecycle Lifecycle { get; }
}
```

### RPH Implementation

`RphLifecycleService` runs the GameFiber yield loop and owns all timing logic:

- Maintains an explicit mapping of `JmfControl` → `GameControl` — the single place in the codebase where JMF controls resolve to native controls.
- Tracks per-control state: time of first press, time of last click, whether a hold event has already been fired for the current press.
- Each frame: fires `Tick`, then evaluates each mapped control and fires the appropriate derived event(s).
- The RPH entry point constructs `RphLifecycleService` and starts its loop; the loop runs for the lifetime of the plugin.

## Out of Scope

- Raw `ControlPressed` / `ControlReleased` events are not exposed to Framework consumers — only the derived events are.
- Configurable thresholds. Hardcoded for now.
- Simultaneous multi-control combinations (e.g. chord inputs).

## Related Documentation

- [Interaction Menu — Requirements](../plugin-interaction-menu/requirements.md)
- [ADR-0005: Framework Layer Architecture](../../architecture/decisions/adr-0005-framework-layer-architecture.md)
