namespace TomApp;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}
	
	public async void OnPlayButtonClicked(object sender, EventArgs e)
	{
	    await Navigation.PushAsync(new GamePage());
	}
}
