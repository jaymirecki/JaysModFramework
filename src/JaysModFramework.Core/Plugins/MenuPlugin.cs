using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Plugins;


/// <summary>Base class for plugins that expose a submenu in the Interaction Menu.</summary>
public abstract class MenuPlugin : IPlugin
{
    public Menu Menu { get; } = new Menu { BannerText = "JMF" };

    protected string MenuTitle
    {
        get => Menu.Title;
        set => Menu.Title = value;
    }

    public abstract string Name { get; }
    public abstract void Initialize(Framework services);
    public abstract void Shutdown();
}
