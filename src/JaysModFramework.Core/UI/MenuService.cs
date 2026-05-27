using System.Collections.Generic;
using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.UI;

public class MenuService
{
    private readonly INativeUIService _uiService;
    private readonly List<(Menu menu, int returnIndex)> _stack = new List<(Menu, int)>();
    private readonly HashSet<MenuItem> _wiredItems = new HashSet<MenuItem>();
    private string _bannerText = string.Empty;

    public bool IsVisible => _stack.Count > 0;

    internal MenuService(INativeUIService uiService)
    {
        _uiService = uiService;
        _uiService.BackPressed += OnBackPressed;
    }

    public Menu CreateMenu(string bannerText, string title)
    {
        return new Menu { BannerText = bannerText, Title = title };
    }

    public void ShowMenu(Menu menu)
    {
        _bannerText = menu.BannerText ?? string.Empty;
        _stack.Clear();
        _stack.Add((menu, 0));
        WireNavigation(menu);
        _uiService.ShowMenu(menu, 0, _bannerText);
    }

    public void HideMenu()
    {
        _stack.Clear();
        _uiService.HideMenu();
    }

    /// <summary>Re-renders the current menu at the current selected index without changing navigation state.</summary>
    public void RefreshMenu()
    {
        if (_stack.Count == 0) return;
        var (menu, _) = _stack[_stack.Count - 1];
        _uiService.ShowMenu(menu, _uiService.SelectedIndex, _bannerText);
    }

    public void Back() => OnBackPressed();

    private void OnBackPressed()
    {
        if (_stack.Count > 0)
            _stack.RemoveAt(_stack.Count - 1);

        if (_stack.Count > 0)
        {
            var (menu, returnIndex) = _stack[_stack.Count - 1];
            _uiService.ShowMenu(menu, returnIndex, _bannerText);
        }
        else
            _uiService.HideMenu();
    }

    private void WireNavigation(Menu menu)
    {
        foreach (var item in menu.Items)
        {
            if (item.LinkedSubmenu == null || _wiredItems.Contains(item))
                continue;

            _wiredItems.Add(item);
            var submenu = item.LinkedSubmenu;
            item.OnActivated += () =>
            {
                // Save the current position so it's restored when the user backs out
                if (_stack.Count > 0)
                {
                    var current = _stack[_stack.Count - 1];
                    _stack[_stack.Count - 1] = (current.menu, _uiService.SelectedIndex);
                }
                _stack.Add((submenu, 0));
                WireNavigation(submenu);
                _uiService.ShowMenu(submenu, 0, _bannerText);
            };
        }
    }
}
