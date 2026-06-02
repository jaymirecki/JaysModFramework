using System;
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
    private readonly NativeMenu _nativeMenu;
    private bool _suppressClosingEvent;

    public event Action BackPressed;

    public RphUIService()
    {
        _nativeMenu = new NativeMenu("JMF", "");
        _pool.Add(_nativeMenu);
        _nativeMenu.Closing += (sender, args) =>
        {
            if (_suppressClosingEvent) return;
            args.Cancel = true;
            BackPressed?.Invoke();
        };
    }

    public void Notify(string message) => Game.DisplayNotification(message);

    public int SelectedIndex => _nativeMenu.SelectedIndex;

    public void ShowMenu(Menu menu, int selectedIndex = 0, string bannerText = null)
    {
        _nativeMenu.BannerText.Text = bannerText ?? string.Empty;
        _nativeMenu.Name = menu.Title;
        _nativeMenu.Clear();

        foreach (var item in menu.Items)
        {
            if (item is IMenuListItem listItem)
            {
                var nativeListItem = new NativeListItem<string>(item.Title, item.Description, listItem.DisplayItems.ToArray());
                nativeListItem.Enabled = item.Enabled;
                nativeListItem.SelectedIndex = listItem.SelectedIndex;
                nativeListItem.ItemChanged += (sender, args) => listItem.RaiseItemChanged(args.Index);
                nativeListItem.Activated += (sender, args) => item.RaiseActivated();
                nativeListItem.Selected += (sender, args) => item.RaiseSelected();
                _nativeMenu.Add(nativeListItem);
            }
            else
            {
                var nativeItem = new NativeItem(item.Title, item.Description);
                nativeItem.Enabled = item.Enabled;
                nativeItem.Activated += (sender, args) => item.RaiseActivated();
                nativeItem.Selected += (sender, args) => item.RaiseSelected();
                _nativeMenu.Add(nativeItem);
            }
        }

        _nativeMenu.SelectedIndex = Math.Max(0, Math.Min(selectedIndex, menu.Items.Count - 1));
        _nativeMenu.Visible = true;
    }

    public void HideMenu()
    {
        _suppressClosingEvent = true;
        _nativeMenu.Visible = false;
        _suppressClosingEvent = false;
    }

    public void ProcessFrame() => _pool.Process();

    public void SuppressNativeMenu()
    {
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 0, (int)GameControl.CharacterWheel, true);
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 1, (int)GameControl.CharacterWheel, true);
        NativeFunction.CallByHash<int>(0xFE99B66D079CF6BC, 2, (int)GameControl.CharacterWheel, true);
    }


}
