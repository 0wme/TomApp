using Microsoft.Maui.Controls;

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
            var country = (Country)e.CurrentSelection.FirstOrDefault();
            if (country != null)
            {
                await Navigation.PushAsync(new CountryDetailsPage(country));
            }
        }
    }
}