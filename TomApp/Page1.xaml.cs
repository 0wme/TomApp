namespace TomApp;

public partial class Page1 : ContentPage
{
    List<string> images = new List<string>
    {
        "imgcarrousel1.jpeg",
        "imgcarrousel2.jpeg",
        "imgcarrousel3.jpeg",
    };

    public Page1()
    {
        InitializeComponent();
        CarouselImages.ItemsSource = images;

        Device.StartTimer(TimeSpan.FromSeconds(2), () =>
        {
            var next = (CarouselImages.Position + 1) % images.Count;
            CarouselImages.ScrollTo(next);
            return true;
        });
    }


    async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GifPage());
    }
}