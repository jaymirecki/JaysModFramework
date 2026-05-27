using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.UI.InteractionMenu;

namespace JaysModFramework.Core;

public class Framework
{
    internal INativeFramework NativeFramework { get; }
    public GameServices Game { get; }
    public InteractionMenu InteractionMenu { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        Game = new GameServices(nativeFramework);
        InteractionMenu = new InteractionMenu(this);
    }
}
