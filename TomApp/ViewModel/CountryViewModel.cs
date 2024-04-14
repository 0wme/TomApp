using Microsoft.Maui.Controls;

public class CountryViewModel
{
    public Country Country { get; private set; }

    public CountryViewModel(Country country)
    {
        Country = country;
    }
}