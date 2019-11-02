using PropertyChanged;
using TreeListViewWithUnity.Core.Notifications;
using Unity;

namespace TreeListViewWithUnity.UI.Views.BaseView
{
    public class BaseViewModel : BasePropertyNotification, IViewModel
    {
        [DoNotNotify]
        public IView View { get; set; }
        [DoNotNotify]
        public IUnityContainer Container { get; set; }

        public BaseViewModel(IView view, IUnityContainer container)
        {
            Container = container;
            View = view;
            View.DataContext = this;
        }

        public void RefreshView<T>() where T : IView
        {
            View = Container.Resolve<T>();
        }
    }
}
