using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace TomApp
{
    public partial class GamePage : ContentPage
    {
        private ApiService _apiService;
        private List<Country> _countries;
        private Country _currentCountry;

        public GamePage()
        {
            InitializeComponent();
            _apiService = new ApiService();
            LoadCountry();
        }

        private async void LoadCountry()
        {
            _countries = await _apiService.GetCountriesAsync();
            _currentCountry = _countries[new Random().Next(_countries.Count)];
            FlagImage.Source = _currentCountry.Media.Flag;
        }

        private void OnCheckButtonClicked(object sender, EventArgs e)
        {
            if (CountryNameEntry.Text == _currentCountry.Name)
            {
                ResultLabel.Text = "Bonne réponse!";
                LoadCountry();
            }
            else
            {
                ResultLabel.Text = "Mauvaise réponse!";
            }
        }
    }
}