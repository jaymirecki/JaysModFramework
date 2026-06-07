namespace JaysModFramework.Core.World;

public interface INativePed : INativeEntity
{
    /// <summary>The vehicle the ped is currently in, or null if on foot.</summary>
    INativeVehicle? Vehicle { get; }
    public void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat);
}
