using JaysModFramework.Core.Game;

namespace JaysModFramework.Core.UI.InteractionMenu;

internal static class SmokeTestMenu
{
    internal static Menu Build(GameServices game)
    {
        var menu = new Menu { BannerText = "JMF Smoke", Title = "Smoke Test Menu" };

        var exampleItem = new MenuItem
        {
            Title = "Example Item",
            Description = "Logs a debug message on activate and on select.",
        };
        exampleItem.OnActivated += () => game.Logger.Debug("Smoke: example item activated.");
        exampleItem.OnSelected += () => game.Logger.Debug("Smoke: example item selected.");
        menu.Add(exampleItem);

        var subMenu = new Menu { BannerText = "JMF Smoke", Title = "Smoke Sub Menu" };
        var subItem = new MenuItem
        {
            Title = "Sub Item",
            Description = "An item inside the smoke test sub-menu.",
        };
        subItem.OnActivated += () => game.Logger.Debug("Smoke: sub item activated.");
        subItem.OnSelected += () => game.Logger.Debug("Smoke: sub item selected.");
        subMenu.Add(subItem);
        menu.AddSubmenu(subMenu);

        var listItem = new MenuListItem<string>(new[] { "Alpha", "Bravo", "Charlie" })
        {
            Title = "List Item",
            Description = "Cycles through options. Logs selection on activate.",
        };
        listItem.OnItemChanged += val => game.Logger.Debug($"Smoke: list item changed to '{val}'.");
        listItem.OnActivated += () => game.Logger.Debug($"Smoke: list item activated with '{listItem.SelectedItem}'.");
        menu.Add(listItem);

        var toggleItem = new MenuItem
        {
            Title = "Toggle Items Enabled",
            Description = "Toggles the Enabled state of all other items in this menu.",
        };
        toggleItem.OnActivated += () =>
        {
            foreach (var item in menu.Items)
            {
                if (item != toggleItem)
                    item.Enabled = !item.Enabled;
            }
            game.MenuService.RefreshMenu();
        };
        menu.Add(toggleItem);

        return menu;
    }
}
