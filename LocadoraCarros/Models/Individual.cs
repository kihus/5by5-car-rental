using LocadoraCarros.Models.Abstractions;
using LocadoraCarros.Models.Enums;

namespace LocadoraCarros.Models;

internal class Individual : AbstractClient
{

    public string Cpf { get; init; }

    public Individual(int id, string name, string surname, DateTime birthDate, Adress adress, EClientType clientType, string cpf) 
        : base(id, name, surname, birthDate, adress, clientType)
    {
        Cpf = cpf;
    }

    public override string ToString()
    {
        return base.ToString() + $"CPF: {Cpf}\n{Adress}";
    }
}
