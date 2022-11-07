using System;
using System.Globalization;
using System.Windows;

namespace ChatONN.Desktop.ValueConverters
{
    public class StringToVisibilityConverter : BaseValueConverter<StringToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text && !string.IsNullOrEmpty(text))
                return Visibility.Visible;
            else
                return Visibility.Collapsed;
        }
    }
}
