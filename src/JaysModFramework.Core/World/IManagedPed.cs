namespace JaysModFramework.Core.World;

public interface IManagedPed : INativePed, IManagedEntity
{
    /// <summary>
    /// The managed vehicle the ped is currently in, or null if on foot.
    /// Hides <see cref="INativePed.Vehicle"/> to return the richer managed type.
    /// </summary>
    new IManagedVehicle? Vehicle { get; }
}
