namespace LocadoraCarros.Entities.Base;

public class AbstractAdress(string street, int number, string neighborhood, string city, string country)
{
    public string Street { get; private set; } = street;
    public int Number { get; private set; } = number;
    public string? Complement { get; private set; } = null;
    public string Neighborhood { get; private set; } = neighborhood;
    public string City { get; private set; } = city;
    public string Country { get; private set; } = country;


    public AbstractAdress(string street, int number, string neighborhood, string city, string country, string complement)
        : this (street, number, neighborhood, city, country)
    {
        Complement = complement;
    }

    public override string ToString()
    {
        return $"\n" +
            $"Adress\n" +
            $"Street: {Street}\n" +
            $"Number: {Number}\n" +
            $"{(Complement is null ? "" : $"Complement: {Complement}\n")}" +
            $"Neighborhood: {Neighborhood}\n" +
            $"City: {City}\n" +
            $"Country: {Country}\n";
    }
}