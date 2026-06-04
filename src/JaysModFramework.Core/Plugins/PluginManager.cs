using System.Collections.Generic;

namespace JaysModFramework.Core.Plugins;

public class PluginManager
{
    private readonly List<IPlugin> _plugins = new List<IPlugin>();

    public IReadOnlyList<IPlugin> Plugins => _plugins;

    public void Register(IPlugin plugin) => _plugins.Add(plugin);

    public void InitializeAll(IFrameworkServices services)
    {
        foreach (var plugin in _plugins)
            plugin.Initialize(services);
    }

    public void ShutdownAll()
    {
        foreach (var plugin in _plugins)
            plugin.Shutdown();
    }
}
