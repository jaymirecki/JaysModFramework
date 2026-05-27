using System;
using JaysModFramework.Core.UI;

namespace JaysModFramework.Core.Native;

public interface INativeUIService
{
    /// <summary>Displays a notification above the minimap.</summary>
    void Notify(string message);

    /// <summary>Repopulates the native menu with the given menu's items and makes it visible.</summary>
    void ShowMenu(Menu menu, int selectedIndex = 0, string bannerText = null);

    /// <summary>The index of the currently highlighted item in the native menu.</summary>
    int SelectedIndex { get; }

    /// <summary>Hides the native menu.</summary>
    void HideMenu();

    /// <summary>Calls ObjectPool.Process() to drive LemonUI rendering and input each tick.</summary>
    void ProcessFrame();

    /// <summary>Prevents the native GTA V character wheel from opening this frame.</summary>
    void SuppressNativeMenu();

    /// <summary>Raised when the user presses the back/close input in the native menu.</summary>
    event Action BackPressed;
}
