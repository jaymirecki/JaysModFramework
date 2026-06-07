using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using RagePed = Rage.Ped;

namespace JaysModFramework.Rph.Native;

internal sealed class RphPed : RphEntity, INativePed
{
    private readonly RagePed _ped;

    internal RphPed(RagePed ped) : base(ped) => _ped = ped;

    public INativeVehicle? Vehicle
    {
        get
        {
            var vehicle = _ped.CurrentVehicle;
            return vehicle != null && vehicle.Exists() ? new RphVehicle(vehicle) : null;
        }
    }

    public void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat)
    {
        if (vehicle is RphVehicle rph)
            _ped.WarpIntoVehicle(rph.NativeVehicle, (int)seat);
    }
}
