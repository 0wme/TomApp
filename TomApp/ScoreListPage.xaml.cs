using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace TomApp
{
    public partial class ScoreListPage : ContentPage
    {
        public ScoreListPage(GameMode gameMode)
        {
            InitializeComponent();
            ScoreListView.ItemsSource = ScoreHistory.GetScores(gameMode);
        }
    }
}