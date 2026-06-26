using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Native;

public interface INativePed : INativeEntity
{
    /// <summary>The vehicle the ped is currently in, or null if on foot.</summary>
    INativeVehicle? Vehicle { get; }

    /// <summary>Gets or sets the ped's health.</summary>
    int Health { get; set; }

    /// <summary>Gets or sets the ped's armor.</summary>
    int Armor { get; set; }

    void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat);
}
