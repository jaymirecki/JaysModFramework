using System;
using System.Collections.Generic;

namespace JaysModFramework.Core.World;

/// <summary>
/// Maintains lookup dictionaries for each entity type the framework tracks
/// (vehicles, peds), described in the entity system design:
/// <list type="bullet">
///   <item>Per-type "registry" — all framework-registered entities of that type, by stable <see cref="Guid"/>.</item>
///   <item>Per-type "spawned registry" — currently spawned entities of that type (managed + ambient), by native handle.</item>
/// </list>
/// </summary>
public class EntityRegistry
{
    private readonly Dictionary<string, Vehicle> _vehicleRegistry = new Dictionary<string, Vehicle>();
    private readonly Dictionary<int, Vehicle> _spawnedVehicleRegistry = new Dictionary<int, Vehicle>();

    private readonly Dictionary<string, Ped> _pedRegistry = new Dictionary<string, Ped>();
    private readonly Dictionary<int, Ped> _spawnedPedRegistry = new Dictionary<int, Ped>();

    public void Register(Vehicle vehicle) =>
        _vehicleRegistry[vehicle.Id] = vehicle;

    public void AddToSpawnedRegistry(int handle, Vehicle vehicle) =>
        _spawnedVehicleRegistry[handle] = vehicle;

    public bool TryGetByHandle(int handle, out Vehicle vehicle) =>
        _spawnedVehicleRegistry.TryGetValue(handle, out vehicle);

    public bool TryGetById(string id, out Vehicle vehicle) =>
        _vehicleRegistry.TryGetValue(id, out vehicle);

    public void Register(Ped ped) =>
        _pedRegistry[ped.Id] = ped;

    public void AddToSpawnedRegistry(int handle, Ped ped) =>
        _spawnedPedRegistry[handle] = ped;

    public bool TryGetByHandle(int handle, out Ped ped) =>
        _spawnedPedRegistry.TryGetValue(handle, out ped);

    public bool TryGetById(string id, out Ped ped) =>
        _pedRegistry.TryGetValue(id, out ped);

    /// <summary>
    /// Removes a spawned entity by native handle, regardless of entity type.
    /// Native handles are unique across entity types, so it is safe to try
    /// every spawned-entity dictionary.
    /// </summary>
    public void RemoveFromSpawnedRegistry(int handle)
    {
        _spawnedVehicleRegistry.Remove(handle);
        _spawnedPedRegistry.Remove(handle);
    }
}
