namespace JaysModFramework.Core.Native;

public interface INativePlayer
{
    INativePed Ped { get; }

    string Model { get; }
    void SetModel(string modelName);
}
