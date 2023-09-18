using Weather.Mobile.ViewModels;

namespace Weather.Mobile.Pages;

public partial class ForecastPage : ContentPage
{
    private ForecastViewModel _viewModel;

    public ForecastPage(string URL)
	{
		InitializeComponent();

        _viewModel = new ForecastViewModel
        {
            URL = URL
        };

        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        _viewModel.FillForecast();
    }
}