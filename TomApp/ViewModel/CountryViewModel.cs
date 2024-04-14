using System;

public class CountryViewModel
{
    public Country Country { get; private set; }
    public string Name => Country.Name;
    public string Capital => Country.Capital;
    public string Currency => Country.Currency;
    public string Abbreviation => Country.Abbreviation;
    public string Phone => Country.Phone;
    public int Population => Country.Population;
    public int Id => Country.Id;
    public bool IsManuallyAdded => Country.IsManuallyAdded;
    
    public string FlagImage => Country.Media?.Flag;

    public CountryViewModel(Country country)
    {
        Country = country ?? throw new ArgumentNullException(nameof(country), "Un objet Country est requis pour initialiser CountryViewModel");
    }
}