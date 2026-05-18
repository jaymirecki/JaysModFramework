using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Game.Settings;
using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Game;

public class GameServices
{
    internal INativeFramework NativeFramework { get; }
    public FrameworkConfig Settings { get; }
    public Logger Logger { get; }
    public MenuService MenuService { get; }

    internal GameServices(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        var configPath = Path.Combine(nativeFramework.GameDirectory, "JMF", "config.xml");
        Settings = FrameworkConfig.Load(configPath);
        Logger = new Logger(this);
        MenuService = new MenuService(nativeFramework.UIService);
        Logger.Info($"Settings loaded from {configPath}");
    }
}
