using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Core-layer world API. Sits between framework consumers and the native
/// <see cref="IGameWorld"/> implementation — consumers never see the native
/// world or raw native types directly.
/// </summary>
public class WorldService
{
    private readonly Framework _framework;
    private IGameWorld NativeWorld => _framework.NativeFramework.World;

    internal WorldService(Framework framework)
    {
        _framework = framework;
    }

    /// <summary>
    /// Sets the game weather to the specified type.
    /// </summary>
    public void SetWeather(WeatherType weather) => NativeWorld.SetWeather(weather);

    /// <summary>
    /// Sets the game time to the specified date and time.
    /// </summary>
    public void SetDateTime(GameDateTime dateTime) => NativeWorld.SetDateTime(dateTime);
}
