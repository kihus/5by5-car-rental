using LocadoraCarros.Entities.Base;
using LocadoraCarros.Models;

namespace LocadoraCarros.Contracts;

internal interface IClientRepository
{
    public void AddClientIndividual(Individual client);
    public void AddClientLegalEntity(LegalEntity client);
    public void RemoveClientIndividual(string cpf);
    public void RemoveClientLegalEntity(string cnpj);
    public void GetByCPF(string cpf);
    public void GetByCNPJ(string cnpj);
    public void GetAll();
}
