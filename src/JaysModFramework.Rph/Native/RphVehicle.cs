using JaysModFramework.Core.World;
using Rage;

namespace JaysModFramework.Rph.Native;

internal sealed class RphVehicle : IVehicle
{
    private readonly Vehicle _vehicle;

    internal RphVehicle(Vehicle vehicle) => _vehicle = vehicle;

    public bool HasSirens => _vehicle.HasSiren;

    public bool Equals(IVehicle other) => other is RphVehicle rph && _vehicle == rph._vehicle;
    public override bool Equals(object obj) => obj is IVehicle v && Equals(v);
    public override int GetHashCode() => _vehicle.GetHashCode();

    public static bool operator ==(RphVehicle left, RphVehicle right)
        => left is null ? right is null : left.Equals(right);
    public static bool operator !=(RphVehicle left, RphVehicle right)
        => !(left == right);

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
}
