using JaysModFramework.Core.Game;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.UI.InteractionMenu;

internal static class DebugMenu
{
    internal static Menu Build(GameServices game, IGameWorld world)
    {
        var menu = new Menu { BannerText = "JMF", Title = "Debug" };

        var showPos = new MenuItem
        {
            Title = "Show Position",
            Description = "Log the player's current position to the JMF log.",
        };
        showPos.OnActivated += () =>
        {
            var ped = world.Player.Ped;
            var entity = (IEntity)(ped.Vehicle ?? (IEntity)ped);
            var pos = entity.Position;
            game.Logger.Debug($"Position: X={pos.X:F2}, Y={pos.Y:F2}, Z={pos.Z:F2}");
        };

        var logModel = new MenuItem
        {
            Title = "Log Current Model",
            Description = "Log the player's current model name to the JMF log.",
        };
        logModel.OnActivated += () =>
        {
            var ped = world.Player.Ped;
            var entity = (IEntity)(ped.Vehicle ?? (IEntity)ped);
            game.Logger.Debug($"Model: {entity.ModelName}");
        };

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
