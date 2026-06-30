using System;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;

namespace JaysModFramework.Rph.Native;

public sealed class RphNativeFramework : INativeFramework
{
    public string GameDirectory { get; } = AppDomain.CurrentDomain.BaseDirectory;
    public INativeUIService UIService { get; } = new RphUIService();
    public INativeLifecycle Lifecycle { get; } = new RphLifecycleService();
    public IGameWorld World { get; } = new RphGameWorld();
    public INativeGame Game { get; } = new RphGame();
}
