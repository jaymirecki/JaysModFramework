using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.UI.InteractionMenu;

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
            root.AddSubmenu(DebugMenu.Build(_game));

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
