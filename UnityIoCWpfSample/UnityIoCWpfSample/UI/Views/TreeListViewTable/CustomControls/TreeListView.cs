using System.Windows;
using System.Windows.Controls;

namespace UnityIoCWpfSample.UI.Views.TreeListViewTable.CustomControls
{
    public class TreeListView : TreeView
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeListViewItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeListViewItem;
        }
    }
}
