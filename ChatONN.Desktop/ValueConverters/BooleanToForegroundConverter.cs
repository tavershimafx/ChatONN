using System;
using System.Globalization;
using System.Windows;

namespace ChatONN.Desktop.ValueConverters
{
    public class BooleanToForegroundConverter : BaseValueConverter<BooleanToForegroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null)
            {
                if ((bool)value)
                    return Application.Current.FindResource("WhiteBrush");
                else
                    return Application.Current.FindResource("DarkBrush");
            }
            else // inverse
            {
                if ((bool)value)
                    return Application.Current.FindResource("DarkBrush");
                else
                    return Application.Current.FindResource("WhiteBrush");
            }
        }
    }
}
