using CommunityToolkit.Mvvm.ComponentModel;
using Weather.Mobile.Services;
using Weather.Mobile.API.OutputData;
using Weather.Mobile.ViewModels.Forecast;
using System.Collections.ObjectModel;

namespace Weather.Mobile.ViewModels
{
    public partial class ForecastViewModel : ObservableObject
    {
        public ObservableCollection<ForecastItem> Days { get; set; } = new ObservableCollection<ForecastItem>();

        [ObservableProperty]
        public string _URL;

        [ObservableProperty]
        public bool _isObtainingDataInProgress;

        public async void FillForecast()
        {
            try
            {
                IsObtainingDataInProgress = true;

                var httpService = new HttpService();
                var weatherApiData = await httpService.ExecuteRequest(URL, "GET");

                var xmlService = new XmlService();
                var forecastData = xmlService.CreateObjectFromXml<ForecastData>(weatherApiData);

                foreach (var day in forecastData.Days)
                {

                    var forecastItem = new ForecastItem
                    {
                        Day = day.Day.Remove(day.Day.IndexOf(" ")).Trim() + ", " + day.Date.Remove(day.Date.IndexOf(" ")).Trim(),
                        SkyVisibility = day.SkyVisibility,
                        WeatherPhenomenon = day.WeatherPhenomenon,
                        MinimumTemperature = (day.MinimumTemperature ?? day.MinimumTemperatureCountry) + " °C",
                        MaximumTemperature = (day.MaximumTemperature ?? day.MaximumTemperatureCountry) + " °C",
                        WindDirection = day.WindDirection,
                        WindSpeedMinimum = day.WindSpeedMinimum + " m/s",
                        WindSpeedMaximum = day.WindSpeedMaximum + " m/s"
                    };

                    Days.Add(forecastItem);
                }
            }
            finally
            {
                IsObtainingDataInProgress = false;
            }
        }
    }
}
