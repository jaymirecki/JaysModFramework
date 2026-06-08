using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using RageVehicle = Rage.Vehicle;

namespace JaysModFramework.Rph.Native;

internal sealed class RphVehicle : RphEntity, INativeVehicle
{
    private readonly RageVehicle _vehicle;

    internal RphVehicle(RageVehicle vehicle) : base(vehicle) => _vehicle = vehicle;

    internal RageVehicle NativeVehicle => _vehicle;

    public bool HasSirens => _vehicle.HasSiren;

    public SirenState SirenState
    {
        get
        {
            if (_vehicle.IsSirenOn && _vehicle.IsSirenSilent) return SirenState.LightsOnly;
            if (_vehicle.IsSirenOn && !_vehicle.IsSirenSilent) return SirenState.On;
            return SirenState.Off;
        }
        set
        {
            switch (value)
            {
                case SirenState.On:
                    _vehicle.IsSirenOn = true;
                    _vehicle.IsSirenSilent = false;
                    break;
                case SirenState.Off:
                    _vehicle.IsSirenOn = false;
                    _vehicle.IsSirenSilent = false;
                    break;
                case SirenState.LightsOnly:
                default:
                    _vehicle.IsSirenOn = true;
                    _vehicle.IsSirenSilent = true;
                    break;
            }
        }
    }

    public override bool Equals(object obj) => base.Equals(obj);
    public override int GetHashCode() => base.GetHashCode();

    public static bool operator ==(RphVehicle left, RphVehicle right)
        => left is null ? right is null : left.Equals(right);
    public static bool operator !=(RphVehicle left, RphVehicle right)
        => !(left == right);
}
