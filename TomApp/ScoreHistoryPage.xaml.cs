using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomApp;

public partial class ScoreHistoryPage : ContentPage
{
    public ScoreHistoryPage()
    {
        InitializeComponent();
    }

    private async void OnShowUnlimitedGameHistoryButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ScoreListPage(GameMode.Unlimited));
    }

    private async void OnShowTenCountriesGameHistoryButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ScoreListPage(GameMode.TenCountries));
    }

    private async void OnShowTenCountriesThreeChancesGameHistoryButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ScoreListPage(GameMode.TenCountriesThreeChances));
    }
}