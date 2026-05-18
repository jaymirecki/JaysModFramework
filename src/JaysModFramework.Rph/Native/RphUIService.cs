using System.Collections.Generic;
using JaysModFramework.Core.Native;
using JaysModFramework.Core.UI;
using LemonUI;
using LemonUI.Menus;
using Rage;
using Rage.Native;

namespace JaysModFramework.Rph.Native;

internal sealed class RphUIService : INativeUIService
{
    private readonly ObjectPool _pool = new ObjectPool();
    private readonly Dictionary<Menu, NativeMenu> _nativeMenus = new Dictionary<Menu, NativeMenu>();
    private NativeMenu _currentNativeMenu;

    public void Notify(string message) => Game.DisplayNotification(message);

    public void RegisterMenu(Menu menu)
    {
        var nativeMenu = new NativeMenu(menu.BannerText, menu.Title);
        _nativeMenus[menu] = nativeMenu;
        _pool.Add(nativeMenu);
    }

    public void ShowMenu(Menu menu)
    {
        SyncMenu(menu);
        var nativeMenu = _nativeMenus[menu];
        _currentNativeMenu = nativeMenu;
        nativeMenu.Visible = true;
    }

    public void HideCurrentMenu()
    {
        if (_currentNativeMenu != null)
            _currentNativeMenu.Visible = false;
        _currentNativeMenu = null;
    }

    public void Back()
    {
        if (_currentNativeMenu != null)
            _currentNativeMenu.Back();
    }

    public void ProcessFrame() => _pool.Process();

    public void SuppressNativeMenu()
    {
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 0, (int)GameControl.CharacterWheel, true);
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 1, (int)GameControl.CharacterWheel, true);
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 2, (int)GameControl.CharacterWheel, true);
    }

    private void SyncMenu(Menu menu)
    {
        var nativeMenu = _nativeMenus[menu];
        nativeMenu.Clear();

        foreach (var item in menu.Items)
        {
            if (item.LinkedSubmenu != null)
            {
                if (!_nativeMenus.ContainsKey(item.LinkedSubmenu))
                    RegisterMenu(item.LinkedSubmenu);
                SyncMenu(item.LinkedSubmenu);

                var subNativeMenu = _nativeMenus[item.LinkedSubmenu];
                subNativeMenu.Parent = nativeMenu;
                var subItem = new NativeItem(item.Title, item.Description);
                subItem.Activated += (sender, args) =>
                {
                    nativeMenu.Visible = false;
                    subNativeMenu.Visible = true;
                };
                nativeMenu.Add(subItem);
            }
            else
            {
                var nativeItem = new NativeItem(item.Title, item.Description);
                nativeItem.Activated += (sender, args) => item.RaiseSelected();
                nativeMenu.Add(nativeItem);
            }
        }
    }
}
