using JaysModFramework.Core.Native;
using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Game;

public class InteractionMenu
{
    private readonly GameServices _game;
    private readonly INativeLifecycle _lifecycle;
    private readonly INativeUIService _uiService;
    private readonly Menu _rootMenu;

    internal InteractionMenu(Framework framework)
    {
        _game = framework.Game;
        _lifecycle = framework.NativeFramework.Lifecycle;
        _uiService = framework.NativeFramework.UIService;

        _rootMenu = BuildMenus();

        _lifecycle.Tick += OnTick;
        _lifecycle.DisabledControlHeld += OnControlHeld;
    }

    private Menu BuildMenus()
    {
        var root = _game.MenuService.CreateMenu("JMF", "Interaction Menu");

        if (_game.Settings.Framework.DebugMode)
        {
            var debug = _game.MenuService.CreateMenu("JMF", "Debug");

            var showPos = new MenuItem { Title = "Show Position", Description = "Log the player's current position." };
            showPos.OnSelected += () => _game.Logger.Info("Player position: X=0.00, Y=0.00, Z=0.00");

            var logModel = new MenuItem { Title = "Log Current Model", Description = "Log the player's current model name." };
            logModel.OnSelected += () => _game.Logger.Info("Current model: player_zero");

            debug.Add(showPos);
            debug.Add(logModel);
            root.AddSubmenu(debug);
        }

        return root;
    }

    private void OnTick()
    {
        _uiService.SuppressNativeMenu();
        _uiService.ProcessFrame();
    }

    private void OnControlHeld(JmfControl control)
    {
        if (control != _game.Settings.Framework.MenuOpenControl)
            return;

        if (_game.MenuService.IsVisible)
            _game.MenuService.HideMenu();
        else
            _game.MenuService.ShowMenu(_rootMenu);
    }
}
