namespace JaysModFramework.Core.World;

public enum VehicleCustody
{
    /// <summary>Spawned by map; player has not interacted with it.</summary>
    MapOwned,
    /// <summary>Player has driven it away; framework will not despawn it.</summary>
    PlayerCustody,
    /// <summary>Player has explicitly claimed it; persists across sessions.</summary>
    PlayerOwned,
}
