using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;
using LocadoraCarros.Entities.Models;

namespace LocadoraCarros.Entities;

internal class Individual : AbstractClient
{

    public string Cpf { get; init; }

    public Individual(int id, string name, string surname, DateTime birthDate, Adress adress, ClientType clientType, string cpf) 
        : base(id, name, surname, birthDate, adress, clientType)
    {
        Cpf = cpf;
    }

    public override string ToString()
    {
        return base.ToString() + $"CPF: {Cpf}\n{Adress}";
    }
}
