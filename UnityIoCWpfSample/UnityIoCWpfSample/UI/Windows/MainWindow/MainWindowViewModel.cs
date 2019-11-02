using TreeListViewWithUnity.UI.Windows.BaseWindow;
using Unity;

namespace TreeListViewWithUnity.UI.Windows.MainWindow
{
    public class MainWindowViewModel : BaseWindowViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IMainWindow window, IUnityContainer container)
            : base(window, container)
        {
        }
    }
}
