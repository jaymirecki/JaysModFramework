using System;
using System.Collections.Generic;
using System.IO;
using JaysModFramework.Core.Game.Settings;
using Xunit;

namespace JaysModFramework.Tests.Settings;

public class FrameworkConfigTests : IDisposable
{
    private readonly string _tempDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
    private string ConfigPath => Path.Combine(_tempDir, "config.xml");

    public void Dispose() => Directory.Delete(_tempDir, recursive: true);

    [Fact]
    public void Load_WhenFileDoesNotExist_ReturnsDefaults()
    {
        var config = FrameworkConfig.Load(ConfigPath);

        Assert.Equal("JMF/JaysModFramework.log", config.Logger.LogLocation);
        Assert.Equal(LogLevel.Info, config.Logger.LogLevel);
        Assert.Equal(LogLevel.Error, config.Logger.NotificationLevel);
        Assert.False(config.Framework.DebugMode);
        Assert.Equal("CharacterWheel", config.Framework.MenuOpenControl);
        Assert.Empty(config.Plugins);
    }

    [Fact]
    public void Load_WhenFileDoesNotExist_CreatesConfigFile()
    {
        FrameworkConfig.Load(ConfigPath);

        Assert.True(File.Exists(ConfigPath));
    }

    [Fact]
    public void Load_ParsesLoggerSettings()
    {
        WriteConfig(@"<JmfConfig>
            <Logger>
                <LogLocation>JMF/custom.log</LogLocation>
                <LogLevel>Debug</LogLevel>
                <NotificationLevel>Warn</NotificationLevel>
            </Logger>
        </JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.Equal("JMF/custom.log", config.Logger.LogLocation);
        Assert.Equal(LogLevel.Debug, config.Logger.LogLevel);
        Assert.Equal(LogLevel.Warn, config.Logger.NotificationLevel);
    }

    [Fact]
    public void Load_ParsesFrameworkSettings()
    {
        WriteConfig(@"<JmfConfig>
            <Framework>
                <DebugMode>true</DebugMode>
                <MenuOpenControl>VehicleHorn</MenuOpenControl>
            </Framework>
        </JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.True(config.Framework.DebugMode);
        Assert.Equal("VehicleHorn", config.Framework.MenuOpenControl);
    }

    [Fact]
    public void Load_ParsesPluginSettings()
    {
        WriteConfig(@"<JmfConfig>
            <Plugins>
                <Plugin name=""Sirens"">
                    <DefaultActivatedStatus>false</DefaultActivatedStatus>
                </Plugin>
            </Plugins>
        </JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.True(config.Plugins.ContainsKey("Sirens"));
        Assert.False(config.Plugins["Sirens"].DefaultActivatedStatus);
    }

    [Fact]
    public void Load_PluginLookupIsCaseInsensitive()
    {
        WriteConfig(@"<JmfConfig>
            <Plugins>
                <Plugin name=""Sirens"">
                    <DefaultActivatedStatus>true</DefaultActivatedStatus>
                </Plugin>
            </Plugins>
        </JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.True(config.Plugins.ContainsKey("sirens"));
        Assert.True(config.Plugins.ContainsKey("SIRENS"));
    }

    [Fact]
    public void Load_WhenSectionMissing_UsesDefaults()
    {
        WriteConfig("<JmfConfig></JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.Equal(LogLevel.Info, config.Logger.LogLevel);
        Assert.False(config.Framework.DebugMode);
        Assert.Empty(config.Plugins);
    }

    [Fact]
    public void Load_WhenLogLevelInvalid_UsesDefault()
    {
        WriteConfig(@"<JmfConfig>
            <Logger>
                <LogLevel>NotALevel</LogLevel>
            </Logger>
        </JmfConfig>");

        var config = FrameworkConfig.Load(ConfigPath);

        Assert.Equal(LogLevel.Info, config.Logger.LogLevel);
    }

    private void WriteConfig(string xml)
    {
        Directory.CreateDirectory(_tempDir);
        File.WriteAllText(ConfigPath, xml);
    }
}
