using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class CustomerPJ(
    string name, 
    DateOnly birthDate, 
    Contact contact, 
    Address adress, 
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

    public override string ToString()
    {
        return $"Id: {_id}\n" +
            $"{base.ToString()}\n" +
            $"CNPJ: {_cnpj}";
    }
}
