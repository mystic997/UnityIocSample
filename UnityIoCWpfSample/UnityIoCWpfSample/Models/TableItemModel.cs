using System.Collections.ObjectModel;

namespace UnityIoCWpfSample.Models
{
    public class TableItemModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public bool IsEnabled { get; set; }
        //public ObservableCollection<TableItemModel> Child { get; set; }
    }
}
