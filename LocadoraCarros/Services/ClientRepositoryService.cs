using LocadoraCarros.Contracts;
using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Services;

internal class ClientRepositoryService : IClientRepository
{
    public List<LegalEntity> LegalEntities { get; set; }
    public List<Individual> Individuals { get; set; }
    public List<AbstractClient> Clients { get; set; }
    public ClientRepositoryService ClientManager { get; set; }

    public void AddClient(AbstractClient client)
    {

      

        Console.WriteLine("Succesful!");
    }

    public void GetAll()
    {
        foreach (var item in ClientManager.LegalEntities)
        {
            Console.WriteLine("Legal Entities");
            Console.WriteLine(item);
        }

        foreach (var item in ClientManager.Individuals)
        {
            Console.WriteLine("Individuals");
            Console.WriteLine(item);
        }
    }

    public LegalEntity GetByCNPJ(string cnpj)
    {
        throw new NotImplementedException();
    }

    public Individual GetByCPF(string cpf)
    {
        throw new NotImplementedException();
    }

    public void RemoveClientIndividual(string cpf)
    {
        throw new NotImplementedException();
    }

    public void RemoveClientLegalEntity(string cnpj)
    {
        throw new NotImplementedException();
    }
}
