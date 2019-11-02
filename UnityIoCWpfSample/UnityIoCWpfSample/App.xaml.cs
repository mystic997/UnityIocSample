using System;
using System.Diagnostics;
using System.Windows;
using TreeListViewWithUnity.Core.ContainerBootstrapper;
using TreeListViewWithUnity.UI.Windows.MainWindow;
using Unity;

namespace UnityIoCWpfSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container = UnityContainerBootstrapper.Initialise();

            var mainWindowViewModel = _container.Resolve<IMainWindowViewModel>();
            MainWindow window = new MainWindow { DataContext = mainWindowViewModel };

            try
            {
                window.Show();
            }
            catch (Exception)
            {
                Debug.WriteLine("Fatal error");
            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            UnityContainerBootstrapper.Dispose();
        }
    }
}
