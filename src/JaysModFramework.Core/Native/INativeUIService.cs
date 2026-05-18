using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Native;

public interface INativeUIService
{
    /// <summary>Displays a notification above the minimap.</summary>
    void Notify(string message);

    /// <summary>Adds the menu to the LemonUI ObjectPool so it is processed each tick.</summary>
    void RegisterMenu(Menu menu);

    /// <summary>Makes the given menu visible.</summary>
    void ShowMenu(Menu menu);

    /// <summary>Hides the currently visible menu.</summary>
    void HideCurrentMenu();

    /// <summary>Triggers a back-navigation in the current menu.</summary>
    void Back();

    /// <summary>Calls ObjectPool.Process() to drive LemonUI rendering and input each tick.</summary>
    void ProcessFrame();

    /// <summary>Prevents the native GTA V character wheel from opening this frame.</summary>
    void SuppressNativeMenu();
}
