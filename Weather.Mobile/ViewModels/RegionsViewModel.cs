using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Weather.Mobile.Pages;
using Weather.Mobile.Resources.Localization;
using Weather.Mobile.ViewModels.Regions;

namespace Weather.Mobile.ViewModels
{
    public partial class RegionsViewModel : ObservableObject
    {
        public ObservableCollection<RegionItem> Regions { get; set; } = new ObservableCollection<RegionItem>();

        public RegionsViewModel()
        {

            Regions.Add(new RegionItem { Name = "Slovenija", URL = "https://meteo.arso.gov.si/uploads/probase/www/fproduct/text/sl/fcast_SLOVENIA_latest.xml", IsCountry=true });

            Regions.Add(new RegionItem { Name = "Bovška", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_BOVSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Dolenjska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_DOLENJSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Gorenjska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_GORENJSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Goriska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_GORISKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Kočevska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_KOCEVSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Koroška", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_KOROSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Notranjsko kraška", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_NOTRANJSKO-KRASKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Obalno kraška", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_OBALNO-KRASKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Osrednjeslovenska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_OSREDNJESLOVENSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Podravska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_PODRAVSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Pomurska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_POMURSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Savinjska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_SAVINJSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Spodnjeposavska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_SPODNJEPOSAVSKA_latest.xml" });
            Regions.Add(new RegionItem { Name = "Zgornjesavska", URL = "https://www.meteo.si/uploads/probase/www/fproduct/text/sl/forecast_SI_ZGORNJESAVSKA_latest.xml" });
        }

        [RelayCommand]
        private async Task OpenForecastPage(string URL)
        {
            var selectedRegion = Regions.First(a => a.URL.Equals(URL, StringComparison.OrdinalIgnoreCase));

            try
            {
                if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                {
                    await Application.Current.MainPage.DisplayAlert(PageStrings.appTitle, PageStrings.noNetwork, PageStrings.ok);
                    return;
                }

                selectedRegion.IsOpenInProgress = true;

                await Application.Current.MainPage.Navigation.PushAsync(new ForecastPage(URL));
            }
            finally
            {
                selectedRegion.IsOpenInProgress = false;
            }
        }

    }
}
