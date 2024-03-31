using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomApp
{
    public partial class GameModePage : ContentPage
    {
        public GameModePage()
        {
            InitializeComponent();
        }

        private async void OnUnlimitedModeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterNamePage(GameMode.Unlimited));
        }

        private async void OnTenCountriesModeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterNamePage(GameMode.TenCountries));
        }

        private async void OnTenCountriesThreeChancesModeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnterNamePage(GameMode.TenCountriesThreeChances));
        }
    }
    
    public enum GameMode
    {
        Unlimited,
        TenCountries,
        TenCountriesThreeChances
    }
}
