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
            }
        }
        else
        {
            _holdStart = null;
            _holdTriggered = false;
        }
    }
}
