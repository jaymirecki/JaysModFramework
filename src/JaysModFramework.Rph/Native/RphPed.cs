using JaysModFramework.Core.World;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphPed : RphEntity, IPed
{
    private readonly Ped _ped;

    internal RphPed(Ped ped) : base(ped) => _ped = ped;

    public IVehicle Vehicle
    {
        get
        {
            var vehicle = _ped.CurrentVehicle;
            return vehicle != null && vehicle.Exists() ? new RphVehicle(vehicle) : null;
        }
    }
}
