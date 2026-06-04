using JaysModFramework.Core.World;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphGameWorld : IGameWorld
{
    public IVehicle GetPlayerVehicle()
    {
        var vehicle = Game.LocalPlayer.Character.CurrentVehicle;
        return vehicle != null && vehicle.Exists() ? new RphVehicle(vehicle) : null;
    }
}
