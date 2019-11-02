using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace UnityIoCWpfSample.UI.Views.TreeListViewTable.CustomConverters
{
    public class LevelToIndentConverter : IValueConverter
    {
        private const double INDENT_SIZE = 8.0;

        public object Convert(object o, Type type, object parameter, CultureInfo culture)
        {
            return new Thickness((int)o * INDENT_SIZE, 0, 0, 0);
        }

        public object ConvertBack(object o, Type type, object parameter, CultureInfo culture)
        {
            return new Thickness((int)o / INDENT_SIZE, 0, 0, 0);
        }
    }
}
