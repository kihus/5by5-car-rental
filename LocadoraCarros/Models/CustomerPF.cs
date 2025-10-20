using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class CustomerPF(
    string name,
    DateOnly birthDate,
    Contact contact,
    Adress adress,
    string cnh,
    string cpf
    )
    : Person(
        name,
        birthDate,
        contact,
        adress
        )
{
    private Guid _id { get; set; } = Guid.NewGuid();
    private string _cnh { get; set; } = cnh;
    private string _cpf { get; set; } = cpf;


}