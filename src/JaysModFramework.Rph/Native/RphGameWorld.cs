using JaysModFramework.Core.World;
using Rage;
using CorePlayer = JaysModFramework.Core.World.Player;
using CoreVehicle = JaysModFramework.Core.World.Vehicle;
using Vector3 = JaysModFramework.Core.Vector3;
using GameDateTime = JaysModFramework.Core.World.GameDateTime;
using CoreWeatherType = JaysModFramework.Core.World.WeatherType;

namespace JaysModFramework.Rph.Native;

internal sealed class RphGameWorld : IGameWorld
{
    private readonly EntityRegistry _registry;
    private readonly CorePlayer _player;

    internal RphGameWorld(EntityRegistry registry, RphPlayer nativePlayer)
    {
        _registry = registry;
        _player = new CorePlayer(() => new RphPed(Game.LocalPlayer.Character), registry, nativePlayer);
    }

    public CorePlayer Player => _player;

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

    public CoreVehicle SpawnVehicle(string modelName, Vector3 position, float heading)
    {
        var ragePosition = new Rage.Vector3(position.X, position.Y, position.Z);

        var model = new Model(modelName);
        model.LoadAndWait();

        var rageVehicle = new Rage.Vehicle(model, ragePosition, heading);
        var native = new RphVehicle(rageVehicle);

        var persistent = PersistentVehicle.From(native);
        var vehicle = new CoreVehicle(persistent, VehicleCustody.PlayerOwned);
        vehicle.Attach(native);
        _registry.Register(vehicle);
        _registry.AddToSpawnedRegistry(native.Handle, vehicle);

        return vehicle;
    }
}
