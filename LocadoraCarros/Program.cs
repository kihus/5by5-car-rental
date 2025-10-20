using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;
using LocadoraCarros.Services;
using System.Globalization;

var clientIdGeneratorService = new ClientIdGeneratorService();
var vehicleIdGeneratorService = new VehicleIdGeneratorService();
var rentals = new List<VehicleRental>();

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
                ClientMenuSystem();
                break;

            case "2":
                VehicleMenuSystem();
                break;

            case "3":
                VehicleRentalMenuSystem();
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
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// generics Entities
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

// client "CRD"
void ClientMenuSystem()
{
    var working = true;
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
                Console.WriteLine("Register: (1 - Individual | 2 - Legal entity) ");
                Console.Write("-> ");

                var op = Console.ReadLine() ?? "";
                RegisterClient(op);
                break;

            case "2":
                SearchClientMenu();

                Console.Write("-> ");
                var o = Console.ReadLine() ?? "";

                SearchClient(o);
                break;

            case "3":
                RemoveClientMenu();
                Console.Write("-> ");

                var optiones = Console.ReadLine() ?? "";

                RemoveClient(optiones);

                break;

            case "0":
                Console.WriteLine("Return to the Main Menu.");
                working = false;

                Console.WriteLine("\nPress enter...");
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Command not found...");
                Console.ReadKey();
                break;
        }
        Console.Clear();
    } while (working);
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

            if (birthDate > DateTime.Now)
            {
                Console.WriteLine("Birth date must be less than the current date");
                Console.ReadKey();
                return;
            }

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
            var individual = new Individual(clientIdGeneratorService.GenerateId(), name, surname, birthDate, adress, ClientType.Individual, cpf);

            rentalManager.ClientManager.AddClientIndividual(individual);

            Console.WriteLine("Client add");
            Console.ReadKey();

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
                Console.ReadKey();
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

            Console.WriteLine("Client add!");
            Console.ReadKey();

            break;

        default:
            Console.WriteLine("Command not found...");
            Console.ReadKey();
            break;
    }
}
void SearchClientMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |          All         |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |         Name         |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |          Id          |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  4  |         CPF          |");
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  5  |         CNPJ         |");
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void SearchClient(string op)
{
    switch (op)
    {
        case "1":
            rentalManager.GetAllClients();
            break;

        case "2":
            Console.Write("Enter the name: ");
            var name = Console.ReadLine().Trim() ?? "";

            rentalManager.ClientManager.GetByName(name);
            break;

        case "3":
            Console.Write("Enter the id: ");
            var id = int.Parse(Console.ReadLine());

            rentalManager.ClientManager.GetById(id);
            break;

        case "4":
            Console.Write("Enter the CNPJ: ");
            var cnpj = Console.ReadLine() ?? "";

            rentalManager.ClientManager.GetByCNPJ(cnpj);
            break;

        case "5":
            Console.Write("Enter the CPF: ");
            var cpf = Console.ReadLine() ?? "";

            rentalManager.ClientManager.GetByCPF(cpf);
            break;

        case "0":
            break;

        default:
            Console.WriteLine("Command not found");

            break;
    }

    Console.WriteLine("\n\nPress enter to continue...");
    Console.ReadKey();
}
void RemoveClientMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |          Id          |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |         CPF          |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |         CNPJ         |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void RemoveClient(string optiones)
{
    switch (optiones)
    {
        case "1":
            Console.Write("Enter id: ");
            var id = int.Parse(Console.ReadLine());

            rentalManager.ClientManager.RemoveClientById(id);
            break;

        case "2":
            Console.Write("Enter CPF: ");
            var cpf = Console.ReadLine();

            rentalManager.ClientManager.RemoveClientIndividual(cpf);
            break;

        case "3":
            Console.Write("Enter CNPJ: ");
            var cnpj = Console.ReadLine();

            rentalManager.ClientManager.RemoveClientLegalEntity(cnpj);
            break;

        case "0":
            break;

        default:
            Console.WriteLine("Command not found");
            break;
    }
}

// vehicle "CRD"
void VehicleMenuSystem()
{
    var working = true;
    do
    {
        VehicleMenu();
        Console.Write("-> ");
        var option = Console.ReadLine();

        Console.Clear();
        switch (option)
        {
            case "1":
                Console.WriteLine("[Vehicle Register]");
                Console.WriteLine("Register: (1 - Motorcycle | 2 - Car | 3 - Truck) ");
                Console.Write("-> ");

                var op = Console.ReadLine() ?? "";
                RegisterVehicle(op);
                break;

            case "2":
                SearchVehicleMenu();
                Console.Write("-> ");

                var optiones = Console.ReadLine() ?? "";

                SearchVehicle(optiones);
                break;
            case "3":
                RemoveVehicleMenu();
                Console.Write("-> ");

                var opt = Console.ReadLine() ?? "";
                RemoveVehicle(opt);
                break;

            case "0":
                Console.WriteLine("Return to the Main Menu.");
                working = false;

                Console.WriteLine("\nPress enter...");
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Command not found");
                Console.ReadKey();
                break;
        }
    } while (working);
}
void VehicleMenu()
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
void RegisterVehicle(string op)
{
    switch (op)
    {
        // melhorar*
        case "1":
            Console.Write("Model: ");
            var model = Console.ReadLine();

            Console.Write("Manufacturer: ");
            var manufacturer = Console.ReadLine();

            Console.Write("Manufacturer year: (yyyy) ");
            var manufacturerYear = int.Parse(Console.ReadLine());

            Console.Write("Color: (1 - Red | 2 - Green | 3 - Blue | 4 - Black | 5 - White | 6 - Silver | 7 - Other)");
            Color color = (Color)int.Parse(Console.ReadLine());

            Console.Write("Daily rental price: ");
            var dailyRentalPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Mileage: ");
            var mileage = int.Parse(Console.ReadLine());

            Console.Write("License plate: (ABC1D23/ABC1234)");
            var licensePlate = Console.ReadLine();

            // motocycle
            Console.Write("Engine cylinder capacity (CC): ");
            var cc = int.Parse(Console.ReadLine());

            Console.WriteLine("Has storage box? (y/n) ");
            var answer = Console.ReadLine().ToLower().Trim();
            var storageBox = false;

            if (answer == "y")
                storageBox = true;

            Console.WriteLine("Is Automatic? (y/n) ");
            answer = Console.ReadLine().ToLower().Trim();
            var isAutomatic = false;

            if (answer == "y")
                isAutomatic = true;

            var motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, VehicleType.Motocycle, licensePlate, cc, storageBox, isAutomatic);

            rentalManager.VehicleManager.AddMotorcycle(motorcycle);

            break;

        case "2":
            Console.Write("Model: ");
            model = Console.ReadLine();

            Console.Write("Manufacturer: ");
            manufacturer = Console.ReadLine();

            Console.Write("Manufacturer year: (yyyy) ");
            manufacturerYear = int.Parse(Console.ReadLine());

            Console.Write("Color: (1 - Red | 2 - Green | 3 - Blue | 4 - Black | 5 - White | 6 - Silver | 7 - Other)");
            color = (Color)int.Parse(Console.ReadLine());

            Console.Write("Daily rental price: ");
            dailyRentalPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Mileage: ");
            mileage = int.Parse(Console.ReadLine());

            Console.Write("License plate: (ABC1D23/ABC1234)");
            licensePlate = Console.ReadLine();

            // car 
            Console.Write("Number of doors: ");
            var numberOfDoors = int.Parse(Console.ReadLine());

            Console.Write("Passenger capacity: ");
            var passengerCapacity = int.Parse(Console.ReadLine());

            Console.Write("Trunk capacity liters: ");
            var trunkCapacityLiters = int.Parse(Console.ReadLine());

            Console.Write("Has air condioning? (y/n) ");
            answer = Console.ReadLine().ToLower().Trim();
            var airConditioning = false;

            if (answer == "y")
                airConditioning = true;

            var car = new Car(vehicleIdGeneratorService.GenerateId(), model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, VehicleType.Car, licensePlate, numberOfDoors, passengerCapacity, trunkCapacityLiters, airConditioning);
            rentalManager.VehicleManager.AddCar(car);
            break;

        case "3":
            Console.Write("Model: ");
            model = Console.ReadLine();

            Console.Write("Manufacturer: ");
            manufacturer = Console.ReadLine();

            Console.Write("Manufacturer year: (yyyy) ");
            manufacturerYear = int.Parse(Console.ReadLine());

            Console.Write("Color: (1 - Red | 2 - Green | 3 - Blue | 4 - Black | 5 - White | 6 - Silver | 7 - Other)");
            color = (Color)int.Parse(Console.ReadLine());

            Console.Write("Daily rental price: ");
            dailyRentalPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Mileage: ");
            mileage = int.Parse(Console.ReadLine());

            Console.Write("License plate: (ABC1D23/ABC1234)");
            licensePlate = Console.ReadLine();

            // truck
            Console.Write("Load capacity: (Tons) ");
            var loadCapacityTons = int.Parse(Console.ReadLine());

            Console.Write("Number of Axels: ");
            var numberOfAxels = int.Parse(Console.ReadLine());

            Console.Write("Fuel consumption: (KM/L) ");
            var fuelConsumption = double.Parse(Console.ReadLine());

            var truck = new Truck(vehicleIdGeneratorService.GenerateId(), model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, VehicleType.Truck, licensePlate, loadCapacityTons, numberOfAxels, fuelConsumption);
            rentalManager.VehicleManager.AddTruck(truck);
            break;
        case "0":

            break;
        default:
            Console.WriteLine("Command not found");
            break;
    }
}
void SearchVehicleMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |          All         |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |         Model        |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |         Year         |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  4  |     Manufacturer     |");
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  5  |       All cars       |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  6  |     All Motorcycles  |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  7  |       All trucks     |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void SearchVehicle(string optiones)
{
    switch (optiones)
    {
        case "1":
            rentalManager.VehicleManager.GetAll();
            break;

        case "2":
            Console.Write("Enter model: ");
            var model = Console.ReadLine() ?? "";

            if (rentalManager.VehicleManager.GetByModel(model) == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                var vehicleModel = rentalManager.VehicleManager.GetByModel(model);
                Console.WriteLine(vehicleModel);
            }
            break;

        case "3":
            Console.Write("Enter manufacturer year: ");
            var year = int.Parse(Console.ReadLine());

            rentalManager.VehicleManager.GetByYear(year);
            break;

        case "4":
            Console.Write("Enter manufacturer: ");
            var manufacturer = Console.ReadLine() ?? "";

            rentalManager.VehicleManager.GetByManufacturer(manufacturer);
            break;

        case "5":
            rentalManager.VehicleManager.GetAllCars();
            break;
        case "6":
            rentalManager.VehicleManager.GetAllMotorcycles();
            break;
        case "7":
            rentalManager.VehicleManager.GetAllTrucks();
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Command not found");
            break;
    }

    Console.WriteLine("\n\nPress enter...");
    Console.ReadKey();
}
void RemoveVehicleMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |          Id          |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |         Model        |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void RemoveVehicle(string opt)
{
    switch (opt)
    {
        case "1":
            Console.Write("Enter id: ");
            var id = int.Parse(Console.ReadLine());

            rentalManager.VehicleManager.RemoveVehicleById(id);
            break;
        case "2":
            Console.Write("Enter model: ");
            var model = Console.ReadLine() ?? "";

            rentalManager.VehicleManager.RemoveVehicleByModel(model);
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Command not found");
            break;
    }
    Console.WriteLine("\n\nPress enter...");
    Console.ReadKey();
}

void VehicleRentalMenuSystem()
{
    var working = true;
    do
    {
        VehicleRentalMenu();
        Console.Write("-> ");
        var option = Console.ReadLine();

        Console.Clear();

        switch (option)
        {
            case "1":
                rentalManager.VehicleManager.IsAvaliable(true);
                break;
            case "2":
                RentVehicle();
                break;
            case "3":
                Console.WriteLine("Return the vehicle");
                break;
            case "0":
                Console.WriteLine("Return to the Main Menu.");
                working = false;

                Console.WriteLine("\nPress enter...");
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Command not found");
                Console.ReadKey();
                break;
        }
    } while (working);
}
void VehicleRentalMenu()
{
    Console.WriteLine("+-----+----------------------+");
    Console.WriteLine("|  1  |  Available Vehicles  |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  2  |      Rent Vehicle    |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  3  |  Return The Vehicle  |");
    Console.WriteLine("|-----+----------------------|");
    Console.WriteLine("|  0  |         Exit         |");
    Console.WriteLine("+-----+----------------------+");
}
void RentVehicle()
{
    Console.Write("Enter a model: ");
    var model = Console.ReadLine() ?? "";

    if (rentalManager.VehicleManager.GetByModel(model) == null)
    {
        Console.WriteLine("Not found");
        Console.ReadKey();
        return;
    }

    var vehicle = rentalManager.VehicleManager.GetByModel(model);

    Console.Write("How long? (days) ");
    var time = int.Parse(Console.ReadLine());

    var total = vehicle.DailyRentalPrice * time;

    Console.Write("Id Client: ");
    var client = int.Parse(Console.ReadLine());

    if (rentalManager.ClientManager.GetById(client) == null)
    {
        Console.WriteLine("Not found");
        Console.ReadKey();
        return;
    }

    var clientId = rentalManager.ClientManager.GetById(client);

    vehicle.SetClientName(clientId.Name);

    Console.WriteLine("Total days: " + time);
    Console.WriteLine("Return in " + (DateTime.Now.Day + time).ToString("d"));
    Console.WriteLine("Total Price: " + total.ToString("F2"));

    rentalManager.RentalManager.RentVehicle(vehicle.Id);
    Console.WriteLine("Vehicle rent. Thanks");
}
void ReturnVehicle()
{
    Console.WriteLine("Vehicles to return");
    rentalManager.VehicleManager.IsAvaliable(false);

    Console.Write("Id vehicle will be return: ");
    var id = int.Parse(Console.ReadLine());

    if(rentalManager.VehicleManager.GetById(id) == null)
    {
        Console.WriteLine("Vehicle not found");
    }

    var idVehicle = rentalManager.VehicleManager.GetById(id);

    rentalManager.VehicleManager.VehicleAvaliable(idVehicle.Id);
}