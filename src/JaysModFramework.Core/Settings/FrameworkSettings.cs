namespace JaysModFramework.Core.Settings;

public class FrameworkSettings
{
    /// <summary>Enables the Debug submenu in the interaction menu.</summary>
    public bool DebugMode { get; set; } = false;

    /// <summary>
    /// Name of the game control that opens the interaction menu.
    /// Stored as a string here; resolved to a native GameControl in the Rph layer.
    /// </summary>
    public string MenuOpenControl { get; set; } = "CharacterWheel";
}
