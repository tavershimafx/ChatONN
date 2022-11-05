using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace ChatONN.Desktop.ValueConverters
{
    public class PathToImageConverter : BaseValueConverter<PathToImageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string abs = (string)value;
            if (!string.IsNullOrEmpty(abs))
            {
                Uri path = new ($"pack://application:,,,{abs}");
                BitmapImage image = new (path);

                return image;
            }

            return new BitmapImage(new Uri("pack://application:,,,/Resources/Images/user.png"));
        }
    }
}
