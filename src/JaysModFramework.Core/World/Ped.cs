namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed ped. Wraps an <see cref="INativePed"/> and provides
/// registry-backed vehicle lookup so <see cref="Vehicle"/> returns the concrete
/// <see cref="World.Vehicle"/> rather than a raw native wrapper.
/// </summary>
public class Ped : Entity, IManagedPed
{
    private readonly INativePed _nativePed;
    private readonly EntityRegistry _registry;

    public Ped(INativePed nativePed, EntityRegistry registry)
    {
        _nativePed = nativePed;
        Native = nativePed;
        _registry = registry;
    }

    // INativeEntity — always delegate to live native (player ped is always spawned)
    public override Vector3 Position => _nativePed.Position;
    public override float Heading => _nativePed.Heading;
    public override string ModelName => _nativePed.ModelName;

    /// <summary>
    /// The vehicle the ped is currently in, or null if on foot.
    /// Performs a registry lookup so ambient vehicles are wrapped and registered on first encounter.
    /// </summary>
    public Vehicle? Vehicle
    {
        get
        {
            var native = _nativePed.Vehicle;
            if (native == null) return null;

            // Return the existing managed vehicle if already registered.
            if (_registry.TryGetByHandle(native.Handle, out var managed))
                return managed;

            // Ambient vehicle encountered for the first time — snapshot and register.
            var persistent = PersistentVehicle.From(native);
            var vehicle = new Vehicle(persistent, VehicleCustody.MapOwned);
            vehicle.Attach(native);
            _registry.Register(vehicle);
            _registry.AddToSpawnedRegistry(native.Handle, vehicle);
            return vehicle;
        }
    }

    // Explicit implementations satisfy base interfaces for callers holding IManagedPed or INativePed.
    IManagedVehicle? IManagedPed.Vehicle => Vehicle;
    INativeVehicle? INativePed.Vehicle => Vehicle;

    public void WarpIntoVehicle(Vehicle vehicle, VehicleSeat seat) {
        if (!vehicle.IsSpawned) return;
        _nativePed.WarpIntoVehicle(vehicle.NativeVehicle, seat);
    }

    public void WarpIntoVehicle(INativeVehicle vehicle, VehicleSeat seat) {
        _nativePed.WarpIntoVehicle(vehicle, seat);
    }
}
