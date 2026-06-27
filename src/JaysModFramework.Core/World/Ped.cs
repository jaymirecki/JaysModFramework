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
    private PersistentPed PersistentPed => (PersistentPed)Persistent!;
    private readonly Framework _framework;
    private readonly bool IsPlayerPed;

    public Ped(Framework framework): this(framework, new PersistentPed()) {}

    internal Ped(Framework framework, PersistentPed persistent) {
        _framework = framework;
        Persistent = persistent;
        _framework.EntityRegistry.Register(this);
        IsPlayerPed = false;
    }

    /// <summary>
    /// Carve-out for the player ped, which should never be added to the
    /// <see cref="EntityRegistry"/> — the framework does not manage the player
    /// like it manages NPC peds.
    /// </summary>
    internal Ped(Framework framework, INativePed nativePed)
    {
        _framework = framework;
        IsPlayerPed = true;
        Native = nativePed;
    }

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
    public Vehicle? CurrentVehicle
    {
        get
        {
            Vehicle managed;
            if (NativePed != null) {
                if (NativePed.CurrentVehicle == null) return null;
                if (_framework.EntityRegistry.TryGetByHandle(NativePed.CurrentVehicle.Handle, out managed))
                    return managed;
                return null;
            }
            
            if (_framework.EntityRegistry.TryGetById(PersistentPed.CurrentVehicleId, out managed))
                return managed;
            return null;
        }
    }

    public void WarpIntoVehicle(Vehicle vehicle, VehicleSeat seat)
    {
        if (vehicle?.NativeVehicle != null)
            NativePed?.WarpIntoVehicle(vehicle.NativeVehicle, seat);
    }
}
