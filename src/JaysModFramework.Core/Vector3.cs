using System.Xml.Serialization;

namespace JaysModFramework.Core;

public struct Vector3
{
    [XmlElement("X")]
    public float X { get; set; }

    [XmlElement("Y")]
    public float Y { get; set; }

    [XmlElement("Z")]
    public float Z { get; set; }

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public bool Equals(Vector3 other) => X == other.X && Y == other.Y && Z == other.Z;
    public override bool Equals(object obj) => obj is Vector3 v && Equals(v);
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 31 + X.GetHashCode();
            hash = hash * 31 + Y.GetHashCode();
            hash = hash * 31 + Z.GetHashCode();
            return hash;
        }
    }
    public override string ToString() => $"({X}, {Y}, {Z})";

    public static bool operator ==(Vector3 left, Vector3 right) => left.Equals(right);
    public static bool operator !=(Vector3 left, Vector3 right) => !left.Equals(right);
}
