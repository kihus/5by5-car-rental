using LocadoraCarros.Models;

namespace LocadoraCarros.Abstract;

internal abstract class Person
{
    public string Name { get; private set; }
    public DateTime BirthDate { get; private set; }
    public Contact Contact { get; private set; }
    public Adress Adress { get; private set; }
}
