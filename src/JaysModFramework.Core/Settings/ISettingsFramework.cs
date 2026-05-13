using System.Collections.Generic;

namespace JaysModFramework.Core.Settings;

public interface ISettingsFramework
{
    LoggerSettings Logger { get; }
    FrameworkSettings Framework { get; }
    IReadOnlyDictionary<string, IPluginSettings> Plugins { get; }
}
