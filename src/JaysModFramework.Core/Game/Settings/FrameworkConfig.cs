using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace JaysModFramework.Core.Game.Settings;

/// <summary>
/// Loads framework and plugin settings from config.xml.
/// If the file does not exist, defaults are used and the file is created.
/// </summary>
public class FrameworkConfig
{
    public LoggerSettings Logger { get; private set; } = new LoggerSettings();
    public FrameworkSettings Framework { get; private set; } = new FrameworkSettings();
    public IReadOnlyDictionary<string, IPluginSettings> Plugins { get; private set; }
        = new Dictionary<string, IPluginSettings>(StringComparer.OrdinalIgnoreCase);

    public static FrameworkConfig Load(string configPath)
    {
        var config = new FrameworkConfig();

        if (!File.Exists(configPath))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(configPath)!);
            config.Save(configPath);
            return config;
        }

        var doc = XDocument.Load(configPath);
        var root = doc.Root;
        if (root == null)
            return config;

        var frameworkEl = root.Element("Framework");
        if (frameworkEl != null)
        {
            config.Framework.DebugMode = ParseBool(frameworkEl.Element("DebugMode"), config.Framework.DebugMode);
            config.Framework.MenuOpenControl = ParseEnum(frameworkEl.Element("MenuOpenControl"), config.Framework.MenuOpenControl);
        }

        var loggerEl = root.Element("Logger");
        if (loggerEl != null)
        {
            config.Logger.LogLocation = loggerEl.Element("LogLocation")?.Value ?? config.Logger.LogLocation;
            config.Logger.LogLevel = ParseEnum(loggerEl.Element("LogLevel"), config.Logger.LogLevel);
            config.Logger.NotificationLevel = ParseEnum(loggerEl.Element("NotificationLevel"), config.Logger.NotificationLevel);
        }

        var plugins = new Dictionary<string, IPluginSettings>(StringComparer.OrdinalIgnoreCase);
        var pluginsEl = root.Element("Plugins");
        if (pluginsEl != null)
        {
            foreach (var pluginEl in pluginsEl.Elements("Plugin"))
            {
                var name = pluginEl.Attribute("name")?.Value;
                if (string.IsNullOrWhiteSpace(name))
                    continue;

                plugins[name!] = new PluginSettings
                {
                    DefaultActivatedStatus = ParseBool(pluginEl.Element("DefaultActivatedStatus"), true)
                };
            }
        }
        config.Plugins = plugins;

        return config;
    }

    private void Save(string configPath)
    {
        var doc = new XDocument(
            new XElement("JmfConfig",
                new XElement("Framework",
                    new XElement("DebugMode", Framework.DebugMode),
                    new XElement("MenuOpenControl", Framework.MenuOpenControl)
                ),
                new XElement("Logger",
                    new XElement("LogLocation", Logger.LogLocation),
                    new XElement("LogLevel", Logger.LogLevel),
                    new XElement("NotificationLevel", Logger.NotificationLevel)
                ),
                new XElement("Plugins")
            )
        );
        doc.Save(configPath);
    }

    private static bool ParseBool(XElement element, bool defaultValue)
    {
        if (element == null) return defaultValue;
        return bool.TryParse(element.Value, out var result) ? result : defaultValue;
    }

    private static T ParseEnum<T>(XElement element, T defaultValue) where T : struct, Enum
    {
        if (element == null) return defaultValue;
        return Enum.TryParse(element.Value, ignoreCase: true, out T result) ? result : defaultValue;
    }
}
