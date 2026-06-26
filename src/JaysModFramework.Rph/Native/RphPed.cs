using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using RagePed = Rage.Ped;
using Vector3 = JaysModFramework.Core.Vector3;

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

    public int Health
    {
        get => _ped.Health;
        set
        {
            if (_ped.Exists())
                _ped.Health = value;
        }
    }

    public int Armor
    {
        get => _ped.Armor;
        set
        {
            if (_ped.Exists())
                _ped.Armor = value;
        }
    }

    public new Vector3 Position
    {
        get => new Vector3(_ped.Position.X, _ped.Position.Y, _ped.Position.Z);
        set
        {
            if (_ped.Exists())
                _ped.Position = new Rage.Vector3(value.X, value.Y, value.Z);
        }
    }

    public new float Heading
    {
        get => _ped.Heading;
        set
        {
            if (_ped.Exists())
                _ped.Heading = value;
        }
    }

    public void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat)
    {
        if (vehicle is RphVehicle rph)
            _ped.WarpIntoVehicle(rph.NativeVehicle, (int)seat);
    }
}
