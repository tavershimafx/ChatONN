using System;
using System.Globalization;
using System.Windows;

namespace ChatONN.Desktop.ValueConverters
{
    public class IsSentByMeToBackgroundConverter : BaseValueConverter<IsSentByMeToBackgroundConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return Application.Current.FindResource("PurpleGradientBrush");
            }
            else
            {
                return Application.Current.FindResource("GreyBrush");
            }
        }
    }
}
