using System;
using System.Collections.Generic;

namespace JaysModFramework.Core.World;

/// <summary>
/// Maintains the two vehicle lookup dictionaries described in the entity system design:
/// <list type="bullet">
///   <item><see cref="VehicleRegistry"/> — all framework-registered vehicles by stable <see cref="Guid"/>.</item>
///   <item><see cref="SpawnedVehicleRegistry"/> — currently spawned vehicles (managed + ambient) by native handle.</item>
/// </list>
/// </summary>
public class EntityRegistry
{
    private readonly Dictionary<Guid, Vehicle> _vehicleRegistry = new Dictionary<Guid, Vehicle>();
    private readonly Dictionary<int, Vehicle> _spawnedVehicleRegistry = new Dictionary<int, Vehicle>();

    public void Register(Vehicle vehicle) =>
        _vehicleRegistry[vehicle.Id] = vehicle;

    public void AddToSpawnedRegistry(int handle, Vehicle vehicle) =>
        _spawnedVehicleRegistry[handle] = vehicle;

    public void RemoveFromSpawnedRegistry(int handle) =>
        _spawnedVehicleRegistry.Remove(handle);

    public bool TryGetByHandle(int handle, out Vehicle vehicle) =>
        _spawnedVehicleRegistry.TryGetValue(handle, out vehicle);

    public bool TryGetById(Guid id, out Vehicle vehicle) =>
        _vehicleRegistry.TryGetValue(id, out vehicle);
}
