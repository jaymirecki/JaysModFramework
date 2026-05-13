namespace JaysModFramework.Core.Game.Settings;

/// <summary>
/// Base settings contract for all plugins. Plugins extend this with additional typed properties.
/// </summary>
public interface IPluginSettings
{
    bool DefaultActivatedStatus { get; }
}
