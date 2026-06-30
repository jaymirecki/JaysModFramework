using System.Xml.Serialization;

namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Stores the player ped's state (position, heading, model, health, armor).
/// </summary>
[XmlRoot("PlayerState")]
public class PlayerState
{
    [XmlElement("Ped")]
    public PersistentPed Ped { get; set; } = new();
}
