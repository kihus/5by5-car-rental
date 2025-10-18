using LocadoraCarros.Entities.Base;

namespace LocadoraCarros.Entities;

internal class LegalEntity : AbstractClient
{
    public string Cnpj { get; private set; }

    public LegalEntity(int id, string name, string surname, DateTime birthDate, AbstractAdress adress, string cnpj) 
        : base(id, name, surname, birthDate, adress)
    {
        Cnpj = cnpj;
    }

    public override string ToString()
    {
        return base.ToString() + $"CNPJ: {Cnpj}";
    }
}
