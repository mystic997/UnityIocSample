namespace TreeListViewWithUnity.UI.Windows.BaseWindow
{
    public interface IWindow
    {
        object DataContext { get; set; }
        bool? ShowDialog();
        void Close();
    }
}
