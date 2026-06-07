namespace JaysModFramework.Core.World;

/// <summary>
/// A framework-managed vehicle. Superset of <see cref="INativeVehicle"/> — carries all
/// the same properties plus managed identity, spawn state, and custody. Does not extend
/// <see cref="INativeVehicle"/> so that the native and managed interface hierarchies remain
/// independent.
/// </summary>
public interface IManagedVehicle : IManagedEntity
{
    // Mirror of INativeVehicle properties.
    bool HasSirens { get; }
    SirenState SirenState { get; set; }

    VehicleCustody Custody { get; set; }
}
