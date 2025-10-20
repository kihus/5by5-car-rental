namespace LocadoraCarros.Models;

public class Adress(string street, int number, string neighborhood, string zipCode, string city, string state, string country)
{
    public string Street { get; private set; } = street;
    public int Number { get; private set; } = number;
    public string? Complement { get; private set; } = null;
    public string Neighborhood { get; private set; } = neighborhood;
    public string ZipCode { get; private set; } = zipCode;
    public string City { get; private set; } = city;
    public string State { get; private set; } = state;
    public string Country { get; private set; } = country;


    public Adress(string street, int number, string neighborhood, string zipCode,
                  string city,  string state, string country, string complement)
                 : this(street, number, neighborhood, zipCode, city, state, country)
    {
        Complement = complement;
    }

    public override string ToString()
    {

        return $"\n[Adress]\n" +
            $"Street: {Street}\n" +
            $"Number: {Number}\n" +
            $"{(Complement is null ? "" : $"Complement: {Complement}\n")}" +
            $"Neighborhood: {Neighborhood}\n" +
            $"City: {City}\n" +
            $"State: {State}\n" +
            $"Country: {Country}\n";
    }
}