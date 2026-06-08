namespace JaysModFramework.Core.Plugins;

public interface IPlugin
{
    string Name { get; }
    void Initialize(Framework services);
    void Shutdown();
}
