using System;
using System.Globalization;
using Xamarin.Forms;
using static System.Math;

namespace ListView.Converter
{
    public class DoubleToIntConverter:IValueConverter
    {
        public DoubleToIntConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is decimal){
                return Decimal.ToInt32(Round((Decimal)value));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
