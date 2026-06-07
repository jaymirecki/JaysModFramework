namespace JaysModFramework.Core.World;

/// <summary>
/// A framework-managed ped. Superset of <see cref="INativePed"/> — carries all the same
/// observable properties and actions but operates in terms of managed types rather than
/// native wrappers. Does not extend <see cref="INativePed"/>.
/// </summary>
public interface IManagedPed : IManagedEntity
{
    /// <summary>The managed vehicle the ped is currently in, or null if on foot.</summary>
    Vehicle? Vehicle { get; }
    void WarpIntoVehicle(IManagedVehicle vehicle, VehicleSeat seat);
}
