using System;
using System.IO;

namespace JaysModFramework.Rph;

/// <summary>
/// Writes timestamped log entries to JMF/JMF.log in the GTA V root directory.
/// All public methods are safe to call from any GameFiber.
/// </summary>
public static class Log
{
    // AppDomain.CurrentDomain.BaseDirectory is the GTA V root (the host exe directory).
    private static readonly string LogPath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory, "JMF", "JMF.log");

    private static readonly object _lock = new object();

    static Log()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(LogPath)!);
        WriteLine("INFO", "=== JMF session started ===");
    }

    public static void Error(string message) => WriteLine("ERROR", message);
    public static void Warn(string message)  => WriteLine("WARN",  message);
    public static void Info(string message)  => WriteLine("INFO",  message);
    public static void Debug(string message) => WriteLine("DEBUG", message);

    private static void WriteLine(string level, string message)
    {
        string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{level}]: {message}";
        lock (_lock)
            File.AppendAllText(LogPath, line + Environment.NewLine);
    }
}
