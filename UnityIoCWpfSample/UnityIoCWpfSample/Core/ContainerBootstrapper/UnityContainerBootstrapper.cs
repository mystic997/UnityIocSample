using TreeListViewWithUnity.UI.UICore.DelegateCommands;
using TreeListViewWithUnity.UI.Windows.MainWindow;
using Unity;

namespace TreeListViewWithUnity.Core.ContainerBootstrapper
{
    internal static class UnityContainerBootstrapper
    {
        private static IUnityContainer _unityContainer;

        internal static IUnityContainer Initialise()
        {
            _unityContainer = new UnityContainer();

            _unityContainer = InitialiseWindows(_unityContainer);
            _unityContainer = InitialiseViews(_unityContainer);
            _unityContainer = InitialiseServices(_unityContainer);
            _unityContainer = InitialiseFacades(_unityContainer);
            _unityContainer = InitialiseFactories(_unityContainer);
            _unityContainer = InitialiseConverters(_unityContainer);

            return _unityContainer;
        }

        internal static void Dispose()
        {
            _unityContainer.Dispose();
        }

        private static IUnityContainer InitialiseWindows(IUnityContainer container)
        {
            container.RegisterType<IMainWindow, MainWindow>();
            container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();

            return container;
        }

        private static IUnityContainer InitialiseViews(IUnityContainer container)
        {
            return container;
        }

        private static IUnityContainer InitialiseServices(IUnityContainer container)
        {
            return container;
        }

        private static IUnityContainer InitialiseFacades(IUnityContainer container)
        {
            return container;
        }

        private static IUnityContainer InitialiseFactories(IUnityContainer container)
        {
            container.RegisterType<ICommandFactory, CommandFactory>();

            return container;
        }

        private static IUnityContainer InitialiseConverters(IUnityContainer container)
        {
            return container;
        }
    }
}
