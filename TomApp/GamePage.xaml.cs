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
        private GameMode _gameMode;
        private int _guessCount;
        private int _correctGuessCount;

        public GamePage(GameMode gameMode)
        {
            InitializeComponent();
            _apiService = new ApiService();
            _gameMode = gameMode;
            _guessCount = 0;
            _correctGuessCount = 0;
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
            _guessCount++;
            if (CountryNameEntry.Text == _currentCountry.Name)
            {
                _correctGuessCount++;
                ResultLabel.Text = "Bonne réponse!";
                if (_gameMode == GameMode.Unlimited || (_gameMode != GameMode.Unlimited && _guessCount < 10))
                {
                    LoadCountry();
                }
                else
                {
                    ResultLabel.Text += $" Vous avez trouvé {_correctGuessCount} pays sur 10.";
                }
            }
            else
            {
                ResultLabel.Text = "Mauvaise réponse!";
                if (_gameMode == GameMode.TenCountriesThreeChances && _guessCount - _correctGuessCount >= 3)
                {
                    ResultLabel.Text += " Vous avez perdu vos 3 chances. Le jeu est terminé.";
                }
                else if (_gameMode != GameMode.Unlimited && _guessCount < 10)
                {
                    LoadCountry();
                }
                else
                {
                    ResultLabel.Text += $" Vous avez trouvé {_correctGuessCount} pays sur 10.";
                }
            }
        }
    }
}