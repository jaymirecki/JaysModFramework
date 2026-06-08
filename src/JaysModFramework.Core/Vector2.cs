namespace JaysModFramework.Core;

public struct Vector2
{
    public float X { get; }
    public float Y { get; }

    public Vector2(float x, float y)
    {
        X = x;
        Y = y;
    }

    public bool Equals(Vector2 other) => X == other.X && Y == other.Y;
    public override bool Equals(object obj) => obj is Vector2 v && Equals(v);
    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 31 + X.GetHashCode();
            hash = hash * 31 + Y.GetHashCode();
            return hash;
        }
    }
    public override string ToString() => $"({X}, {Y})";

    public static bool operator ==(Vector2 left, Vector2 right) => left.Equals(right);
    public static bool operator !=(Vector2 left, Vector2 right) => !left.Equals(right);
}
