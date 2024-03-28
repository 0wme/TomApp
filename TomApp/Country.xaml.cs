
public class Country
{
    public string Abbreviation { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public int Population { get; set; }
    public Media Media { get; set; }
    public int Id { get; set; }
}

public class Media
{
    public string Flag { get; set; }
    public string Emblem { get; set; }
    public string Orthographic { get; set; }
}