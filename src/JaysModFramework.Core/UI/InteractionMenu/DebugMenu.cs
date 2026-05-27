using JaysModFramework.Core.Game;

namespace JaysModFramework.Core.UI.InteractionMenu;

internal static class DebugMenu
{
    internal static Menu Build(GameServices game)
    {
        var menu = game.MenuService.CreateMenu("JMF", "Debug");

        var showPos = new MenuItem
        {
            Title = "Show Position",
            Description = "Log the player's current position to the JMF log.",
        };
        showPos.OnActivated += () => game.Logger.Info("Player position: X=0.00, Y=0.00, Z=0.00");

        var logModel = new MenuItem
        {
            Title = "Log Current Model",
            Description = "Log the player's current model name to the JMF log.",
        };
        logModel.OnActivated += () => game.Logger.Info("Current model: player_zero");

        menu.Add(showPos);
        menu.Add(logModel);

        var smokeTestMenu = SmokeTestMenu.Build(game);
        var smokeTestItem = new MenuItem
        {
            Title = "Smoke Test Menu",
            Description = "Close this menu and open the smoke test menu.",
        };
        smokeTestItem.OnActivated += () => game.MenuService.ShowMenu(smokeTestMenu);
        menu.Add(smokeTestItem);

        return menu;
    }
}
