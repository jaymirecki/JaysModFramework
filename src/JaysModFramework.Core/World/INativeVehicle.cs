namespace JaysModFramework.Core.World;

public interface INativeVehicle : INativeEntity
{
    bool HasSirens { get; }
    SirenState SirenState { get; set; }
}
