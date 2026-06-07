namespace JaysModFramework.Core.Data;

public class FrameworkData
{
    public ModelData Models { get; }

    public FrameworkData(string gameDirectory)
    {
        Models = new ModelData(gameDirectory);
    }
}
