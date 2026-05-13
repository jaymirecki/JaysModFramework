using System;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Rph.Native;

public sealed class RphNativeFramework : INativeFramework
{
    public string GameDirectory { get; } = AppDomain.CurrentDomain.BaseDirectory;
    public INativeUIService UIService { get; } = new RphUIService();
}
