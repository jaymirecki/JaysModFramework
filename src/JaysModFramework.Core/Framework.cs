using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Settings;

namespace JaysModFramework.Core;

public class Framework
{
    internal INativeFramework NativeFramework { get; }
    public FrameworkConfig Settings { get; }
    public Logger Logger { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        var configPath = Path.Combine(nativeFramework.GameDirectory, "JMF", "config.xml");
        Settings = FrameworkConfig.Load(configPath);
        Logger = new Logger(this);
        Logger.Info($"Settings loaded from {configPath}");
    }
}
