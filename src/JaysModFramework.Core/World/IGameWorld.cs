namespace JaysModFramework.Core.World;

public interface IGameWorld
{
    IPlayer Player { get; }

    /// <summary>
    /// Loads the model, spawns the vehicle at the given position and heading,
    /// registers it with <see cref="VehicleCustody.PlayerOwned"/> custody,
    /// and returns the managed vehicle. Blocks the current game fiber while the
    /// model loads.
    /// </summary>
    Vehicle SpawnVehicle(string modelName, Vector3 position, float heading);
}
