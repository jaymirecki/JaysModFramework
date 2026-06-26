using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Native;

/// <summary>
/// Top-level interface for the Native layer. Framework receives this via constructor
/// injection; all RPH/GTA calls flow through it. FakeNativeFramework is used in tests.
/// </summary>
public interface INativeFramework
{
    /// <summary>Absolute path to the GTA V root directory.</summary>
    string GameDirectory { get; }
    INativeUIService UIService { get; }
    INativeLifecycle Lifecycle { get; }
    IGameWorld World { get; }
    INativePlayer Player { get; }
}
