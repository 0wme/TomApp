using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomApp;

public partial class EnterNamePage : ContentPage
{
    private GameMode _gameMode;

    public EnterNamePage(GameMode gameMode)
    {
        InitializeComponent();
        _gameMode = gameMode;
    }

    private async void OnStartGameButtonClicked(object sender, EventArgs e)
    {
        var userName = NameEntry.Text;
        await Navigation.PushAsync(new GamePage(_gameMode, userName));
    }
}