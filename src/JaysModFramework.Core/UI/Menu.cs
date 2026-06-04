using System.Collections.Generic;

namespace JaysModFramework.Core.UI;

public class Menu
{
    private readonly List<MenuItem> _items = new List<MenuItem>();

    public string BannerText { get; set; } = null;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IReadOnlyList<MenuItem> Items => _items;

    public Menu() { }

    public void Add(MenuItem item) => _items.Add(item);
    public void Remove(MenuItem item) => _items.Remove(item);

    public void AddSubmenu(Menu submenu)
    {
        var item = new MenuItem
        {
            Title = submenu.Title,
            Description = submenu.Description,
            LinkedSubmenu = submenu,
        };
        Add(item);
    }
}
