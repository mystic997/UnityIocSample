using TreeListViewWithUnity.UI.Windows.BaseWindow;
using Unity;
using UnityIoCWpfSample.UI.Views.TreeListViewTable;

namespace TreeListViewWithUnity.UI.Windows.MainWindow
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public ITreeListViewModel TreeListViewModel { get; set; }

        public MainWindowViewModel(IMainWindow window, IUnityContainer container,
                                   ITreeListViewModel treeListViewModel)
            : base(window, container)
        {
            TreeListViewModel = treeListViewModel;
        }
    }
}
