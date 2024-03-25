namespace TomApp;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
    }

    async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}