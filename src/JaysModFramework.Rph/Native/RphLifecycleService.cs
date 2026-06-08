using System;
using System.Collections.Generic;
using JaysModFramework.Core;
using JaysModFramework.Core.Native;
using Rage;
using Rage.Native;

namespace JaysModFramework.Rph.Native;

internal sealed class RphLifecycleService : INativeLifecycle
{
    private const double HoldThresholdMs = 500;
    private const double DoubleClickWindowMs = 300;

    private static readonly Dictionary<JmfControl, GameControl> ControlMap =
        new Dictionary<JmfControl, GameControl>
        {
            [JmfControl.InteractionMenu] = GameControl.InteractionMenu,
            [JmfControl.SirenCycle]      = GameControl.VehicleHorn,
        };

    private static readonly Dictionary<JmfControl, GameControl> DisabledControlMap =
        new Dictionary<JmfControl, GameControl>
        {
            [JmfControl.CharacterWheel] = GameControl.CharacterWheel,
        };

    public event Action Tick;
    public event Action<JmfControl> ControlClicked;
    public event Action<JmfControl> ControlHeld;
    public event Action<JmfControl> ControlDoubleClicked;
    public event Action<JmfControl> DisabledControlClicked;
    public event Action<JmfControl> DisabledControlHeld;
    public event Action<JmfControl> DisabledControlDoubleClicked;

    private sealed class ControlState
    {
        public DateTime? PressStart;
        public DateTime? LastClickTime;
        public bool HeldFired;
        public bool WaitingForDoubleClick;
        public bool WasPressed;
    }

    private readonly Dictionary<JmfControl, ControlState> _states =
        new Dictionary<JmfControl, ControlState>();

    private readonly Dictionary<JmfControl, ControlState> _disabledStates =
        new Dictionary<JmfControl, ControlState>();

    internal RphLifecycleService()
    {
        foreach (var control in ControlMap.Keys)
            _states[control] = new ControlState();
        foreach (var control in DisabledControlMap.Keys)
            _disabledStates[control] = new ControlState();
    }

    internal void Run(Framework framework)
    {
        while (true)
        {
            ProcessControls();
            Tick?.Invoke();
            GameFiber.Yield();
        }
    }

    private void ProcessControls()
    {
        var now = DateTime.UtcNow;

        foreach (var kvp in ControlMap)
        {
            var state = _states[kvp.Key];
            ProcessControlState(kvp.Key, state, now,
                Game.IsControlJustPressed(0, kvp.Value),
                Game.IsControlPressed(0, kvp.Value),
                Game.IsControlJustReleased(0, kvp.Value),
                ControlClicked, ControlHeld, ControlDoubleClicked);
        }

        foreach (var kvp in DisabledControlMap)
        {
            var state = _disabledStates[kvp.Key];
            int control = (int)kvp.Value;
            bool pressed = NativeFunction.CallByHash<bool>(0xE2587F8CBBD87B1D, 0, control);
            bool justPressed = pressed && !state.WasPressed;
            bool justReleased = !pressed && state.WasPressed;
            state.WasPressed = pressed;
            ProcessControlState(kvp.Key, state, now,
                justPressed, pressed, justReleased,
                DisabledControlClicked, DisabledControlHeld, DisabledControlDoubleClicked);
        }
    }

    private void ProcessControlState(
        JmfControl control, ControlState state, DateTime now,
        bool justPressed, bool pressed, bool justReleased,
        Action<JmfControl> clicked, Action<JmfControl> held, Action<JmfControl> doubleClicked)
    {
        if (justPressed)
        {
            state.PressStart = now;
            state.HeldFired = false;
        }

        if (pressed && !state.HeldFired && state.PressStart.HasValue)
        {
            if ((now - state.PressStart.Value).TotalMilliseconds >= HoldThresholdMs)
            {
                state.HeldFired = true;
                state.WaitingForDoubleClick = false;
                state.LastClickTime = null;
                held?.Invoke(control);
            }
        }

        if (justReleased && state.PressStart.HasValue)
        {
            var heldMs = (now - state.PressStart.Value).TotalMilliseconds;
            state.PressStart = null;

            if (!state.HeldFired && heldMs < HoldThresholdMs)
            {
                if (state.WaitingForDoubleClick && state.LastClickTime.HasValue &&
                    (now - state.LastClickTime.Value).TotalMilliseconds <= DoubleClickWindowMs)
                {
                    state.WaitingForDoubleClick = false;
                    state.LastClickTime = null;
                    doubleClicked?.Invoke(control);
                }
                else
                {
                    state.WaitingForDoubleClick = true;
                    state.LastClickTime = now;
                }
            }
        }

        if (state.WaitingForDoubleClick && state.LastClickTime.HasValue &&
            (now - state.LastClickTime.Value).TotalMilliseconds > DoubleClickWindowMs)
        {
            state.WaitingForDoubleClick = false;
            state.LastClickTime = null;
            clicked?.Invoke(control);
        }
    }
}
