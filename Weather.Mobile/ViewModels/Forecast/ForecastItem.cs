using CommunityToolkit.Mvvm.ComponentModel;
using Weather.Mobile.ViewModels;
using Weather.Mobile.API.OutputData;

namespace Weather.Mobile.ViewModels.Forecast
{
    public partial class ForecastItem : ObservableObject
    {
        [ObservableProperty]
        private string _day;

        [ObservableProperty]
        private string _skyVisibility;

        [ObservableProperty]
        private string _weatherPhenomenon;

        [ObservableProperty]
        private string _minimumTemperature;

        [ObservableProperty]
        private string _maximumTemperature;

        [ObservableProperty]
        private string _windDirection;

        [ObservableProperty]
        private string _windSpeedMinimum;

        [ObservableProperty]
        private string _windSpeedMaximum;

    }
}
