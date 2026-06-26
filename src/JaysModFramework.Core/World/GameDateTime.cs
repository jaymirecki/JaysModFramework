using System.Xml.Serialization;

namespace JaysModFramework.Core.World;

[XmlType("GameDateTime")]
public class GameDateTime
{
    [XmlElement("Hour")]
    public int Hour { get; set; }

    [XmlElement("Minute")]
    public int Minute { get; set; }

    [XmlElement("Day")]
    public int Day { get; set; }

    [XmlElement("Month")]
    public int Month { get; set; }

    [XmlElement("Year")]
    public int Year { get; set; }

    public override string ToString() => $"{Day:D2}/{Month:D2}/{Year} {Hour:D2}:{Minute:D2}";
}
