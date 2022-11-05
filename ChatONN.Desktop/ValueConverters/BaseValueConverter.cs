using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace ChatONN.Desktop.ValueConverters
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter where T : class, new()
    {
        private T mValue;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return mValue ?? new T();
        }

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new object();
        }
    }
}
