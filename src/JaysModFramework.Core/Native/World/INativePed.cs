using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Native;

internal interface INativePed : INativeEntity
{
    /// <summary>The vehicle the ped is currently in, or null if on foot.</summary>
    INativeVehicle? Vehicle { get; }
    void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat);
}
