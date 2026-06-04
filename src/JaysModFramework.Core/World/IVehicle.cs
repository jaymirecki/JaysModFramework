using System;

namespace JaysModFramework.Core.World;

public interface IVehicle : IEquatable<IVehicle>
{
    bool HasSirens { get; }
    SirenState SirenState { get; set; }
}
