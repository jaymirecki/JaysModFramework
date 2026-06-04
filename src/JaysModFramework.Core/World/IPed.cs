namespace JaysModFramework.Core.World;

public interface IPed : IEntity
{
    /// <summary>The vehicle the ped is currently in, or null if on foot.</summary>
    IVehicle Vehicle { get; }
}
