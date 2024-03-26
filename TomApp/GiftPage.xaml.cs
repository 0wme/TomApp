namespace TomApp;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
    }
    
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(100);
        imgLoader.IsAnimationPlaying = true;
    }

    async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}