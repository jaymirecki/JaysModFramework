namespace JaysModFramework.Core.Plugins;

public interface IPlugin
{
    string Name { get; }
    void Initialize(IFrameworkServices services);
    void Shutdown();
}
