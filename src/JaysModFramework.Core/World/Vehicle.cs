using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed vehicle. Holds a live <see cref="INativeVehicle"/> reference
/// when spawned and a <see cref="PersistentVehicle"/> backing store at all times,
/// assigned to the base <see cref="Entity.Persistent"/> field so Position/Heading/
/// ModelName fall back to it when unspawned. Owns spawning itself — construct a
/// <see cref="Vehicle"/> and call <see cref="Spawn"/> to create the native vehicle
/// via the framework's world.
/// </summary>
public class Vehicle : Entity, ISaveableVehicle
{
    internal INativeVehicle? NativeVehicle => Native as INativeVehicle;
    private readonly Framework _framework;
    private PersistentVehicle PersistentVehicle => (PersistentVehicle)Persistent!;

    public VehicleCustody Custody { get; set; }

    /// <summary>
    /// Creates a new, unspawned vehicle. Call <see cref="Spawn"/> to create the
    /// native vehicle at this vehicle's <see cref="Position"/> and <see cref="Heading"/>.
    /// </summary>
    public Vehicle(Framework framework, string modelName, Vector3 position, float heading,
        VehicleCustody custody = VehicleCustody.MapOwned)
        : this(framework, new PersistentVehicle { ModelName = modelName, Position = position, Heading = heading }, custody)
    {
    }

    /// <summary>
    /// Wraps an existing persistent snapshot (e.g. an ambient vehicle encountered in the
    /// world, or a vehicle deserialized from a save file). Use <see cref="AttachNative"/>
    /// rather than <see cref="Spawn"/> when the native vehicle already exists.
    /// </summary>
    internal Vehicle(Framework framework, PersistentVehicle persistent, VehicleCustody custody = VehicleCustody.MapOwned)
    {
        _framework = framework;
        Persistent = persistent;
        Custody = custody;

        _framework.EntityRegistry.Register(this);
    }

    // INativeVehicle
    public bool HasSirens => NativeVehicle?.HasSirens ?? PersistentVehicle.HasSirens;
    public SirenState SirenState
    {
        get => NativeVehicle?.SirenState ?? PersistentVehicle.SirenState;
        set
        {
            PersistentVehicle.SirenState = value;
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
        PersistentVehicle.Position = Native.Position;
        PersistentVehicle.Heading = Native.Heading;
        PersistentVehicle.SirenState = SirenState;
    }

    /// <summary>
    /// Creates the native vehicle (via the native framework's world) at this vehicle's
    /// current <see cref="Position"/> and <see cref="Heading"/>, and adds it to the
    /// <see cref="EntityRegistry"/>'s spawned-vehicle lookup by native handle.
    /// No-op if already spawned.
    /// </summary>
    public void Spawn()
    {
        if (Native != null) return;

        Native = _framework.NativeFramework.World.SpawnVehicle(ModelName, Position, Heading);
        _framework.EntityRegistry.AddToSpawnedRegistry(NativeVehicle.Handle, this);
    }

    /// <summary>
    /// Syncs live state to the persistent backing store, detaches the native vehicle,
    /// and removes it from the <see cref="EntityRegistry"/>'s spawned-vehicle lookup.
    /// The vehicle remains registered by Guid.
    /// </summary>
    internal void Remove()
    {
        if (Native == null) return;

        SyncLiveToPersistent();
        _framework.EntityRegistry.RemoveFromSpawnedRegistry(Native.Handle);
        Native = null;
    }
}
