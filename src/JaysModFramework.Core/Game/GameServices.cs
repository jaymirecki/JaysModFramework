using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Game.Settings;

namespace JaysModFramework.Core.Game;

public class GameServices
{
    internal INativeFramework NativeFramework { get; }
    public FrameworkConfig Settings { get; }
    public Logger Logger { get; }

    internal GameServices(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        var configPath = Path.Combine(nativeFramework.GameDirectory, "JMF", "config.xml");
        Settings = FrameworkConfig.Load(configPath);
        Logger = new Logger(this);
        Logger.Info($"Settings loaded from {configPath}");
    }
}
