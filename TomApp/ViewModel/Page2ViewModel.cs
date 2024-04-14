using System.Collections.ObjectModel;
using Microsoft.Maui.Dispatching;
using System.Threading.Tasks;

public class Page2ViewModel
{
    private ApiService _apiService = new ApiService();
    public ObservableCollection<Country> Countries { get; private set; } = new ObservableCollection<Country>();

    public Page2ViewModel()
    {
        LoadCountries();
    }

    private async void LoadCountries()
    {
        var countries = await _apiService.GetCountriesAsync();
        var dispatcher = Dispatcher.GetForCurrentThread();
        if (dispatcher != null && countries != null)
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