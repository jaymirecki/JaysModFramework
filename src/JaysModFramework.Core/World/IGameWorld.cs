namespace JaysModFramework.Core.World;

public interface IGameWorld
{
    /// <summary>Returns the vehicle the local player is currently driving, or null if on foot.</summary>
    IVehicle GetPlayerVehicle();
}
