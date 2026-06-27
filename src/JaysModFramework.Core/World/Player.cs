using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.World;

/// <summary>
/// Framework-managed player. Creates a <see cref="Ped"/> wrapper around the
/// native player character on each access. Constructed by <see cref="Framework"/>,
/// which already exists by the time any Core domain object needs to be built.
/// </summary>
public class Player
{
    private readonly Framework _framework;
    private readonly INativePlayer _nativePlayer;

    internal Player(Framework framework, INativePlayer nativePlayer)
    {
        _framework = framework;
        _nativePlayer = nativePlayer;
    }

    public Ped Ped => new Ped(_framework, _nativePlayer.Ped);

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
