using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using Microsoft.Maui.Dispatching;
using System.Threading.Tasks;
using TomApp;

public class Page2ViewModel
{
    private ApiService _apiService = new ApiService();
    public ObservableCollection<Country> Countries { get; private set; } = new ObservableCollection<Country>();

    public Page2ViewModel()
    {
        LoadCountries();

        MessagingCenter.Subscribe<Page3, Country>(this, "AddCountry", (sender, country) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Countries.Add(country);
            });
        });
    }

    private async void LoadCountries()
    {
        var countries = await _apiService.GetCountriesAsync();
        if (countries != null)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                foreach (var country in countries)
                {
                    Countries.Add(country);
                }
            });
        }
    }
}