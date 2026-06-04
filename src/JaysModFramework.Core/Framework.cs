using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Plugins.Sirens;
using JaysModFramework.Core.UI.InteractionMenu;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core;

public class Framework : IFrameworkServices
{
    internal INativeFramework NativeFramework { get; }
    public GameServices Game { get; }
    public IGameWorld World => NativeFramework.World;
    public InteractionMenu InteractionMenu { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        Game = new GameServices(nativeFramework);

        // Register and initialize plugins before building menus so plugin menus are available
        Game.PluginManager.Register(new SirenManagerPlugin());
        Game.PluginManager.InitializeAll(this);

        InteractionMenu = new InteractionMenu(this);
    }
}
