namespace JaysModFramework.Core.World;

public interface IGameWorld
{
    Player Player { get; }

    /// <summary>
    /// Sets the game weather to the specified type.
    /// </summary>
    void SetWeather(WeatherType weather);

    /// <summary>
    /// Sets the game time to the specified date and time.
    /// </summary>
    void SetDateTime(GameDateTime dateTime);

    /// <summary>
    /// Loads the model, spawns the vehicle at the given position and heading,
    /// registers it with <see cref="VehicleCustody.PlayerOwned"/> custody,
    /// and returns the managed vehicle. Blocks the current game fiber while the
    /// model loads.
    /// </summary>
    Vehicle SpawnVehicle(string modelName, Vector3 position, float heading);
}
