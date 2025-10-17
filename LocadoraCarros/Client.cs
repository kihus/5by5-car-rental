namespace LocadoraCarros;

abstract class Client(int id, string name, string surname, DateTime birthDate, Adress adress)
{
    public int Id { get; init; } = id;
    public string Name { get; private set; } = name;
    public string Surname { get; private set; } = surname;
    public DateTime BirthDate { get; init; } = birthDate;
    public Adress Adress { get; private set; } = adress;

    public override string ToString()
    {
        return $"\n" +
            $"Client\n" +
            $"Name: {Name}\n" +
            $"Surname: {Surname}\n" +
            $"Birth Date: {BirthDate}\n" +
            $"{Adress}";
    }
}
