using JaysModFramework.Core.World;

namespace JaysModFramework.Core.Native;

public interface INativeVehicle : INativeEntity
{
    bool HasSirens { get; }
    SirenState SirenState { get; set; }
}
