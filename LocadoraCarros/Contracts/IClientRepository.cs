using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;

namespace LocadoraCarros.Contracts;

internal interface IClientRepository
{
    public void AddClient(AbstractClient client);
    public void RemoveClientIndividual(string cpf);
    public void RemoveClientLegalEntity(string cnpj);
    public Individual GetByCPF(string cpf);
    public LegalEntity GetByCNPJ(string cnpj);
    public void GetAll();
}
