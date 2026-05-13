---
type: requirements
feature: menu-service
status: active
---

# MenuService — Requirements

## Overview

`Framework.MenuService` is the Framework layer service for defining and displaying menus. It provides `Menu` and `MenuItem` concrete classes in the `JaysModFramework.Core.UI` namespace that Core and plugins use to build menus without a LemonUI dependency. The Native layer (`INativeUIService`) handles rendering by converting these classes to LemonUI equivalents.

## Namespace

`Menu`, `MenuItem`, and `MenuService` all live in the `JaysModFramework.Core.UI` namespace.

## MenuItem

A single selectable entry in a menu.

```csharp
namespace JaysModFramework.Core.UI;

public class MenuItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Enabled { get; set; } = true;

    public event Action? OnSelected;  // fired when the player activates the item
    public event Action? OnHover;     // fired when the item becomes the highlighted item
}
```

A submenu item is a `MenuItem` whose `OnSelected` calls `MenuService.ShowMenu(childMenu)`.

## Menu

A named collection of menu items.

```csharp
namespace JaysModFramework.Core.UI;

public class Menu
{
    public string BannerText { get; set; }   // large colored banner, e.g. "JMF"
    public string Title { get; set; }         // subtitle below banner, e.g. "Debug"
    public string Description { get; set; }   // shown when this menu appears as a submenu item
    public IReadOnlyList<MenuItem> Items { get; }

    public void Add(MenuItem item);
    public void Remove(MenuItem item);
}
```

## MenuService

`Framework.MenuService` creates menus and enforces single-menu visibility.

```csharp
namespace JaysModFramework.Core.UI;

public class MenuService
{
    public Menu CreateMenu(string bannerText, string title);
    public void ShowMenu(Menu menu);
    public void HideMenu();
}
```

- `CreateMenu` constructs a `Menu` and registers it with `INativeUIService` so it is included in the LemonUI pool.
- `ShowMenu` makes the given menu visible. Any currently visible menu is hidden first.
- `HideMenu` hides the currently visible menu. The player can also close the menu by pressing Back, which LemonUI handles automatically.

### Framework Integration

`Framework.MenuService` is a property on `Framework`, constructed after Logger:

```csharp
MenuService = new MenuService(this);
```

## INativeUIService — Menu Extensions

`INativeUIService` gains menu rendering responsibilities in Step 2:

```csharp
public interface INativeUIService
{
    void Notify(string message);           // existing
    void RegisterMenu(Menu menu);          // adds menu to the LemonUI ObjectPool
    void ShowMenu(Menu menu);              // sets the menu visible in LemonUI
    void HideCurrentMenu();               // hides the currently visible LemonUI menu
    void ProcessFrame();                   // calls ObjectPool.Process() each tick
    void SuppressNativeMenu();            // disables the native GTA interaction menu for this frame
}
```

`SuppressNativeMenu` is called every tick by `InteractionMenu` to prevent the native GTA interaction menu from appearing when the player holds the open control.

The Native layer maps `Menu` → `NativeMenu` and `MenuItem` → `NativeItem`, wiring LemonUI's `Activated` and `Selected` events to the `MenuItem`'s `OnSelected` and `OnHover` events.

## Out of Scope

- Dynamic item visibility (show/hide based on plugin active state). Deferred to Step 3.
- Scrollable lists, checkboxes, sliders, or other LemonUI item types beyond basic selectable items. Added as needed.
- Custom menu renderer replacing LemonUI. Explicitly deferred.

## Future Direction

The current design delegates significant menu logic to the Native layer (LemonUI conversion, input handling, pool management). The long-term goal is to move this logic up into the Framework layer, leaving the Native layer responsible only for drawing — accepting a flat list of rendered items and coordinates rather than managing menus as objects. This is deferred until the current LemonUI-backed approach proves limiting.

## Related Documentation

- [Interaction Menu — Requirements](../plugin-interaction-menu/requirements.md)
- [UIService — Requirements](../ui-service/requirements.md)
- [Lifecycle — Requirements](../lifecycle/requirements.md)
