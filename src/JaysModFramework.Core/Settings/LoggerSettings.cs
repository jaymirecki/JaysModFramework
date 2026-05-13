namespace JaysModFramework.Core.Settings;

public class LoggerSettings
{
    /// <summary>Path to the log file, relative to the GTA V root folder.</summary>
    public string LogLocation { get; set; } = "JMF/JaysModFramework.log";

    /// <summary>Minimum severity written to the log file.</summary>
    public LogLevel LogLevel { get; set; } = LogLevel.Info;

    /// <summary>Minimum severity surfaced as an in-game notification.</summary>
    public LogLevel NotificationLevel { get; set; } = LogLevel.Error;
}
