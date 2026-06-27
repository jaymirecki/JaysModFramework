using JaysModFramework.Core.Native;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphGame : INativeGame
{
    public INativePlayer Player { get; } = new RphPlayer(Game.LocalPlayer);
}
