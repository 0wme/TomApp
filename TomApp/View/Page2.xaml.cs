using Microsoft.Maui.Controls;
using System.Linq;

namespace TomApp
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            BindingContext = new Page2ViewModel();
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var country = e.CurrentSelection.FirstOrDefault() as Country;
            if (country != null)
            {
                await Navigation.PushAsync(new CountryDetailsPage(country));
            }
        }

    }
}