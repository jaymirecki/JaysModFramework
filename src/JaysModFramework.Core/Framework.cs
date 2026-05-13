using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core;

public class Framework
{
    internal INativeFramework NativeFramework { get; }
    public GameServices Game { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        Game = new GameServices(nativeFramework);
    }
}
