using System;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed player. Creates a <see cref="Ped"/> wrapper around the
/// native player character on each access, backed by a stable <see cref="EntityRegistry"/>
/// for vehicle lookup.
/// </summary>
public class Player : IPlayer
{
    private readonly Func<INativePed> _pedFactory;
    private readonly EntityRegistry _registry;

    public Player(Func<INativePed> pedFactory, EntityRegistry registry)
    {
        _pedFactory = pedFactory;
        _registry = registry;
    }

    public Ped Ped => new Ped(_pedFactory(), _registry);
}
