using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Game.Settings;
using JaysModFramework.Core.Plugins;
using JaysModFramework.Core.UI;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Game;

public class GameServices
{
    internal INativeFramework NativeFramework { get; }
    public FrameworkConfig Settings { get; }
    public Logger Logger { get; }
    public MenuService MenuService { get; }
    public INativeLifecycle Lifecycle { get; }
    public PluginManager PluginManager { get; }
    public Player Player { get; }

    internal GameServices(Framework framework)
    {
        NativeFramework = framework.NativeFramework;
        var configPath = Path.Combine(NativeFramework.GameDirectory, "JMF", "config.xml");
        Settings = FrameworkConfig.Load(configPath);
        Logger = new Logger(this);
        MenuService = new MenuService(NativeFramework.UIService);
        Lifecycle = NativeFramework.Lifecycle;
        PluginManager = new PluginManager();
        Player = new Player(framework, NativeFramework.Game.Player);
        Logger.Info($"Settings loaded from {configPath}");
    }
}
