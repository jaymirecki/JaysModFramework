using System;
using System.IO;
using System.Xml.Serialization;

namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Handles serialization and deserialization of PlayerState to/from XML.
/// </summary>
internal class PlayerStateSerializer
{
    private static readonly XmlSerializer Serializer = new(typeof(PlayerState));

    /// <summary>
    /// Deserializes PlayerState from player.xml at the given path.
    /// </summary>
    public PlayerState Deserialize(string savePath)
    {
        var playerXmlPath = Path.Combine(savePath, "player.xml");

        if (!File.Exists(playerXmlPath))
            throw new FileNotFoundException($"player.xml not found at {playerXmlPath}");

        using var stream = File.OpenRead(playerXmlPath);
        var playerState = (PlayerState?)Serializer.Deserialize(stream);

        return playerState ?? throw new InvalidOperationException("Failed to deserialize player.xml");
    }

    /// <summary>
    /// Serializes PlayerState to player.xml at the given path.
    /// </summary>
    public void Serialize(string savePath, PlayerState playerState)
    {
        Directory.CreateDirectory(savePath);
        var playerXmlPath = Path.Combine(savePath, "player.xml");

        using var stream = File.Create(playerXmlPath);
        Serializer.Serialize(stream, playerState);
    }
}
