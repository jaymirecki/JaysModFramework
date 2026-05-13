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
    public Menu? LinkedSubmenu { get; internal set; }  // set by Menu.AddSubmenu; null for regular items

    public event Action? OnSelected;  // fired when the player activates the item
    public event Action? OnHover;     // fired when the item becomes the highlighted item
}
```

When `LinkedSubmenu` is set, UIService uses `NativeMenu.AddSubMenu` instead of a standalone `NativeItem`, delegating navigation and item-restoration to LemonUI.

## Menu

A named collection of menu items. Always constructed via `MenuService.CreateMenu` — the constructor is internal.

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
    public void AddSubmenu(Menu submenu);
}
```

`AddSubmenu` creates a `MenuItem` with `LinkedSubmenu` set — no `OnSelected` wiring needed. LemonUI handles the navigation when UIService sees the link:

```csharp
public void AddSubmenu(Menu submenu)
{
    var item = new MenuItem
    {
        Title = submenu.Title,
        Description = submenu.Description,
        LinkedSubmenu = submenu
    };
    Add(item);
}
```

The caller never configures navigation for submenu items — `AddSubmenu` and UIService handle it entirely. Previous item highlighting on Back is restored by LemonUI natively.

## MenuService

`Framework.MenuService` creates menus and enforces single-menu visibility. Submenu navigation is owned by LemonUI; `MenuService` tracks only the root menu state.

```csharp
namespace JaysModFramework.Core.UI;

public class MenuService
{
    public Menu CreateMenu(string bannerText, string title);
    public void ShowMenu(Menu menu);
    public void HideMenu();
    public void Back();
}
```

- `CreateMenu` constructs a `Menu`, registers it with `INativeUIService` immediately, and returns it. `Menu` does not need an injected `MenuService` reference — `AddSubmenu` uses `LinkedSubmenu` rather than callbacks.
- `ShowMenu` shows the given menu as the root. Any currently visible menu is hidden first.
- `HideMenu` hides the current menu.
- `Back` instructs UIService to trigger a LemonUI back navigation programmatically. If the current menu is the root (no parent in LemonUI), this closes the menu.

### Navigation Ownership

LemonUI owns submenu navigation. When UIService registers a menu containing items with `LinkedSubmenu` set, it uses `NativeMenu.AddSubMenu` to link them. From that point, LemonUI manages:
- Which menu is visible when the player selects a submenu item.
- Which item is highlighted when the player presses Back.

UIService fires an event when LemonUI closes the root menu via Back (the player backing out past the top level). `MenuService` subscribes to this event to update its internal state (marking no menu as currently visible).

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

The Native layer maps `Menu` → `NativeMenu` and `MenuItem` → `NativeItem` or `NativeMenu.AddSubMenu` depending on whether `LinkedSubmenu` is set. LemonUI's `Activated` and `Selected` events are wired to `OnSelected` and `OnHover` for regular items. For submenu items, LemonUI handles navigation natively — including restoring the previously selected item when the player presses Back. UIService exposes an event that fires when LemonUI closes the root menu so `MenuService` can update its visibility state.

## Decisions

| # | Question | Decision |
|---|---|---|
| 1 | Submenu model: tree vs. callback | `Menu.AddSubmenu` creates a MenuItem with `LinkedSubmenu` set. UIService uses `NativeMenu.AddSubMenu`, delegating navigation and item-restoration to LemonUI. `MenuService` does not maintain a navigation stack — LemonUI owns submenu navigation. |
| 2 | Registration timing | Eager — `CreateMenu` registers with `INativeUIService` immediately. Safe because `MenuService` is constructed after the native layer is ready. |

## Out of Scope

- Dynamic item visibility (show/hide based on plugin active state). Deferred to Step 3.
- Scrollable lists, checkboxes, sliders, or other LemonUI item types beyond basic selectable items. Added as needed.
- Custom menu renderer replacing LemonUI. Explicitly deferred.

## Future Direction

The current design delegates submenu navigation to LemonUI (Option A). This means the Native layer owns Back navigation and item-restoration behavior. The long-term goal (Option B) is to move all navigation logic into the Framework layer — `MenuService` owns the full navigation stack and selected-item tracking, and the Native layer is reduced to pure drawing (accepting a flat list of rendered items and coordinates). This transition is the natural milestone for replacing LemonUI with a custom renderer.

## Related Documentation

- [Interaction Menu — Requirements](../plugin-interaction-menu/requirements.md)
- [UIService — Requirements](../ui-service/requirements.md)
- [Lifecycle — Requirements](../lifecycle/requirements.md)
