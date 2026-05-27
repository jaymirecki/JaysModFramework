using System;

namespace JaysModFramework.Core.UI;

public class MenuItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Enabled { get; set; } = true;
    internal Menu LinkedSubmenu { get; set; }

    public event Action OnActivated;
    public event Action OnSelected;

    internal void RaiseActivated() { if (Enabled) OnActivated?.Invoke(); }
    internal void RaiseSelected() { if (Enabled) OnSelected?.Invoke(); }
}
