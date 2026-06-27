using JaysModFramework.Core.UI;
using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Plugins.VehicleSpawner;

public class VehicleSpawnerPlugin : MenuPlugin
{
    public override string Name => "Vehicle Spawner";

    public VehicleSpawnerPlugin()
    {
        MenuTitle = "Vehicle Spawner";
    }

    public override void Initialize(Framework services)
    {
        var menuService = services.Game.MenuService;
        var vehicleModels = services.Data.Models.Vehicles;

        foreach (var vehicleClass in vehicleModels.Classes)
        {
            var classMenu = new Menu { BannerText = "JMF", Title = vehicleClass };

            foreach (var model in vehicleModels.GetByClass(vehicleClass))
            {
                var item = new MenuItem
                {
                    Title = model.Name,
                    Description = $"Spawn a {model.Name} ({model.ModelName}).",
                };

                var modelName = model.ModelName; // capture for closure
                item.OnActivated += () =>
                {
                    menuService.HideMenu();
                    var ped = services.Game.Player.Ped;
                    var vehicle = new Vehicle(services, modelName, ped.Position, ped.Heading, VehicleCustody.PlayerOwned);
                    vehicle.Spawn();
                    ped.WarpIntoVehicle(vehicle, VehicleSeat.Driver);
                };

                classMenu.Add(item);
            }

            Menu.AddSubmenu(classMenu);
        }
    }

    public override void Shutdown() { }
}
