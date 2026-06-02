using System.Collections.Generic;

namespace JaysModFramework.Core.UI;

/// <summary>Non-generic bridge used by the native UI layer to render a typed list item.</summary>
internal interface IMenuListItem
{
    int SelectedIndex { get; }
    List<string> DisplayItems { get; }
    void RaiseItemChanged(int index);
}
