namespace JaysModFramework.Core.Settings;

/// <summary>
/// Base plugin settings loaded from config.xml. Plugins extend this class to add
/// additional typed properties, which they parse from their own XML elements.
/// </summary>
public class PluginSettings : IPluginSettings
{
    public bool DefaultActivatedStatus { get; set; } = true;
}
