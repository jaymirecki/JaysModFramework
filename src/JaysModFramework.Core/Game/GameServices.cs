using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Game.Settings;
using JaysModFramework.Core.Plugins;
using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Game;

public class GameServices
{
    internal INativeFramework NativeFramework { get; }
    public FrameworkConfig Settings { get; }
    public Logger Logger { get; }
    public MenuService MenuService { get; }
    public INativeLifecycle Lifecycle { get; }
    public PluginManager PluginManager { get; }

    internal GameServices(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        var configPath = Path.Combine(nativeFramework.GameDirectory, "JMF", "config.xml");
        Settings = FrameworkConfig.Load(configPath);
        Logger = new Logger(this);
        MenuService = new MenuService(nativeFramework.UIService);
        Lifecycle = nativeFramework.Lifecycle;
        PluginManager = new PluginManager();
        Logger.Info($"Settings loaded from {configPath}");
    }
}
