using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;
using LocadoraCarros.Services;
using System.Globalization;
try
{
    var clientIdGeneratorService = new ClientIdGeneratorService();
    var carIdGeneratorService = new CarIdGeneratorService();

    var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");

    var clientType = new ClientType();
    clientType = ClientType.Individual;


    var individual = new Individual(clientIdGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "123.123.123-5");
    var individual2 = new Individual(clientIdGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "321.312.123-5");
    var individual3 = new Individual(clientIdGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "432.134.132-5");

    clientType = ClientType.LegalEntity;
    var legalEntity = new LegalEntity(clientIdGeneratorService.GenerateId(), "Rogerio", "Rogerios", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "11.111.111/0001-01");
    var legalEntity2 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Marcos", "Antonio", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "51.551.332/0001-01");
    var legalEntity3 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Sara", "Ellen", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType, "32.131.231/0002-43");

    var clientManager = new ClientRepositoryService();

    clientManager.AddClientIndividual(individual);
    clientManager.AddClientIndividual(individual2);
    clientManager.AddClientIndividual(individual3);
    clientManager.AddClientLegalEntity(legalEntity);
    clientManager.AddClientLegalEntity(legalEntity2);
    clientManager.AddClientLegalEntity(legalEntity3);

    Console.WriteLine("Get by cpf");
    clientManager.GetByCPF("321.312.123-5");
    Console.WriteLine();

    Console.WriteLine("Remove by cnpj");
    clientManager.RemoveClientLegalEntity("51.551.332/0001-01");
    Console.WriteLine();

    clientManager.GetAll(); 

}
catch(Exception ex)
{
    Console.WriteLine(ex);
}

