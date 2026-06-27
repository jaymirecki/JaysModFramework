using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Native-facing world API. Implemented by the native layer (e.g. RphGameWorld) and
/// deals only in INative* types — it has no knowledge of Core domain objects like
/// <see cref="Player"/> or <see cref="Vehicle"/>. Wrapping native results into domain
/// objects and registering them is the <see cref="Framework"/>'s responsibility.
/// </summary>
public interface IGameWorld
{
    /// <summary>
    /// Sets the game weather to the specified type.
    /// </summary>
    void SetWeather(WeatherType weather);

    /// <summary>
    /// Sets the game time to the specified date and time.
    /// </summary>
    void SetDateTime(GameDateTime dateTime);

    /// <summary>
    /// Loads the model and spawns the vehicle at the given position and heading.
    /// Returns the raw native vehicle — wrapping it as a <see cref="Vehicle"/> and
    /// registering it is done by <see cref="Framework.SpawnVehicle"/>. Blocks the
    /// current game fiber while the model loads.
    /// </summary>
    INativeVehicle SpawnVehicle(string modelName, Vector3 position, float heading);
}
