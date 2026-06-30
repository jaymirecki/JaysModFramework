using JaysModFramework.Core.Data;
using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Plugins.Sirens;
using JaysModFramework.Core.Plugins.VehicleSpawner;
using JaysModFramework.Core.UI.InteractionMenu;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core;

public class Framework
{
    internal INativeFramework NativeFramework { get; }
    public GameServices Game { get; }
    public WorldService World { get; }
    public EntityRegistry EntityRegistry { get; } = new EntityRegistry();
    public FrameworkData Data { get; }
    public InteractionMenu InteractionMenu { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        World = new WorldService(this);
        Game = new GameServices(this);
        Data = new FrameworkData(nativeFramework.GameDirectory);

        // Register and initialize plugins before building menus so plugin menus are available
        Game.PluginManager.Register(new SirenManagerPlugin());
        Game.PluginManager.Register(new VehicleSpawnerPlugin());
        Game.PluginManager.InitializeAll(this);

        InteractionMenu = new InteractionMenu(this);
    }
}
