using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;
using LocadoraCarros.Services;
using System.Globalization;

var clientIdGeneratorService = new ClientIdGeneratorService();
var vehicleIdGeneratorService = new VehicleIdGeneratorService();

var rentalManager = new VehicleRental();

try
{
    GenerateGenericCars();
    GenerateGenericMotorCycles();
    GenerateGenericTrucks();
    GenerateGenericLegalEntity();
    GenerateGenericIndividual();

    var working = true;

    do
    {
        Start();
        Console.Write("-> ");

        var option = Console.ReadLine();

        Console.Clear();

        switch (option)
        {
            case "1":
                ClientMenu();
                



                break;

            case "2":
                break;

            case "3":
                break;

            case "0":
                Console.WriteLine("Thanks to use our program");
                working = false;
                break;
                
            default:
                Console.WriteLine("Command not found...");
                Console.ReadKey();
                break;
        }


    } while (working);


}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

void GenerateGenericCars()
{
    var car = new Car(vehicleIdGeneratorService.GenerateId(), "Sandero", "Renault", 2025, Color.Red, 138.90m, 60_000, VehicleType.Car, "ACD1B12", 4, 5, 450, true);
    rentalManager.VehicleManager.AddCar(car);

    car = new Car(vehicleIdGeneratorService.GenerateId(), "320I", "BMW", 2020, Color.Black, 533.70m, 100_000, VehicleType.Car, "SFL1K12", 4, 5, 700, true);
    rentalManager.VehicleManager.AddCar(car);

    car = new Car(vehicleIdGeneratorService.GenerateId(), "Corsa", "Chevrolet", 2016, Color.Blue, 68.90m, 300_000, VehicleType.Car, "RFG3214", 2, 4, 300, true);
    rentalManager.VehicleManager.AddCar(car);

    car = new Car(vehicleIdGeneratorService.GenerateId(), "SW4", "Toyota", 2023, Color.White, 408.93m, 90_000, VehicleType.Car, "PFE9L89", 4, 7, 800, true);
    rentalManager.VehicleManager.AddCar(car);

    car = new Car(vehicleIdGeneratorService.GenerateId(), "Mobi", "FIAT", 2021, Color.Other, 128.90m, 200_000, VehicleType.Car, "TJA1O12", 4, 4, 200, true);
    rentalManager.VehicleManager.AddCar(car);
}
void GenerateGenericMotorCycles()
{
    var motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "HORNET 500", "Honda", 2026, Color.Red, 348.50m, 30_000, VehicleType.Motocycle, "AGD1D12", 471, true, true);
    rentalManager.VehicleManager.AddMotorcycle(motorcycle);

    motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "XJ6", "Yamaha", 2015, Color.Black, 178.50m, 120_000, VehicleType.Motocycle, "AGJ5412", 600, true, false);
    rentalManager.VehicleManager.AddMotorcycle(motorcycle);

    motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "Ninja H2R", "Kawasaki", 2025, Color.Blue, 545.70m, 60_000, VehicleType.Motocycle, "AGK8D12", 998, true, true);
    rentalManager.VehicleManager.AddMotorcycle(motorcycle);

    motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "Hayabusa", "Suzuki", 2018, Color.White, 700.50m, 100_000, VehicleType.Motocycle, "AQD1512", 1340, true, true);
    rentalManager.VehicleManager.AddMotorcycle(motorcycle);

    motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "G 310 GS", "BMW", 2025, Color.Silver, 228.50m, 30_000, VehicleType.Motocycle, "AHD1D12", 313, true, false);
    rentalManager.VehicleManager.AddMotorcycle(motorcycle);
}
void GenerateGenericTrucks()
{
    var truck = new Truck(vehicleIdGeneratorService.GenerateId(), "V260", "JAC", 2023, Color.White, 632.50M, 125_000, VehicleType.Truck, "AGL4F42", 3, 2, 3.1);
    rentalManager.VehicleManager.AddTruck(truck);

    truck = new Truck(vehicleIdGeneratorService.GenerateId(), "FH 460", "Volvo", 2021, Color.Blue, 850.00M, 150_000, VehicleType.Truck, "HDA2J99", 25, 5, 2.5);
    rentalManager.VehicleManager.AddTruck(truck);

    truck = new Truck(vehicleIdGeneratorService.GenerateId(), "P360", "Scania", 2024, Color.Red, 990.00M, 89_000, VehicleType.Truck, "LMN0Z11", 18, 4, 2.8);
    rentalManager.VehicleManager.AddTruck(truck);

    truck = new Truck(vehicleIdGeneratorService.GenerateId(), "Daily 35S14", "Iveco", 2022, Color.White, 550.00M, 215_000, VehicleType.Truck, "CXZ7H88", 3, 2, 4.0);
    rentalManager.VehicleManager.AddTruck(truck);

    truck = new Truck(vehicleIdGeneratorService.GenerateId(), "Accelo 1016", "Mercedes-Benz", 2023, Color.Silver, 700.00M, 110_000, VehicleType.Truck, "QRW6P55", 10, 3, 3.5);
    rentalManager.VehicleManager.AddTruck(truck);
}
void GenerateGenericIndividual()
{
    var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");
    var individual = new Individual(clientIdGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.Individual, "123.123.123-5");
    var individual2 = new Individual(clientIdGeneratorService.GenerateId(), "Felipe", "Pestana", DateTime.ParseExact("14/02/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.Individual, "321.312.123-5");
    var individual3 = new Individual(clientIdGeneratorService.GenerateId(), "Maicon", "Jequison", DateTime.ParseExact("30/12/1999", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.Individual, "432.934.132-5");

    rentalManager.ClientManager.AddClientIndividual(individual);
    rentalManager.ClientManager.AddClientIndividual(individual2);
    rentalManager.ClientManager.AddClientIndividual(individual3);
}
void GenerateGenericLegalEntity()
{
    var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");
    var legalEntity = new LegalEntity(clientIdGeneratorService.GenerateId(), "Rogerio", "Rogerios", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.LegalEntity, "11.111.111/0001-01");
    var legalEntity2 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Marcos", "Antonio", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.LegalEntity, "51.551.332/0001-01");
    var legalEntity3 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Sara", "Ellen", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, ClientType.LegalEntity, "32.131.231/0002-43");

    rentalManager.ClientManager.AddClientLegalEntity(legalEntity);
    rentalManager.ClientManager.AddClientLegalEntity(legalEntity2);
    rentalManager.ClientManager.AddClientLegalEntity(legalEntity3);
}
void Start()
{
    Console.Clear();
    MainMenu();
}
void MainMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |        Client        |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |        Vehicle       |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |     Vehicle Rental   |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void ClientMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |       Register       |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |        Search        |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |        Remove        |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void ClientMenuSystem()
{
    var wor = true;
    do
    {
        ClientMenu();
        Console.Write("-> ");
        var optionClient = Console.ReadLine();

        Console.Clear();
        switch (optionClient)
        {
            case "1":
                Console.WriteLine("[Client Register]");
                Console.Write("Register: (1 - Individual | 2 - Legal entity) ");
                Console.Write("-> ");

                var op = Console.ReadLine() ?? "";
                RegisterClient(op);
                break;

            case "2":
                break;

            case "3":
                break;
            case "0":
                Console.WriteLine("Return to the Main Menu.");
                wor = false;

                Console.WriteLine("\nPress enter...");
                Console.ReadKey();
                break;

            default:
                break;
        }
        Console.Clear();
    } while (wor);
}
void RegisterClient(string op)
{
    switch (op)
    {
        case "1":
            Console.Write("Name: ");
            var name = Console.ReadLine().Trim();

            Console.Write("Surname: ");
            var surname = Console.ReadLine().Trim();

            Console.Write("Birth date: (dd/mm/yyyy) ");
            var birthDate = DateTime.ParseExact(Console.ReadLine().Trim() ?? "", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("CPF: ");
            var cpf = Console.ReadLine().Trim() ?? "";

            // adress
            Console.Write("\n[Adress]");
            Console.Write("Street: ");
            var street = Console.ReadLine().Trim() ?? "";

            Console.Write("Number: ");
            var number = int.Parse(Console.ReadLine().Trim() ?? "");

            Console.Write("Neighborhood: ");
            var neighborhood = Console.ReadLine().Trim() ?? "";

            Console.Write("Complement: ");
            var complment = Console.ReadLine().Trim() ?? "";

            Console.Write("Zip code: ");
            var zipCode = Console.ReadLine().Trim() ?? "";

            Console.Write("City: ");
            var city = Console.ReadLine().Trim() ?? "";

            Console.Write("State: ");
            var state = Console.ReadLine().Trim() ?? "";

            Console.Write("Country: ");
            var country = Console.ReadLine().Trim() ?? "";


            var adress = new Adress(street, number, complment, neighborhood, zipCode, city, country);
            var individual = new Individual(clientIdGeneratorService.GenerateId(), name,surname, birthDate, adress, ClientType.Individual, cpf);

            rentalManager.ClientManager.AddClientIndividual(individual);

            break;

        case "2":
            Console.Write("Name: ");
            name = Console.ReadLine().Trim();

            Console.Write("Surname: ");
            surname = Console.ReadLine().Trim();

            Console.Write("Birth date: (dd/mm/yyyy) ");
            birthDate = DateTime.ParseExact(Console.ReadLine().Trim() ?? "", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (birthDate > DateTime.Now)
            {
                Console.WriteLine("Birth date must be less than the current date");
                return;
            }

            Console.Write("CNPJ: ");
            var cnpj = Console.ReadLine().Trim() ?? "";

            // adress
            Console.Write("\n[Adress]");
            Console.Write("Street: ");
            street = Console.ReadLine().Trim() ?? "";

            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine().Trim() ?? "");

            Console.Write("Neighborhood: ");
            neighborhood = Console.ReadLine().Trim() ?? "";

            Console.Write("Complement: ");
            complment = Console.ReadLine().Trim() ?? "";

            Console.Write("Zip code: ");
            zipCode = Console.ReadLine().Trim() ?? "";

            Console.Write("City: ");
            city = Console.ReadLine().Trim() ?? "";

            Console.Write("State: ");
            state = Console.ReadLine().Trim() ?? "";

            Console.Write("Country: ");
            country = Console.ReadLine().Trim() ?? "";

            adress = new Adress(street, number, complment, neighborhood, zipCode, city, country);
            var legalEntity = new LegalEntity(clientIdGeneratorService.GenerateId(), name, surname, birthDate, adress, ClientType.Individual, cnpj);

            rentalManager.ClientManager.AddClientLegalEntity(legalEntity);

            break;

        default:
            Console.WriteLine("Command not found...");
            Console.ReadKey();
            break;
    }
}
void VehicleMenu()
{

}
void VehicleRental()
{

}