using System;
using System.IO;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.Game.Settings;

namespace JaysModFramework.Core.Game;

/// <summary>
/// Writes log messages to a file and optionally surfaces them as in-game notifications.
/// Levels are inclusive upward: a configured level of Info captures Info, Warn, and Error.
/// </summary>
public class Logger
{
    private readonly string _logPath;
    private readonly LogLevel _logLevel;
    private readonly LogLevel _notificationLevel;
    private readonly INativeUIService _uiService;
    private readonly object _lock = new object();

    public Logger(GameServices game)
    {
        var settings = game.Settings.Logger;
        _logPath = Path.IsPathRooted(settings.LogLocation)
            ? settings.LogLocation
            : Path.Combine(game.NativeFramework.GameDirectory, settings.LogLocation);
        _logLevel = settings.LogLevel;
        _notificationLevel = settings.NotificationLevel;
        _uiService = game.NativeFramework.UIService;

        Directory.CreateDirectory(Path.GetDirectoryName(_logPath)!);
        ClearFile();
        WriteToFile("INFO", "=== JMF session started ===");
    }

    public void Error(string message) => Log(LogLevel.Error, "ERROR", message);
    public void Warn(string message)  => Log(LogLevel.Warn,  "WARN",  message);
    public void Info(string message)  => Log(LogLevel.Info,  "INFO",  message);
    public void Debug(string message) => Log(LogLevel.Debug, "DEBUG", message);

    private void Log(LogLevel level, string label, string message)
    {
        if (level >= _logLevel)
            WriteToFile(label, message);

        if (level >= _notificationLevel)
            _uiService.Notify($"[{label}] {message}");
    }

    private void ClearFile()
    {
        lock (_lock)
            File.WriteAllText(_logPath, string.Empty);
    }

    private void WriteToFile(string label, string message)
    {
        var line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{label}] {message}";
        lock (_lock)
            File.AppendAllText(_logPath, line + Environment.NewLine);
    }
}
