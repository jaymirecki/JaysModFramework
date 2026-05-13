using System;
using System.IO;
using JaysModFramework.Core;
using JaysModFramework.Core.Settings;
using JaysModFramework.Tests.Fakes;
using Xunit;

namespace JaysModFramework.Tests;

public class LoggerTests : IDisposable
{
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
    private readonly FakeNativeFramework _fakeNative;

    private string ConfigDir => Path.Combine(_tempDir, "JMF");
    private string ConfigPath => Path.Combine(ConfigDir, "config.xml");
    private string LogPath => Path.Combine(_tempDir, "JMF", "JaysModFramework.log");

    public LoggerTests()
    {
        _fakeNative = new FakeNativeFramework { GameDirectory = _tempDir };
    }

    public void Dispose() => Directory.Delete(_tempDir, recursive: true);

    private Framework BuildFramework(LogLevel logLevel = LogLevel.Debug, LogLevel notificationLevel = LogLevel.None)
    {
        Directory.CreateDirectory(ConfigDir);
        File.WriteAllText(ConfigPath, $@"<JmfConfig>
            <Logger>
                <LogLevel>{logLevel}</LogLevel>
                <NotificationLevel>{notificationLevel}</NotificationLevel>
            </Logger>
        </JmfConfig>");
        return new Framework(_fakeNative);
    }

    [Fact]
    public void Constructor_CreatesLogFile()
    {
        BuildFramework();

        Assert.True(File.Exists(LogPath));
    }

    [Fact]
    public void Info_WhenLogLevelIsInfo_WritesToFile()
    {
        var framework = BuildFramework(logLevel: LogLevel.Info);

        framework.Logger.Info("hello");

        Assert.Contains("hello", File.ReadAllText(LogPath));
    }

    [Fact]
    public void Debug_WhenLogLevelIsInfo_DoesNotWriteToFile()
    {
        var framework = BuildFramework(logLevel: LogLevel.Info);

        framework.Logger.Debug("should not appear");

        Assert.DoesNotContain("should not appear", File.ReadAllText(LogPath));
    }

    [Fact]
    public void Error_WhenLogLevelIsInfo_WritesToFile()
    {
        var framework = BuildFramework(logLevel: LogLevel.Info);

        framework.Logger.Error("something broke");

        Assert.Contains("something broke", File.ReadAllText(LogPath));
    }

    [Fact]
    public void Log_EntryIncludesLevelLabel()
    {
        var framework = BuildFramework();

        framework.Logger.Warn("watch out");

        Assert.Contains("[WARN]", File.ReadAllText(LogPath));
    }

    [Fact]
    public void Log_EntryIncludesTimestamp()
    {
        var framework = BuildFramework();

        framework.Logger.Info("timestamped");

        Assert.Matches(@"\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}", File.ReadAllText(LogPath));
    }

    [Fact]
    public void Error_WhenNotificationLevelIsError_SendsNotification()
    {
        var framework = BuildFramework(notificationLevel: LogLevel.Error);

        framework.Logger.Error("notify me");

        Assert.Single(_fakeNative.UIService.Notifications, n => n.Contains("notify me"));
    }

    [Fact]
    public void Info_WhenNotificationLevelIsError_DoesNotSendNotification()
    {
        var framework = BuildFramework(notificationLevel: LogLevel.Error);

        framework.Logger.Info("quiet");

        Assert.Empty(_fakeNative.UIService.Notifications);
    }

    [Fact]
    public void Notify_MessageIncludesLevelLabel()
    {
        var framework = BuildFramework(notificationLevel: LogLevel.Debug);

        framework.Logger.Debug("debug msg");

        Assert.Single(_fakeNative.UIService.Notifications, n => n.Contains("[DEBUG]"));
    }

    [Fact]
    public void LogLevel_None_WritesNothingBeyondSessionStart()
    {
        var framework = BuildFramework(logLevel: LogLevel.None);

        framework.Logger.Error("suppressed");

        Assert.DoesNotContain("suppressed", File.ReadAllText(LogPath));
    }
}
