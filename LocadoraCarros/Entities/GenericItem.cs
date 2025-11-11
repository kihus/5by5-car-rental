using LocadoraCarros.Models;
using LocadoraCarros.Models.Enums;
using LocadoraCarros.Services;
using System.Globalization;

namespace LocadoraCarros.Entities;

internal class GenericItem
{

	public GenericItem(VehicleRental rentalManger, VehicleIdGeneratorService vehicleIdGeneratorService, ClientIdGeneratorService clientIdGeneratorService)
	{
		// Generic Vehicle
		GenerateGenericCars(rentalManger, vehicleIdGeneratorService);
		GenerateGenericMotorcycles(rentalManger, vehicleIdGeneratorService);
		GenerateGenericTrucks(rentalManger, vehicleIdGeneratorService);

		// Generic Person
		GenerateGenericIndividual(rentalManger, clientIdGeneratorService);
		GenerateGenericLegalEntity(rentalManger, clientIdGeneratorService);
	}

	// Vehicles
	void GenerateGenericCars(VehicleRental rentalManager, VehicleIdGeneratorService vehicleIdGeneratorService)
	{
		var car = new Car(vehicleIdGeneratorService.GenerateId(), "Sandero", "Renault", 2025, EColor.Red, 138.90m, 60_000, EVehicleType.Car, "ACD1B12", 4, 5, 450, true);
		rentalManager.VehicleManager.AddCar(car);

		car = new Car(vehicleIdGeneratorService.GenerateId(), "320I", "BMW", 2020, EColor.Black, 533.70m, 100_000, EVehicleType.Car, "SFL1K12", 4, 5, 700, true);
		rentalManager.VehicleManager.AddCar(car);

		car = new Car(vehicleIdGeneratorService.GenerateId(), "Corsa", "Chevrolet", 2016, EColor.Blue, 68.90m, 300_000, EVehicleType.Car, "RFG3214", 2, 4, 300, true);
		rentalManager.VehicleManager.AddCar(car);

		car = new Car(vehicleIdGeneratorService.GenerateId(), "SW4", "Toyota", 2023, EColor.White, 408.93m, 90_000, EVehicleType.Car, "PFE9L89", 4, 7, 800, true);
		rentalManager.VehicleManager.AddCar(car);

		car = new Car(vehicleIdGeneratorService.GenerateId(), "Mobi", "FIAT", 2021, EColor.Other, 128.90m, 200_000, EVehicleType.Car, "TJA1O12", 4, 4, 200, true);
		rentalManager.VehicleManager.AddCar(car);
	}

	void GenerateGenericMotorcycles(VehicleRental rentalManager, VehicleIdGeneratorService vehicleIdGeneratorService)
	{
		var motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "HORNET 500", "Honda", 2026, EColor.Red, 348.50m, 30_000, EVehicleType.Motocycle, "AGD1D12", 471, true, true);
		rentalManager.VehicleManager.AddMotorcycle(motorcycle);

		motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "XJ6", "Yamaha", 2015, EColor.Black, 178.50m, 120_000, EVehicleType.Motocycle, "AGJ5412", 600, true, false);
		rentalManager.VehicleManager.AddMotorcycle(motorcycle);

		motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "Ninja H2R", "Kawasaki", 2025, EColor.Blue, 545.70m, 60_000, EVehicleType.Motocycle, "AGK8D12", 998, true, true);
		rentalManager.VehicleManager.AddMotorcycle(motorcycle);

		motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "Hayabusa", "Suzuki", 2018, EColor.White, 700.50m, 100_000, EVehicleType.Motocycle, "AQD1512", 1340, true, true);
		rentalManager.VehicleManager.AddMotorcycle(motorcycle);

		motorcycle = new Motorcycle(vehicleIdGeneratorService.GenerateId(), "G 310 GS", "BMW", 2025, EColor.Silver, 228.50m, 30_000, EVehicleType.Motocycle, "AHD1D12", 313, true, false);
		rentalManager.VehicleManager.AddMotorcycle(motorcycle);
	}

	void GenerateGenericTrucks(VehicleRental rentalManager, VehicleIdGeneratorService vehicleIdGeneratorService)
	{
		var truck = new Truck(vehicleIdGeneratorService.GenerateId(), "V260", "JAC", 2023, EColor.White, 632.50M, 125_000, EVehicleType.Truck, "AGL4F42", 3, 2, 3.1);
		rentalManager.VehicleManager.AddTruck(truck);

		truck = new Truck(vehicleIdGeneratorService.GenerateId(), "FH 460", "Volvo", 2021, EColor.Blue, 850.00M, 150_000, EVehicleType.Truck, "HDA2J99", 25, 5, 2.5);
		rentalManager.VehicleManager.AddTruck(truck);

		truck = new Truck(vehicleIdGeneratorService.GenerateId(), "P360", "Scania", 2024, EColor.Red, 990.00M, 89_000, EVehicleType.Truck, "LMN0Z11", 18, 4, 2.8);
		rentalManager.VehicleManager.AddTruck(truck);

		truck = new Truck(vehicleIdGeneratorService.GenerateId(), "Daily 35S14", "Iveco", 2022, EColor.White, 550.00M, 215_000, EVehicleType.Truck, "CXZ7H88", 3, 2, 4.0);
		rentalManager.VehicleManager.AddTruck(truck);

		truck = new Truck(vehicleIdGeneratorService.GenerateId(), "Accelo 1016", "Mercedes-Benz", 2023, EColor.Silver, 700.00M, 110_000, EVehicleType.Truck, "QRW6P55", 10, 3, 3.5);
		rentalManager.VehicleManager.AddTruck(truck);
	}


	// Person
	void GenerateGenericIndividual(VehicleRental rentalManager, ClientIdGeneratorService clientIdGeneratorService)
	{
		var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");
		var individual = new Individual(clientIdGeneratorService.GenerateId(), "Bruno", "Nascimento", DateTime.ParseExact("04/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.Individual, "123.123.123-5");
		var individual2 = new Individual(clientIdGeneratorService.GenerateId(), "Felipe", "Pestana", DateTime.ParseExact("14/02/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.Individual, "321.312.123-5");
		var individual3 = new Individual(clientIdGeneratorService.GenerateId(), "Maicon", "Jequison", DateTime.ParseExact("30/12/1999", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.Individual, "432.934.132-5");

		rentalManager.ClientManager.AddClientIndividual(individual);
		rentalManager.ClientManager.AddClientIndividual(individual2);
		rentalManager.ClientManager.AddClientIndividual(individual3);
	}

	void GenerateGenericLegalEntity(VehicleRental rentalManager, ClientIdGeneratorService clientIdGeneratorService)
	{
		var adress = new Adress("Rua bonito", 132, "Jabuticaba", "07243-000", "Guarulhos", "SP", "Brasil", "Casa ao lado");
		var legalEntity = new LegalEntity(clientIdGeneratorService.GenerateId(), "Rogerio", "Rogerios", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.LegalEntity, "11.111.111/0001-01");
		var legalEntity2 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Marcos", "Antonio", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.LegalEntity, "51.551.332/0001-01");
		var legalEntity3 = new LegalEntity(clientIdGeneratorService.GenerateId(), "Sara", "Ellen", DateTime.ParseExact("04/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture), adress, EClientType.LegalEntity, "32.131.231/0002-43");

		rentalManager.ClientManager.AddClientLegalEntity(legalEntity);
		rentalManager.ClientManager.AddClientLegalEntity(legalEntity2);
		rentalManager.ClientManager.AddClientLegalEntity(legalEntity3);
	}
}
