using System.Xml.Serialization;

namespace JaysModFramework.Core.World.SaveLoad;

/// <summary>
/// Stores world properties: weather and datetime.
/// </summary>
[XmlRoot("WorldState")]
public class WorldState
{
    [XmlElement("WorldspaceId")]
    public string WorldspaceId { get; set; } = string.Empty;

    [XmlElement("Weather")]
    public WeatherType Weather { get; set; }

    [XmlElement("DateTime")]
    public GameDateTime DateTime { get; set; } = new();
}
