using System;
using System.Collections.Generic;

namespace JaysModFramework.Core.UI;

public class MenuListItem<T> : MenuItem, IMenuListItem
{
    private readonly List<T> _items;
    private readonly List<string> _displayItems;
    private int _selectedIndex;

    public IReadOnlyList<T> Items => _items;
    public int SelectedIndex { get => _selectedIndex; set => _selectedIndex = value; }
    public T SelectedItem => _items.Count > 0 ? _items[_selectedIndex] : default;

    public event Action<T> OnItemChanged;

    public MenuListItem(IEnumerable<T> items)
    {
        _items = new List<T>(items);
        _displayItems = new List<string>(_items.Count);
        foreach (var item in _items)
            _displayItems.Add(item?.ToString() ?? string.Empty);
    }

    // IMenuListItem — visible to the Rph layer via InternalsVisibleTo
    int IMenuListItem.SelectedIndex => _selectedIndex;
    List<string> IMenuListItem.DisplayItems => _displayItems;

    void IMenuListItem.RaiseItemChanged(int index)
    {
        _selectedIndex = index;
        if (Enabled) OnItemChanged?.Invoke(_items[index]);
    }
}
