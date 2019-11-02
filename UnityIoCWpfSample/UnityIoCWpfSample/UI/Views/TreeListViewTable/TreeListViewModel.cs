using TreeListViewWithUnity.UI.Views.BaseView;
using Unity;

namespace UnityIoCWpfSample.UI.Views.TreeListViewTable
{
    public class TreeListViewModel : BaseViewModel, ITreeListViewModel
    {
        public TreeListViewModel(ITreeListView view, IUnityContainer container) 
            : base(view, container)
        {
        }
    }
}
