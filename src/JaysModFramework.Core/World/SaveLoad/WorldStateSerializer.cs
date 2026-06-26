using System;
using System.IO;
using System.Xml.Serialization;

namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Handles serialization and deserialization of WorldState to/from XML.
/// </summary>
internal class WorldStateSerializer
{
    private static readonly XmlSerializer Serializer = new(typeof(WorldState));

    /// <summary>
    /// Deserializes WorldState from world.xml at the given path.
    /// </summary>
    public WorldState Deserialize(string savePath)
    {
        var worldXmlPath = Path.Combine(savePath, "world.xml");

        if (!File.Exists(worldXmlPath))
            throw new FileNotFoundException($"world.xml not found at {worldXmlPath}");

        using var stream = File.OpenRead(worldXmlPath);
        var worldState = (WorldState?)Serializer.Deserialize(stream);

        return worldState ?? throw new InvalidOperationException("Failed to deserialize world.xml");
    }

    /// <summary>
    /// Serializes WorldState to world.xml at the given path.
    /// </summary>
    public void Serialize(string savePath, WorldState worldState)
    {
        Directory.CreateDirectory(savePath);
        var worldXmlPath = Path.Combine(savePath, "world.xml");

        using var stream = File.Create(worldXmlPath);
        Serializer.Serialize(stream, worldState);
    }
}
