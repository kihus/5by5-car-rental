using LocadoraCarros.Contracts;
using LocadoraCarros.Models;
using LocadoraCarros.Models.Abstractions;
using System.Xml.Serialization;

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
        _individuals.Add(client);
        Console.WriteLine("Succesful!");
    }

    public void AddClientLegalEntity(LegalEntity client)
    {
        _legalEntities.Add(client);
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
            foreach (var item in _legalEntities.OrderBy(x => x.Name))
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
            foreach (var item in _individuals.OrderBy(x => x.Name))
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
    public AbstractClient GetById(int id)
    {
        AbstractClient clientId = _legalEntities.FirstOrDefault(x => x.Id == id);
        if (clientId != null)
        {
            return clientId;
        }

        clientId = _individuals.FirstOrDefault(x => x.Id == id);
        if (clientId != null)
        {
            return clientId;
        }

        return null;

    }

    public void GetByName(string name)
    {
        foreach (var item in _legalEntities.Where(x => x.Name.Contains(name)).OrderBy(x => x.Name))
        {
            Console.WriteLine(item);
        }

        foreach (var item in _individuals.Where(x => x.Name.Contains(name)).OrderBy(x => x.Name))
        {
            Console.WriteLine(item);
        }
    }

    public void RemoveClientById(int id)
    {
        var legalEntityId = _legalEntities.FirstOrDefault(x => x.Id == id);
        if (legalEntityId != null)
        {
            _legalEntities.Remove(legalEntityId);
            Console.WriteLine($"Client removed: Id: {legalEntityId.Id}, Name: {legalEntityId.Name} {legalEntityId.Surname}");
            return;
        }

        var individualId = _individuals.FirstOrDefault(x => x.Id == id);
        if (individualId != null)
        {
            _individuals.Remove(individualId);
            Console.WriteLine($"Client removed: Id: {individualId.Id}, Name: {individualId.Name} {individualId.Surname}");
            return;
        }

        Console.WriteLine("Client not found");
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
