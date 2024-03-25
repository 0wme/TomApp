namespace TomApp;

public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }

    async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GifPage());
    }
}