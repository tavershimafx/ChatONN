using System;
using System.Globalization;
using System.Windows;

namespace ChatONN.Desktop.ValueConverters
{
    public class IsSelectedToBackgroundConverter : BaseValueConverter<IsSelectedToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return Application.Current.FindResource("DarkBrush");
            }
            else
            {
                return Application.Current.FindResource("WhiteBrush");
            }
        }
    }
}
