using LocadoraCarros.Models;

namespace LocadoraCarros.Abstract;

internal abstract class Person
{
    private string _name { get; set; }
    private DateOnly _birthDate { get; set; }
    private Contact _contact { get; set; }
    private Adress _adress { get; set; }

    public Person(string name, DateOnly birthDate, Contact contact, Adress adress)
    {
        _name = name;
        _birthDate = birthDate;
        _contact = contact;
        _adress = adress;
    }

    public string GetName()
    {
        return _name;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Birth date: {_birthDate}, Contact: {_contact}, Adress: {_adress}";
    }
}
