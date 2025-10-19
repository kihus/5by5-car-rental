using LocadoraCarros.Contracts;
using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Services;

internal class ClientRepositoryService : IClientRepository
{
    private List<LegalEntity> _legalEntities { get; set; }
    private List<Individual> _individuals { get; set; }


    public ClientRepositoryService()
    {
        _legalEntities = new List<LegalEntity>();
        _individuals = new List<Individual>();
    }
    public void AddClientIndividual(Individual client)
    {
        _individuals.Add(new Individual(client.Id, client.Name, client.Surname, client.BirthDate, client.Adress, client.ClientType, client.Cpf));
        Console.WriteLine("Succesful!");
    }

    public void AddClientLegalEntity(LegalEntity client)
    {
        _legalEntities.Add(new LegalEntity(client.Id, client.Name, client.Surname, client.BirthDate, client.Adress, client.ClientType, client.Cnpj));
        Console.WriteLine("Succesful!");
    }

    public void GetAll()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[Legal Entities]");

        if (_legalEntities == null)
            Console.WriteLine("Don't have Legals entities");
        else
        {
            foreach (var item in _legalEntities)
            {
                Console.WriteLine(item);
            }
        }

        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[Individuals]");

        if (_individuals == null)
            Console.WriteLine("Don't have individuals");
        else
        {
            foreach (var item in _individuals)
            {
                Console.WriteLine(item);
            }
        }
        Console.ResetColor();
    }

    public void GetByCNPJ(string cnpj)
    {
        var clientCnpj = _legalEntities.Where(x => x.Cnpj == cnpj).FirstOrDefault();

        if (clientCnpj == null)
            Console.WriteLine("Client not found");
        else
            Console.WriteLine(clientCnpj);
    }

    public void GetByCPF(string cpf)
    {
        var clientCpf = _individuals.Where(x => x.Cpf == cpf).FirstOrDefault();

        if (clientCpf == null)
            Console.WriteLine("Client not found");
        else
            Console.WriteLine(clientCpf);
    }

    public void RemoveClientIndividual(string cpf)
    {
        var client = _individuals.Where(x => x.Cpf == cpf).FirstOrDefault();
        if (client != null)
            _individuals.Remove(client);
        else
            Console.WriteLine("Client don`t exist");
    }

    public void RemoveClientLegalEntity(string cnpj)
    {
        var client = _legalEntities.Where(x => x.Cnpj == cnpj).FirstOrDefault();
        if (client != null)
            _legalEntities.Remove(client);
        else
            Console.WriteLine("Client don`t exist");
    }
}
