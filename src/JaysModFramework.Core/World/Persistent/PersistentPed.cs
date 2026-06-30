using System.Xml.Serialization;

namespace JaysModFramework.Core.World;

/// <summary>
/// Serializable backing store for a ped. For MVP scope, stores only
/// position, heading, model, health, and armor.
/// </summary>
[XmlType("Ped")]
public class PersistentPed: PersistentEntity
{
    [XmlElement("Armor")]
    public int Armor { get; set; }

    [XmlElement("CurrentVehicleId")]
    public string CurrentVehicleId { get; set; }
}
