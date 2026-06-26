using System;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed player. Creates a <see cref="Ped"/> wrapper around the
/// native player character on each access, backed by a stable <see cref="EntityRegistry"/>
/// for vehicle lookup.
/// </summary>
public class Player
{
    private readonly Func<INativePed> _pedFactory;
    private readonly EntityRegistry _registry;
    private readonly INativePlayer _nativePlayer;

    internal Player(Func<INativePed> pedFactory, EntityRegistry registry, INativePlayer nativePlayer)
    {
        _pedFactory = pedFactory;
        _registry = registry;
        _nativePlayer = nativePlayer;
    }

    public Ped Ped => new Ped(_pedFactory(), _registry);

    /// <summary>
    /// Gets the player's model.
    /// </summary>
    public string Model => _nativePlayer.Model;

    /// <summary>
    /// Sets the player's model. This replaces the underlying native character
    /// and should be done before setting other properties like position and heading.
    /// </summary>
    public void SetModel(string modelName) => _nativePlayer.SetModel(modelName);
}
