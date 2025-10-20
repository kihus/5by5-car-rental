using LocadoraCarros.Models;

namespace LocadoraCarros.Abstract;

internal abstract class AbstractPerson
{
    private string _name { get; set; }
    private DateOnly _birthDate { get; set; }
    private Contact _contact { get; set; }
    private Address _adress { get; set; }

    public AbstractPerson(string name, DateOnly birthDate, Contact contact, Address adress)
    {
        _name = name;
        _birthDate = birthDate;
        _contact = contact;
        _adress = adress;
    }

    public void SetContactPhone(string phone)
    {
        _contact.SetPhone(phone);
    }
    public string GetName()
    {
        return _name;
    }

    public override string ToString()
    {
        return
            $"Name: {_name}\n" +
            $"Birth date: {_birthDate}\n" +
            $"Contact: {_contact}\n" +
            $"Adress: {_adress}";
    }
}
