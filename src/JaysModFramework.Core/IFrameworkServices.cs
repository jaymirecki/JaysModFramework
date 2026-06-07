using JaysModFramework.Core.Data;
using JaysModFramework.Core.Game;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core;

/// <summary>The service handle passed to each plugin during initialization.</summary>
public interface IFrameworkServices
{
    GameServices Game { get; }
    IGameWorld World { get; }
    FrameworkData Data { get; }
}
