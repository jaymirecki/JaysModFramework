using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed vehicle. Holds a live <see cref="INativeVehicle"/> reference
/// when spawned and a <see cref="PersistentVehicle"/> backing store at all times.
/// Property reads delegate to the live object when spawned, falling back to the
/// persistent store when unspawned.
/// </summary>
public class Vehicle : Entity, ISaveableVehicle
{
    internal INativeVehicle? NativeVehicle => Native as INativeVehicle;
    private readonly PersistentVehicle _persistent;

    public VehicleCustody Custody { get; set; }

    public Vehicle(PersistentVehicle persistent, VehicleCustody custody = VehicleCustody.MapOwned)
    {
        _persistent = persistent;
        Custody = custody;
    }

    // INativeEntity
    public override Vector3 Position => Native?.Position ?? _persistent.Position;
    public override float Heading => Native?.Heading ?? _persistent.Heading;
    public override string ModelName => Native?.ModelName ?? _persistent.ModelName;

    // INativeVehicle
    public bool HasSirens => NativeVehicle?.HasSirens ?? _persistent.HasSirens;
    public SirenState SirenState
    {
        get => NativeVehicle?.SirenState ?? _persistent.SirenState;
        set
        {
            _persistent.SirenState = value;
            if (NativeVehicle != null) NativeVehicle.SirenState = value;
        }
    }

    /// <summary>
    /// Called by <see cref="EntityRegistry"/> before despawning. Copies all
    /// engine-mutable properties from the live object to the persistent store.
    /// </summary>
    internal void SyncLiveToPersistent()
    {
        if (Native == null) return;
        _persistent.Position = Native.Position;
        _persistent.Heading = Native.Heading;
        _persistent.SirenState = SirenState;
    }

    internal void Attach(INativeVehicle native) => Native = native;

    internal void Detach()
    {
        SyncLiveToPersistent();
        Native = null;
    }
}
