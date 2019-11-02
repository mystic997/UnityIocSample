using PropertyChanged;
using System;
using TreeListViewWithUnity.Core.Notifications;
using Unity;

namespace TreeListViewWithUnity.UI.Windows.BaseWindow
{
    public class BaseWindowViewModel : BasePropertyNotification, IWindowViewModel
    {
        [DoNotNotify]
        public IWindow Window { get; set; }
        [DoNotNotify]
        public IUnityContainer Container { get; set; }

        public BaseWindowViewModel(IWindow window, IUnityContainer container)
        {
            Container = container;
            Window = window;
            Window.DataContext = this;
        }

        public void ShowDialog<T>() where T : IWindow
        {
            bool? result = null;

            try
            {
                result = Window.ShowDialog();
                Window.Close();
            }
            catch (InvalidOperationException)
            {
                Window = Container.Resolve<T>();
                result = Window.ShowDialog();
                Window.Close();
            }
        }
    }
}
