namespace JaysModFramework.Core.Game.Settings;

/// <summary>
/// Severity levels for log messages, in ascending order.
/// A configured level is inclusive upward: Info captures Info, Warn, and Error.
/// </summary>
public enum LogLevel
{
    Debug = 0,
    Info  = 1,
    Warn  = 2,
    Error = 3,
    None  = 4,
}
