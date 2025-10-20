using LocadoraCarros.Models.Abstractions;
using LocadoraCarros.Models.Enums;

namespace LocadoraCarros.Models;

internal class LegalEntity : AbstractClient
{
    public string Cnpj { get; private set; }

    public LegalEntity(int id, string name, string surname, DateTime birthDate, Adress adress, EClientType clientType ,string cnpj) 
        : base(id, name, surname, birthDate, adress, clientType)
    {
        Cnpj = cnpj;
    }

    public override string ToString()
    {
        return base.ToString() + $"CNPJ: {Cnpj}\n{Adress}";
    }
}
