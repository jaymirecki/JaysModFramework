namespace JaysModFramework.Core.Game.Settings;

public class FrameworkSettings
{
    /// <summary>Enables the Debug submenu in the interaction menu.</summary>
    public bool DebugMode { get; set; } = false;

    /// <summary>The control that opens the JMF interaction menu.</summary>
    public JmfControl MenuOpenControl { get; set; } = JmfControl.CharacterWheel;
}
