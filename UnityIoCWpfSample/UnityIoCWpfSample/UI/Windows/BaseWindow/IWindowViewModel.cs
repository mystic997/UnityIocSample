namespace TreeListViewWithUnity.UI.Windows.BaseWindow
{
    public interface IWindowViewModel
    {
        IWindow Window { get; set; }
        void ShowDialog<T>() where T : IWindow;
    }
}
