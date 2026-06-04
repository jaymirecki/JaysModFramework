using JaysModFramework.Core.World;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphPlayer : IPlayer
{
    public IPed Ped => new RphPed(Game.LocalPlayer.Character);
}
