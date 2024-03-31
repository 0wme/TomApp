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

    private void OnShowUnlimitedGameHistoryButtonClicked(object sender, EventArgs e)
    {
        ScoreListView.ItemsSource = ScoreHistory.GetScores(GameMode.Unlimited);
    }

    private void OnShowTenCountriesGameHistoryButtonClicked(object sender, EventArgs e)
    {
        ScoreListView.ItemsSource = ScoreHistory.GetScores(GameMode.TenCountries);
    }

    private void OnShowTenCountriesThreeChancesGameHistoryButtonClicked(object sender, EventArgs e)
    {
        ScoreListView.ItemsSource = ScoreHistory.GetScores(GameMode.TenCountriesThreeChances);
    }
}