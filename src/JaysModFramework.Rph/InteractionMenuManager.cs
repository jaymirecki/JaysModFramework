using System;
using LemonUI;
using LemonUI.Menus;
using Rage;

namespace JaysModFramework.Rph;

/// <summary>
/// Manages the JMF interaction menu. Opens and closes on a hold of the CharacterWheel
/// control (controller: D-Pad Down; keyboard: Alt).
/// </summary>
internal sealed class InteractionMenuManager
{
    private readonly ObjectPool _pool = new ObjectPool();
    private readonly NativeMenu _menu;

    private DateTime? _holdStart;
    private bool _holdTriggered;

    private static readonly TimeSpan HoldDuration = TimeSpan.FromMilliseconds(500);

    public InteractionMenuManager()
    {
        _menu = new NativeMenu("JMF", "Interaction Menu");
        _pool.Add(_menu);

        AddDebugSubmenu();

        Log.Info("Interaction menu ready");
    }

    private void AddDebugSubmenu()
    {
        var debugMenu = new NativeMenu("JMF", "Debug");
        _pool.Add(debugMenu);
        _menu.AddSubMenu(debugMenu);

        var logPosition = new NativeItem("Log Position", "Writes the player's current coordinates to the JMF log.");
        logPosition.Activated += (_, _) =>
        {
            var pos = Game.LocalPlayer.Character.Position;
            Log.Info($"Player position: X={pos.X:F2}, Y={pos.Y:F2}, Z={pos.Z:F2}");
        };
        debugMenu.Add(logPosition);
    }

    public void Tick()
    {
        _pool.Process();

        if (Game.IsControlPressed(0, GameControl.CharacterWheel))
        {
            _holdStart ??= DateTime.UtcNow;

            if (!_holdTriggered && DateTime.UtcNow - _holdStart.Value >= HoldDuration)
            {
                _menu.Visible = !_menu.Visible;
                _holdTriggered = true;
                Log.Debug($"Interaction menu {(_menu.Visible ? "opened" : "closed")}");
            }
        }
        else
        {
            _holdStart = null;
            _holdTriggered = false;
        }
    }
}
