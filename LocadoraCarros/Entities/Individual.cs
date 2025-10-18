using LocadoraCarros.Entities.Base;

namespace LocadoraCarros.Entities;

internal class Individual : AbstractClient
{
    public string Cpf { get; private set; }
    public Individual(int id, string name, string surname, DateTime birthDate, AbstractAdress adress, string cpf) 
        : base(id, name, surname, birthDate, adress)
    {
        Cpf = cpf;
    }

    public override string ToString()
    {
        return base.ToString() + $"CPF: {Cpf}";
    }
}
