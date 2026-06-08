using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Plugins;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.UI.InteractionMenu;

public class InteractionMenu
{
    private readonly GameServices _game;
    private readonly IGameWorld _world;
    private readonly INativeLifecycle _lifecycle;
    private readonly INativeUIService _uiService;
    private readonly Menu _rootMenu;

    internal InteractionMenu(Framework framework)
    {
        _game = framework.Game;
        _world = framework.World;
        _lifecycle = framework.NativeFramework.Lifecycle;
        _uiService = framework.NativeFramework.UIService;

        _rootMenu = BuildMenus();

        _lifecycle.Tick += OnTick;
        _lifecycle.DisabledControlHeld += OnControlHeld;
    }

    private Menu BuildMenus()
    {
        var root = new Menu { BannerText = "JMF", Title = "Interaction Menu" };

        if (_game.Settings.Framework.DebugMode)
            root.AddSubmenu(DebugMenu.Build(_game, _world));

        var pluginsMenu = new Menu { BannerText = "JMF", Title = "Plugins" };
        foreach (var plugin in _game.PluginManager.Plugins)
        {
            if (plugin is MenuPlugin menuPlugin)
                pluginsMenu.AddSubmenu(menuPlugin.Menu);
        }
        if (pluginsMenu.Items.Count > 0)
            root.AddSubmenu(pluginsMenu);

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
