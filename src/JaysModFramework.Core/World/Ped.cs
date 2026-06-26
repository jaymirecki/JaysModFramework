using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed ped. Wraps an <see cref="INativePed"/> and provides
/// registry-backed vehicle lookup so <see cref="Vehicle"/> returns the concrete
/// <see cref="World.Vehicle"/> rather than a raw native wrapper.
/// </summary>
public class Ped : Entity
{
    private INativePed? NativePed => Native as INativePed;
    private readonly EntityRegistry _registry;

    internal Ped(INativePed nativePed, EntityRegistry registry)
    {
        Native = nativePed;
        _registry = registry;
    }

    public override string ModelName => NativePed?.ModelName ?? string.Empty;

    public int Armor
    {
        get => NativePed?.Armor ?? default;
        set
        {
            if (NativePed != null)
                NativePed.Armor = value;
        }
    }

    /// <summary>
    /// The vehicle the ped is currently in, or null if on foot.
    /// Performs a registry lookup so ambient vehicles are wrapped and registered on first encounter.
    /// </summary>
    public Vehicle? Vehicle
    {
        get
        {
            var native = NativePed?.Vehicle;
            if (native == null) return null;

            if (_registry.TryGetByHandle(native.Handle, out var managed))
                return managed;

            var persistent = PersistentVehicle.From(native);
            var vehicle = new Vehicle(persistent, VehicleCustody.MapOwned);
            vehicle.Attach(native);
            _registry.Register(vehicle);
            _registry.AddToSpawnedRegistry(native.Handle, vehicle);
            return vehicle;
        }
    }

    public void WarpIntoVehicle(Vehicle vehicle, VehicleSeat seat)
    {
        if (vehicle?.NativeVehicle != null)
            NativePed?.WarpIntoVehicle(vehicle.NativeVehicle, seat);
    }
}
