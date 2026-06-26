namespace JaysModFramework.Core.Native;

public interface INativePlayer
{
    INativePed Character { get; }

    string Model { get; }
    void SetModel(string modelName);
    Vector3 Position { get; set; }
    float Heading { get; set; }
    int Health { get; set; }
    int Armor { get; set; }
}
