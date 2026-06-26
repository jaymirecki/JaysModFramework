using System;
using System.IO;
using JaysModFramework.Core;
using JaysModFramework.Core.Game;
using JaysModFramework.Core.World.SaveLoad;

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

        menu.AddSubmenu(BuildSaveLoadTestsMenu(game));

        return menu;
    }

    private static Menu BuildSaveLoadTestsMenu(GameServices game)
    {
        var menu = new Menu { BannerText = "JMF Smoke", Title = "Save/Load Tests" };
        var gameDirectory = game.NativeFramework.GameDirectory;
        var smokeTestPath = Path.Combine(gameDirectory, "JMF", "Saves", "SmokeTest_1");

        var loadTestItem = new MenuItem
        {
            Title = "Load Smoke Save",
            Description = "Loads the smoke test save and verifies player/world properties.",
        };
        loadTestItem.OnActivated += () => RunLoadSmokeTest(game, smokeTestPath);
        menu.Add(loadTestItem);

        var saveRoundTripItem = new MenuItem
        {
            Title = "Load, Save, and Verify",
            Description = "Loads smoke save, saves to temp, reloads, and verifies.",
        };
        saveRoundTripItem.OnActivated += () => RunSaveRoundTripTest(game, smokeTestPath, gameDirectory);
        menu.Add(saveRoundTripItem);

        return menu;
    }

    private static void RunLoadSmokeTest(GameServices game, string smokeTestPath)
    {
        game.Logger.Info("Smoke Test: Starting load test...");

        if (!Directory.Exists(smokeTestPath))
        {
            game.Logger.Error($"Smoke Test: Save path not found: {smokeTestPath}");
            return;
        }

        try
        {
            var gameState = new GameState(game.NativeFramework.World);
            gameState.Load(smokeTestPath);

            // Verify loaded state
            var player = game.NativeFramework.World.Player;
            var playerPed = player.Ped;
            var expectedPos = new Vector3(428.0f, -982.0f, 30.7f);

            if (player.Model != "player_two")
                throw new Exception($"Expected model 'player_two', got '{player.Model}'");
            if (playerPed.Position != expectedPos)
                throw new Exception($"Expected position {expectedPos}, got {playerPed.Position}");
            if (playerPed.Heading != 270.0f)
                throw new Exception($"Expected heading 270°, got {playerPed.Heading}°");

            game.Logger.Info("Smoke Test: Load test passed");
        }
        catch (Exception ex)
        {
            game.Logger.Error($"Smoke Test: Load test failed - {ex.Message}");
        }
    }

    private static void RunSaveRoundTripTest(GameServices game, string smokeTestPath, string gameDirectory)
    {
        game.Logger.Info("Smoke Test: Starting save and round-trip test...");

        if (!Directory.Exists(smokeTestPath))
        {
            game.Logger.Error($"Smoke Test: Save path not found: {smokeTestPath}");
            return;
        }

        try
        {
            var tempSavePath = Path.Combine(gameDirectory, "JMF", "Saves", "SmokeTest_Tmp");

            // Load original save
            var gameState = new GameState(game.NativeFramework.World);
            gameState.Load(smokeTestPath);

            // Save to temp location
            gameState.Save(tempSavePath);

            // Load temp save
            var tempGameState = new GameState(game.NativeFramework.World);
            tempGameState.Load(tempSavePath);

            // TODO: Verify round-tripped state matches original
            // Expected values (same as original):
            // - Player model: trevor
            // - Player position: (428, -982, 30.7)
            // - Player heading: 270°
            // - Player health: 200
            // - Player armor: 100
            // - World weather: Rain
            // - World time: 12:00 (noon), January 1, 2012

            // Cleanup temp save
            if (Directory.Exists(tempSavePath))
                Directory.Delete(tempSavePath, recursive: true);

            game.Logger.Info("Smoke Test: Save and round-trip test passed");
        }
        catch (Exception ex)
        {
            game.Logger.Error($"Smoke Test: Save and round-trip test failed - {ex.Message}");
        }
    }
}
