using LocadoraCarros.Abstract;


namespace LocadoraCarros.Models;

internal class CustomerPF(
    string name,
    DateOnly birthDate,
    Contact contact,
    Address adress,
    string cnh,
    string cpf
    )
    : AbstractPerson(
        name,
        birthDate,
        contact,
        adress
        )
{
    private Guid _id { get; set; } = Guid.NewGuid();
    private string _cnh { get; set; } = cnh;
    private string _cpf { get; set; } = cpf;

    

    public override string ToString()
    {
        return $"{base.ToString()}\n" +
            $"CNH: {_cnh}\n" +
            $"CPF: {_cpf}\n";
    }
}