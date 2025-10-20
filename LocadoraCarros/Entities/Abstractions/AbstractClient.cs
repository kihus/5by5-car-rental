using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities.Base;

abstract class AbstractClient(int id, string name, string surname, DateTime birthDate, Adress adress, ClientType clientType)
{
    public int Id { get; init; } = id;
    public string Name { get; private set; } = name;
    public string Surname { get; private set; } = surname;
    public DateTime BirthDate { get; init; } = birthDate;
    public Adress Adress { get; private set; } = adress;
    public ClientType ClientType{ get; private set; } = clientType;
    

    public override string ToString()
    {
        return $"\n" +
            $"[Client]\n\r" +
            $"Id: {Id}\n\r" +
            $"Name: {Name}\n\r" +
            $"Surname: {Surname}\n\r" +
            $"Birth Date: {BirthDate:d}\n\r";
    }
}
