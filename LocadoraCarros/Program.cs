using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Enums;
using LocadoraCarros.Services;
using System.Globalization;

var idGeneratorService = new IdGeneratorService();
var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");

var clientType = new ClientType();
clientType = ClientType.Individual;


var individual = new Individual(idGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType ,"123.123.123-5");

clientType = ClientType.LegalEntity;
var individual2 = new Individual(idGeneratorService.GenerateId(), "Rogerio", "Rogerios", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, clientType ,"321.321.321-5");

List<VehicleRental> vhr = [];

var clientRepository = new ClientRepositoryService();

clientRepository.AddClient(individual);
clientRepository.AddClient(individual2);

clientRepository.GetAll();

