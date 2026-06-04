namespace JaysModFramework.Core.World;

public interface IVehicle : IEntity
{
    bool HasSirens { get; }
    SirenState SirenState { get; set; }
}
