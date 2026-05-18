using JaysModFramework.Core.Native;

namespace JaysModFramework.Core.UI;

public class MenuService
{
    private readonly INativeUIService _uiService;
    private Menu _current;

    internal MenuService(INativeUIService uiService)
    {
        _uiService = uiService;
    }

    public bool IsVisible => _current != null;

    public Menu CreateMenu(string bannerText, string title)
    {
        var menu = new Menu { BannerText = bannerText, Title = title };
        _uiService.RegisterMenu(menu);
        return menu;
    }

    public void ShowMenu(Menu menu)
    {
        if (_current != null && _current != menu)
            _uiService.HideCurrentMenu();
        _current = menu;
        _uiService.ShowMenu(menu);
    }

    public void HideMenu()
    {
        _current = null;
        _uiService.HideCurrentMenu();
    }

    public void Back()
    {
        _uiService.Back();
    }
}
