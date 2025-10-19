using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities;

internal class Individual : AbstractClient
{
    private AbstractClient _client;

    public string Cpf { get; init; }

    public Individual(int id, string name, string surname, DateTime birthDate, Adress adress, ClientType clientType, string cpf) 
        : base(id, name, surname, birthDate, adress, clientType)
    {
        Cpf = cpf;
    }


    public override string ToString()
    {
        return base.ToString() + $"CPF: {Cpf}";
    }
}
