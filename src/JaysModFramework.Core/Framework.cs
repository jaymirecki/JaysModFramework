using JaysModFramework.Core.Data;
using JaysModFramework.Core.Game;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Plugins.Sirens;
using JaysModFramework.Core.Plugins.VehicleSpawner;
using JaysModFramework.Core.UI.InteractionMenu;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core;

public class Framework
{
    internal INativeFramework NativeFramework { get; }
    public GameServices Game { get; }
    public IGameWorld World => NativeFramework.World;
    public EntityRegistry EntityRegistry { get; } = new EntityRegistry();
    public FrameworkData Data { get; }
    public InteractionMenu InteractionMenu { get; }

    public Framework(INativeFramework nativeFramework)
    {
        NativeFramework = nativeFramework;
        Game = new GameServices(this);
        Data = new FrameworkData(nativeFramework.GameDirectory);

        // Register and initialize plugins before building menus so plugin menus are available
        Game.PluginManager.Register(new SirenManagerPlugin());
        Game.PluginManager.Register(new VehicleSpawnerPlugin());
        Game.PluginManager.InitializeAll(this);

        InteractionMenu = new InteractionMenu(this);
    }

    /// <summary>
    /// Spawns a vehicle, wraps the native result as a <see cref="Vehicle"/>, and
    /// registers it with the <see cref="EntityRegistry"/>. The native world layer
    /// only performs the native spawn — wrapping and registry bookkeeping (and, in
    /// future, removing entities on despawn) is the framework's responsibility.
    /// </summary>
    public Vehicle SpawnVehicle(string modelName, Vector3 position, float heading)
    {
        var native = World.SpawnVehicle(modelName, position, heading);
        var persistent = PersistentVehicle.From(native);
        var vehicle = new Vehicle(persistent, VehicleCustody.PlayerOwned);
        vehicle.Attach(native);

        EntityRegistry.Register(vehicle);
        EntityRegistry.AddToSpawnedRegistry(vehicle.Handle, vehicle);
        return vehicle;
    }
}
