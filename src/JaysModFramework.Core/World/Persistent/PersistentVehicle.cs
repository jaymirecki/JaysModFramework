using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Serializable backing store for a vehicle. Extends <see cref="PersistentEntity"/>
/// with vehicle-specific properties. Created from an <see cref="INativeVehicle"/>
/// snapshot on first encounter and updated via <c>SyncLiveToPersistent()</c>
/// before despawn.
/// </summary>
internal class PersistentVehicle : PersistentEntity, ISaveableVehicle
{
    public bool HasSirens { get; set; }
    public SirenState SirenState { get; set; } = SirenState.Off;

    public static PersistentVehicle From(INativeVehicle vehicle) => new PersistentVehicle
    {
        Position = vehicle.Position,
        Heading = vehicle.Heading,
        ModelName = vehicle.ModelName,
        HasSirens = vehicle.HasSirens,
        SirenState = vehicle.SirenState,
    };
}
