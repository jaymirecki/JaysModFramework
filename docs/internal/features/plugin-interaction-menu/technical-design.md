---
type: technical-design
feature: plugin-interaction-menu
status: draft
related:
  - plugin-system
  - save-load
---

# Interaction Menu — Technical Design

## Overview

The interaction menu is a core framework service that provides the primary UI surface for JMF. It is not itself a plugin, but it is the system that drives the plugin activation lifecycle and exposes plugin settings to the player.

It is built on [LemonUI.RagePluginHook](https://www.nuget.org/packages/LemonUI.RagePluginHook) v2.2.0. At some point a custom menu renderer may replace LemonUI, but this is explicitly deferred.

## Architecture Decision: Core Service, Not a Plugin

The interaction menu is a core service rather than a plugin because:
- It requires access to the full plugin registry to build the Plugins submenu.
- It drives plugin activation, which must be reliable and not depend on another plugin running.
- The Game submenu (save/load) is a framework concern, not a plugin concern.

The `InteractionMenuManager` lives in `JaysModFramework.Rph` (it depends on LemonUI, which is RPH-specific). Its interface, `IInteractionMenu`, lives in `Core` so that plugins can interact with it through `IFrameworkServices` without a LemonUI dependency.

## Menu Structure

```
Interaction Menu (root)
│
├── [Plugin top-level items]        Injected by plugins; ordered by Priority, then Name.
│                                   Shown only when the providing plugin is active.
│
├── Plugins                         Auto-built from all registered plugins.
│   └── <Plugin Name>               One submenu per plugin, alphabetical.
│       ├── Enabled  [checkbox]     Calls plugin.Activate() / Deactivate().
│       └── <settings items>        Declared by the plugin's PluginSettings subclass.
│
├── Game
│   ├── New Game
│   ├── Save Game
│   └── Load Game
│
└── Debug                           Only present when debug mode is enabled.
    ├── Show Position
    ├── Log Current Model
    └── [extensible]
```

### Top-Level Item Ordering

Plugin-defined top-level items are sorted first by `Priority` (ascending — lower number = higher position), then alphabetically by label within the same priority. This gives plugins explicit control without requiring globally unique ordering.

**Recommendation**: use a small set of conventional priority values (e.g. 100 = default, 50 = high, 200 = low) rather than arbitrary integers, to avoid accidental ordering conflicts.

## IInteractionMenu (Core)

Plugins receive this through `IFrameworkServices`. They use it to register top-level items.

```csharp
public interface IInteractionMenu
{
    /// <summary>
    /// Registers a top-level item contributed by a plugin.
    /// Should be called during IPlugin.Initialize.
    /// Items from inactive plugins are hidden automatically.
    /// </summary>
    void AddTopLevelItem(IMenuItem item, IPlugin owner);
}
```

## IMenuItem (Core)

```csharp
public interface IMenuItem
{
    string Label { get; }
    int Priority { get; }     // lower = higher in list; default 100
    void OnSelected();
}
```

A submenu item is also an `IMenuItem` where `OnSelected` opens a child menu. Concrete types are LemonUI-backed and live in `Rph`.

## IPlugin — Full Interface

The current `IPlugin` stub needs to expand significantly. See also [Plugin System — Technical Design](../plugin-system/technical-design.md).

```csharp
public interface IPlugin
{
    // Identity
    string Name { get; }
    string Description { get; }
    string Version { get; }
    IReadOnlyList<string> Dependencies { get; }

    // Lifecycle (called by framework)
    void Initialize(IFrameworkServices services);
    void Shutdown();
    void Activate();      // sets IsActive = true; then calls OnActivate()
    void Deactivate();    // sets IsActive = false; then calls OnDeactivate()

    // State
    bool IsActive { get; }
    PluginSettings Settings { get; }

    // Plugin-defined hooks (called by framework after state change)
    void OnActivate();
    void OnDeactivate();

    // Per-frame (called by PluginManager only for initialized plugins)
    void OnTick();

    // Controls (called by PluginManager only for active plugins)
    void OnControlReleased(GameControl control);
    void OnControlHeld(GameControl control);
    void OnControlDoublePressed(GameControl control);

    // Interaction menu
    IReadOnlyList<IMenuItem> TopLevelMenuItems { get; }
}
```

**Note**: `Activate()` and `Deactivate()` must not be overridden by individual plugins — they are the framework's reliable mechanism for setting `IsActive`. Plugins define side effects in `OnActivate()` and `OnDeactivate()`. This is enforced by making them non-virtual in `PluginBase`.

## PluginBase (Core)

All plugins inherit from `PluginBase` rather than implementing `IPlugin` directly.

```csharp
public abstract class PluginBase : IPlugin
{
    public abstract string Name { get; }
    public abstract string Description { get; }
    public virtual string Version => "1.0.0";
    public virtual IReadOnlyList<string> Dependencies => Array.Empty<string>();

    public bool IsActive { get; private set; }
    public virtual PluginSettings Settings { get; } = new PluginSettings();
    public virtual IReadOnlyList<IMenuItem> TopLevelMenuItems => Array.Empty<IMenuItem>();

    public virtual void Initialize(IFrameworkServices services) { }
    public virtual void Shutdown() { }

    // Sealed: framework-owned behavior
    public sealed void Activate()
    {
        IsActive = true;
        OnActivate();
    }

    public sealed void Deactivate()
    {
        IsActive = false;
        OnDeactivate();
    }

    // Overridable hooks
    protected virtual void OnActivate() { }
    protected virtual void OnDeactivate() { }

    // Explicit IPlugin implementation for the public interface
    void IPlugin.OnActivate() => OnActivate();
    void IPlugin.OnDeactivate() => OnDeactivate();

    public virtual void OnTick() { }
    public virtual void OnControlReleased(GameControl control) { }
    public virtual void OnControlHeld(GameControl control) { }
    public virtual void OnControlDoublePressed(GameControl control) { }
}
```

## PluginSettings (Core)

```csharp
public class PluginSettings
{
    /// <summary>Whether the plugin is active when JMF first loads.</summary>
    public bool DefaultActivatedStatus { get; set; } = true;
}
```

Plugins extend this class to add their own settings:

```csharp
public class SirenManagerSettings : PluginSettings
{
    public GameControl ToggleControl { get; set; } = GameControl.VehicleHorn;
}
```

Settings instances are exposed via `IPlugin.Settings` and read by the interaction menu to build the plugin's settings submenu items. The mapping from settings properties to menu items needs a mechanism — see Open Questions.

## PluginManager (Core — replaces PluginRegistry)

`PluginRegistry` grows into `PluginManager` to handle dispatch of all plugin events:

```csharp
public sealed class PluginManager
{
    public void Register(PluginBase plugin);
    public void InitializeAll(IFrameworkServices services);
    public void ShutdownAll();

    // Called by TickManager each frame
    public void TickAll();

    // Called by InteractionMenuManager when a control fires
    public void DispatchControlReleased(GameControl control);
    public void DispatchControlHeld(GameControl control);
    public void DispatchControlDoublePressed(GameControl control);

    // For menu construction
    public IReadOnlyList<PluginBase> AllPlugins { get; }
}
```

Control dispatching goes **only to active plugins** — inactive plugins do not receive control callbacks.

`OnTick()` is dispatched **only to active plugins**.

## InteractionMenuManager (Rph)

Lives in `JaysModFramework.Rph`. Implements `ITickable` and `IInteractionMenu`.

```csharp
public sealed class InteractionMenuManager : ITickable, IInteractionMenu
{
    private readonly ObjectPool _pool;
    private readonly NativeMenu _rootMenu;
    private readonly PluginManager _pluginManager;
    // ... submenus

    public InteractionMenuManager(PluginManager pluginManager, bool debugMode) { ... }

    public void Tick()
    {
        _pool.Process();

        if (Game.IsControlJustPressed(/* open menu control */ ))
            _rootMenu.Visible = !_rootMenu.Visible;
    }

    public void AddTopLevelItem(IMenuItem item, IPlugin owner) { ... }

    private void BuildPluginsSubmenu() { ... }
    private void BuildGameSubmenu() { ... }
    private void BuildDebugSubmenu() { ... }  // only if FrameworkSettings.DebugMode
}
```

The `_pool.Process()` call must happen every frame for LemonUI to process input and render menus. This is the `InteractionMenuManager`'s own tick responsibility — one tickable per system.

## IFrameworkServices

```csharp
public interface IFrameworkServices
{
    ITickManager TickManager { get; }
    IGameWorld GameWorld { get; }
}
```

`IInteractionMenu` is intentionally not exposed here. Plugins declare top-level items via the `TopLevelMenuItems` property; the menu manager reads them directly from the plugin registry. Dynamic registration via `IInteractionMenu` is deferred.

## Framework File Structure

See [File Structure](../../architecture/file-structure.md) for the full game folder layout and `config.xml` shape.

The interaction menu reads `FrameworkSettings.DebugMode` and `FrameworkSettings.MenuOpenControl` from `Framework.Settings` at initialization. Plugin settings are keyed by `IPlugin.Name`; property names in `config.xml` match the plugin's `IPluginSettings` subclass property names. Reflection is used for both menu item generation and serialization.

## Decisions

| # | Question | Decision |
|---|---|---|
| 1 | Menu open control | Configurable via `FrameworkSettings.MenuOpenControl`; default `JmfControl.CharacterWheel` |
| 2 | Settings → menu items | Attribute-based reflection: `[MenuSetting("Label")]` on `PluginSettings` properties. Reflection stays in `Rph`; `Core` is clean. |
| 3 | Debug mode | `FrameworkSettings.DebugMode` boolean loaded from `Settings.xml` |
| 4 | Top-level items for inactive plugins | Hidden — only shown when the plugin is active |
| 5 | `OnTick` for inactive plugins | Not dispatched — `OnTick` fires only for active plugins |

## Related Documentation

- [Plugin System — Technical Design](../plugin-system/technical-design.md)
- [Requirements](requirements.md)
- [Save/Load — Technical Design](../save-load/wip-technical-design.md)
- [Testing Strategy](../../workflows/wip-testing-strategy.md)
