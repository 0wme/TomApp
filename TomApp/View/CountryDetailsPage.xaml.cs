// CountryDetailsPage.xaml.cs
using Microsoft.Maui.Controls;

namespace TomApp
{
    public partial class CountryDetailsPage : ContentPage
    {
        public CountryDetailsPage(Country country)
        {
            InitializeComponent();
            BindingContext = new CountryViewModel(country);
        }
    }
}