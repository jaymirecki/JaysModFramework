using System;

namespace JaysModFramework.Core.UI;

public class MenuItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Enabled { get; set; } = true;
    public Menu LinkedSubmenu { get; internal set; }

    public event Action OnSelected;
    public event Action OnHover;

    internal void RaiseSelected() => OnSelected?.Invoke();
    internal void RaiseHover() => OnHover?.Invoke();
}
