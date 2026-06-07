namespace JaysModFramework.Core.World;

public interface IManagedVehicle : INativeVehicle, IManagedEntity
{
    VehicleCustody Custody { get; set; }
}
