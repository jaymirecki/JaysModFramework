using System.Xml.Serialization;

namespace JaysModFramework.Core.World;

/// <summary>
/// Serializable backing store for a ped. For MVP scope, stores only
/// position, heading, model, health, and armor.
/// </summary>
[XmlType("Ped")]
public class PersistentPed
{
    [XmlElement("Model")]
    public string Model { get; set; } = string.Empty;

    [XmlElement("Position")]
    public Vector3 Position { get; set; }

    [XmlElement("Heading")]
    public float Heading { get; set; }

    [XmlElement("Health")]
    public int Health { get; set; }

    [XmlElement("Armor")]
    public int Armor { get; set; }
}
