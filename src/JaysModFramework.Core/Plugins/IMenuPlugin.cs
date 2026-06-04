using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Plugins;

/// <summary>Optional extension for plugins that expose a submenu in the Interaction Menu.</summary>
public interface IMenuPlugin : IPlugin
{
    Menu GetMenu();
}
