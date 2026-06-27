using JaysModFramework.Core.Native;
using JaysModFramework.Core.World;
using Rage;
using Vector3 = JaysModFramework.Core.Vector3;
using GameDateTime = JaysModFramework.Core.World.GameDateTime;
using CoreWeatherType = JaysModFramework.Core.World.WeatherType;

namespace JaysModFramework.Rph.Native;

/// <summary>
/// Native-only world implementation. Deals exclusively in INative* types — wrapping
/// results into Core domain objects (Player, Vehicle) and any registry bookkeeping
/// is the JMF Framework's responsibility, not this class's.
/// </summary>
internal sealed class RphGameWorld : IGameWorld
{
    public void SetWeather(CoreWeatherType weather)
    {
        var rageWeather = weather switch
        {
            CoreWeatherType.Clear => Rage.WeatherType.Clear,
            CoreWeatherType.Clouds => Rage.WeatherType.Clouds,
            CoreWeatherType.Rain => Rage.WeatherType.Rain,
            CoreWeatherType.Foggy => Rage.WeatherType.Foggy,
            CoreWeatherType.Overcast => Rage.WeatherType.Overcast,
            _ => Rage.WeatherType.Clear,
        };

        World.Weather = rageWeather;
    }

    public void SetDateTime(GameDateTime dateTime)
    {
        var dateTimeValue = new System.DateTime(dateTime.Year, dateTime.Month, dateTime.Day,
                                               dateTime.Hour, dateTime.Minute, 0);
        World.DateTime = dateTimeValue;
    }

    public INativeVehicle SpawnVehicle(string modelName, Vector3 position, float heading)
    {
        var ragePosition = new Rage.Vector3(position.X, position.Y, position.Z);

        var model = new Model(modelName);
        model.LoadAndWait();

        var rageVehicle = new Rage.Vehicle(model, ragePosition, heading);
        return new RphVehicle(rageVehicle);
    }
}
