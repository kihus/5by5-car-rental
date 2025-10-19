using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities;

internal class LegalEntity : AbstractClient
{
    public string Cnpj { get; private set; }

    public LegalEntity(int id, string name, string surname, DateTime birthDate, Adress adress, ClientType clientType ,string cnpj) 
        : base(id, name, surname, birthDate, adress, clientType)
    {
        Cnpj = cnpj;
    }

    public override string ToString()
    {
        return base.ToString() + $"CNPJ: {Cnpj}\n{Adress}";
    }
}
