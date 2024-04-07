using System.Collections.ObjectModel;
using Microsoft.Maui.Dispatching;

using System.Collections.ObjectModel;
using Microsoft.Maui.Dispatching;
using Microsoft.Maui.Controls;
using TomApp;

public class Page2ViewModel
{
    private readonly ApiService _apiService;
    public ObservableCollection<Country> Countries { get; }

    public Page2ViewModel()
    {
        _apiService = new ApiService();
        Countries = new ObservableCollection<Country>();
        LoadCountries();

        MessagingCenter.Subscribe<Page3, Country>(this, "AddCountry", (sender, country) =>
        {
            var dispatcher = Dispatcher.GetForCurrentThread();
            if (dispatcher != null)
            {
                dispatcher.Dispatch(() =>
                {
                    Countries.Add(country);
                });
            }
        });
    }

    private async void LoadCountries()
    {
        var countries = await _apiService.GetCountriesAsync();
        if (countries != null)
        {
            var dispatcher = Dispatcher.GetForCurrentThread();
            if (dispatcher != null)
            {
                dispatcher.Dispatch(() =>
                {
                    foreach (var country in countries)
                    {
                        Countries.Add(country);
                    }
                });
            }
        }
    }
}