using LocadoraCarros.Contracts;
using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Services;

internal class ClientRepositoryService : IClientRepository
{
    private List<LegalEntity> LegalEntities { get; set; }
    private List<Individual> Individuals { get; set; }


    public ClientRepositoryService()
    {
        LegalEntities = new List<LegalEntity>();
        Individuals = new List<Individual>();
    }
    public void AddClientIndividual(Individual client)
    {
        Individuals.Add(new Individual(client.Id, client.Name, client.Surname, client.BirthDate, client.Adress, client.ClientType, client.Cpf));
        Console.WriteLine("Succesful!");
    }

    public void AddClientLegalEntity(LegalEntity client)
    {
        LegalEntities.Add(new LegalEntity(client.Id, client.Name, client.Surname, client.BirthDate, client.Adress, client.ClientType, client.Cnpj));
        Console.WriteLine("Succesful!");
    }

    public void GetAll()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[Legal Entities]");

        if (LegalEntities == null)
            Console.WriteLine("Don't have Legals entities");
        else
        {
            foreach (var item in LegalEntities)
            {
                Console.WriteLine(item);
            }
        }

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[Individuals]");

        if (Individuals == null)
            Console.WriteLine("Don't have individuals");
        else
        {
            foreach (var item in Individuals)
            {
                Console.WriteLine(item);
            }
        }
        Console.ResetColor();
    }

    public void GetByCNPJ(string cnpj)
    {
        var clientCnpj = LegalEntities.Where(x => x.Cnpj == cnpj).FirstOrDefault();

        if (clientCnpj == null)
            Console.WriteLine("Client not found");
        else
            Console.WriteLine(clientCnpj);
    }

    public void GetByCPF(string cpf)
    {
        var clientCpf = Individuals.Where(x => x.Cpf == cpf).FirstOrDefault();

        if (clientCpf == null)
            Console.WriteLine("Client not found");
        else
            Console.WriteLine(clientCpf);
    }

    public void RemoveClientIndividual(string cpf)
    {
        var client = Individuals.Where(x => x.Cpf == cpf).FirstOrDefault();
        if (client != null)
            Individuals.Remove(client);
        else
            Console.WriteLine("Client don`t exist");
    }

    public void RemoveClientLegalEntity(string cnpj)
    {
        var client = LegalEntities.Where(x => x.Cnpj == cnpj).FirstOrDefault();
        if (client != null)
            LegalEntities.Remove(client);
        else
            Console.WriteLine("Client don`t exist");
    }
}
