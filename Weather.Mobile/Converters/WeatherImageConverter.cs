using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Mobile.Global;

namespace Weather.Mobile.Converters
{
    public class WeatherImageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length == 0 || values.All(v => v == null))
                return null;

            var skyVisibility = values[0] == null ? string.Empty : values[0].ToString();
            var weatherPhenomenon = values[1] == null ? string.Empty : values[1].ToString();

            var actualWeather = string.IsNullOrWhiteSpace(weatherPhenomenon) ? skyVisibility : weatherPhenomenon;

            if (GlobalData.WeatherImages.TryGetValue(actualWeather, out var weatherImage))
                return weatherImage;

            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
