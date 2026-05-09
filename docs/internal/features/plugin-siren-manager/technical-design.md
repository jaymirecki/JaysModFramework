---
type: technical-design
feature: siren-manager
status: planned
related:
  - plugin-system
  - entity-system
---

# Siren Manager — Technical Design

## Overview

The Siren Manager plugin allows the player to independently control siren lights and siren audio in emergency vehicles. The player can cycle through siren modes without the default GTA behavior (sound and lights always on together).

The siren state machine is pure business logic in Core. Only the final native call (applying a mode to the vehicle) touches the RPH implementation layer.

## Siren Modes

```csharp
public enum SirenMode
{
    Off,          // no lights, no sound
    LightsOnly,   // lights active, sound muted
    SlowWail,     // lights + slow wail siren sound
    Yelp,         // lights + yelp siren sound
    Manual,       // lights + manual (horn-activated) siren
}
```

## Plugin Class

```csharp
public class SirenManagerPlugin : IPlugin
{
    private SirenState _state;
    private IGameWorld _gameWorld;

    public string Name => "Siren Manager";

    public void Initialize(IFrameworkServices services)
    {
        _gameWorld = services.GameWorld;
        _state = new SirenState();
        services.TickManager.Register(new SirenManagerTick(_state, services.GameWorld));
    }

    public void Shutdown()
    {
        // unregistration handled by TickManager if needed
    }
}
```

## SirenState

Encapsulates current mode and per-vehicle state. Fully testable with no native dependencies:

```csharp
public class SirenState
{
    public SirenMode CurrentMode { get; private set; } = SirenMode.Off;

    public void CycleMode()
    {
        CurrentMode = CurrentMode switch
        {
            SirenMode.Off        => SirenMode.LightsOnly,
            SirenMode.LightsOnly => SirenMode.SlowWail,
            SirenMode.SlowWail   => SirenMode.Yelp,
            SirenMode.Yelp       => SirenMode.Manual,
            SirenMode.Manual     => SirenMode.Off,
            _                    => SirenMode.Off,
        };
    }

    public void Reset() => CurrentMode = SirenMode.Off;
}
```

## SirenManagerTick

Per-frame logic registered with the `TickManager`. Applies the current mode to the player's vehicle each tick:

```csharp
public class SirenManagerTick : ITickable
{
    private readonly SirenState _state;
    private readonly IGameWorld _gameWorld;

    public SirenManagerTick(SirenState state, IGameWorld gameWorld)
    {
        _state = state;
        _gameWorld = gameWorld;
    }

    public void Tick()
    {
        var vehicle = _gameWorld.GetPlayerVehicle();

        if (vehicle == null || !vehicle.HasSirens)
        {
            _state.Reset();
            return;
        }

        ApplyMode(vehicle, _state.CurrentMode);
    }

    private void ApplyMode(IVehicle vehicle, SirenMode mode)
    {
        switch (mode)
        {
            case SirenMode.Off:
                vehicle.SetSirenActive(false);
                vehicle.SetSirenMuted(false);
                break;
            case SirenMode.LightsOnly:
                vehicle.SetSirenActive(true);
                vehicle.SetSirenMuted(true);
                break;
            case SirenMode.SlowWail:
            case SirenMode.Yelp:
            case SirenMode.Manual:
                vehicle.SetSirenActive(true);
                vehicle.SetSirenMuted(false);
                // sound pattern selection TBD
                break;
        }
    }
}
```

## IVehicle — Required Surface

The Siren Manager requires these members on `IVehicle`:

```csharp
public interface IVehicle
{
    bool HasSirens { get; }
    void SetSirenActive(bool active);
    void SetSirenMuted(bool muted);
}
```

Key RPH native: `SET_VEHICLE_HAS_MUTED_SIRENS` (for `SetSirenMuted`).

## Input Handling

**Design TBD.** The mode cycling needs to be triggered by player input (key press or controller button). The input system is not yet designed. Options:

- `IInputService` injected via `IFrameworkServices`, with an `OnKeyPressed` event.
- Polling approach in `SirenManagerTick.Tick()` via an `IInputReader` interface.

The `SirenState.CycleMode()` method is decoupled from input — whichever input approach is chosen, it calls `CycleMode()` on the correct trigger.

## What Is Testable Now

| Component | Can test without game? |
|---|---|
| `SirenState` mode cycling | Yes — pure state machine |
| `SirenState.Reset()` on no vehicle | Yes |
| `SirenManagerTick` applying mode to `FakeVehicle` | Yes |
| `SirenManagerTick` resetting on foot | Yes |
| RPH native calls (`SetSirenMuted`, etc.) | No — requires game |

## Implementation Order

1. Define `IVehicle` (minimum surface above).
2. Define `IGameWorld.GetPlayerVehicle()`.
3. Implement `SirenState` and `SirenManagerTick` in Core with tests.
4. Implement `PluginRegistry`, `IPlugin`, `ITickManager`, `IFrameworkServices` in Core.
5. Wire up `SirenManagerPlugin`.
6. Implement RPH concrete classes (`RphVehicle`, `RphGameWorld`, `RphTickManager`).
7. Implement input handling (TBD).
8. Test in-game.

## Open Questions

- **Input system design**: key polling vs. event-based. Design TBD.
- **Sound pattern selection**: how do SlowWail/Yelp/Manual differ in native terms? Requires GTA native research.
- **Multi-vehicle state**: if the player switches vehicles, should the previous vehicle's siren be reset? Current design resets on player exit (vehicle becomes null).

## Related Documentation

- [Plugin System — Technical Design](../plugin-system/technical-design.md)
- [Entity System — Technical Design](../entity-system/wip-technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
