using JaysModFramework.Core.Models;

namespace JaysModFramework.Core.Data;

public class ModelData
{
    public VehicleModelRepository Vehicles { get; }

    public ModelData(string gameDirectory)
    {
        Vehicles = new VehicleModelRepository(gameDirectory);
    }
}
