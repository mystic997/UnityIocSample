using TreeListViewWithUnity.UI.Views.BaseView;
using Unity;
using UnityIoCWpfSample.Models;
using UnityIoCWpfSample.UI.Views.TreeListViewTable.CustomControls;

namespace UnityIoCWpfSample.UI.Views.TreeListViewTable
{
    public class TreeListViewModel : BaseViewModel, ITreeListViewModel
    {
        public CustomControls.TreeListView MyTree { get; set; }

        public TreeListViewModel(ITreeListView view, IUnityContainer container)
            : base(view, container)
        {
            MyTree = new CustomControls.TreeListView();

            TreeListViewItem item1 = new TreeListViewItem()
            {
                Header = new TableItemModel()
                {
                    Title = "Title 1",
                    Text = "Description 1",
                    IsEnabled = true
                }
            };
                TreeListViewItem item1_1 = new TreeListViewItem()
                {
                    Header = new TableItemModel()
                    {
                        Title = "Title 1.1",
                        Text = "Description 1.1",
                        IsEnabled = false
                    }
                };
                    TreeListViewItem item1_1_1 = new TreeListViewItem()
                    {
                        Header = new TableItemModel()
                        {
                            Title = "Title 1.1.1",
                            Text = "Description 1.1.1",
                            IsEnabled = false
                        }
                    };
                    TreeListViewItem item1_1_2 = new TreeListViewItem()
                    {
                        Header = new TableItemModel()
                        {
                            Title = "Title 1.1.2",
                            Text = "Description 1.1.2",
                            IsEnabled = true
                        }
                    };
                TreeListViewItem item1_2 = new TreeListViewItem()
                {
                    Header = new TableItemModel()
                    {
                        Title = "Title 1.2",
                        Text = "Description 1.2",
                        IsEnabled = true
                    }
                };
            TreeListViewItem item2 = new TreeListViewItem()
            {
                Header = new TableItemModel()
                {
                    Title = "Title 2",
                    Text = "Description 2",
                    IsEnabled = false
                }
            };
            TreeListViewItem item3 = new TreeListViewItem()
            {
                Header = new TableItemModel()
                {
                    Title = "Title 3",
                    Text = "Description 3",
                    IsEnabled = true
                }
            };

            item1_1.Items.Add(item1_1_1);
            item1_1.Items.Add(item1_1_2);

            item1.Items.Add(item1_1);
            item1.Items.Add(item1_2);

            MyTree.Items.Add(item1);
            MyTree.Items.Add(item2);
            MyTree.Items.Add(item3);
        }
    }
}
