using System;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using Rage;

namespace JaysModFramework.Rph.Native;

public sealed class RphNativeFramework : INativeFramework
{
    public string GameDirectory { get; } = AppDomain.CurrentDomain.BaseDirectory;
    public INativeUIService UIService { get; } = new RphUIService();
    public INativeLifecycle Lifecycle { get; } = new RphLifecycleService();
    public IGameWorld World { get; }
    public INativePlayer Player { get; }

    public RphNativeFramework()
    {
        var registry = new EntityRegistry();
        var nativePlayer = new RphPlayer(Game.LocalPlayer);
        Player = nativePlayer;
        World = new RphGameWorld(registry, nativePlayer);
    }
}
