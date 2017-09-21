using System;
using System.Globalization;
using Xamarin.Forms;

namespace SprintZero.ValueConverters
{
    public class BooleanoAString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(bool))
                return "is not a valid value";

            return (bool)value ? "the library is supported" : "the library is not supported";
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
