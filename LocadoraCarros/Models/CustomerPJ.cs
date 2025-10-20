using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class CustomerPJ(
    string name, 
    DateOnly birthDate, 
    Contact contact, 
    Adress adress, 
    string cnpj
    ) 
    : AbstractPerson(
        name, 
        birthDate, 
        contact, 
        adress
        )
{

    private Guid _id { get; set; } = Guid.NewGuid();
    private string _cnpj { get; set; } = cnpj;
}
