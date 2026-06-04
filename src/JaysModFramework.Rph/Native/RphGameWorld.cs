using JaysModFramework.Core.World;

namespace JaysModFramework.Rph.Native;

internal sealed class RphGameWorld : IGameWorld
{
    public IPlayer Player => new RphPlayer();
}
