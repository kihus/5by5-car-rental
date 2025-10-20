using LocadoraCarros.Contracts;
using LocadoraCarros.Models;
using LocadoraCarros.Models.Abstractions;

namespace LocadoraCarros.Services;

internal class VehicleRepositoryService : IVehicleRepository
{
    private List<Car> _cars { get; set; }
    private List<Motorcycle> _motorcycles { get; set; }
    private List<Truck> _truck { get; set; }

    public VehicleRepositoryService()
    {
        _cars = new List<Car>();
        _motorcycles = new List<Motorcycle>();
        _truck = new List<Truck>();
    }

    public void AddCar(Car vehicle)
    {
        _cars.Add(vehicle);
    }

    public void AddMotorcycle(Motorcycle vehicle)
    {
        _motorcycles.Add(vehicle);
    }

    public void AddTruck(Truck vehicle)
    {
        _truck.Add(vehicle);
    }

    public void GetAll()
    {
        GetAllCars();
        GetAllMotorcycles();
        GetAllTrucks();
    }

    public AbstractVehicle GetById(int id)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            return idVehicle;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            return idVehicle;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            return idVehicle;

        }

        return null;
    }

    public AbstractVehicle GetByModel(string model)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            return idVehicle;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            return idVehicle;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            return idVehicle;
        }
        return null;
    }
    public void GetByYear(int year)
    {
        Console.WriteLine("[Cars]");
        var cars = _cars.Where(x => x.ManufacturerYear == year);
        foreach(var item in cars.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("[Motorcycles]");
        var motorcycle = _motorcycles.Where(x => x.ManufacturerYear == year);
        foreach (var item in motorcycle.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("[Trucks]");
        var truck = _truck.Where(x => x.ManufacturerYear == year);
        foreach (var item in truck.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }
    }
    public void GetByManufacturer(string manufacturer)
    {
        Console.WriteLine("[Cars]");
        var cars = _cars.Where(x => x.Manufacturer == manufacturer);
        foreach (var item in cars.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("[Motorcycles]");
        var motorcycle = _motorcycles.Where(x => x.Manufacturer == manufacturer);
        foreach (var item in motorcycle.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("[Trucks]");
        var truck = _truck.Where(x => x.Manufacturer == manufacturer);
        foreach (var item in truck.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }
    }

    public void RemoveVehicleById(int id)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            _cars.Remove((Car)idVehicle);
            return;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            _motorcycles.Remove((Motorcycle)idVehicle);
            return;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            _truck.Remove((Truck)idVehicle);
            return;
        }

        Console.WriteLine("Vehicle doesnt exist");
    }

    public void RemoveVehicleByModel(string model)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            _cars.Remove((Car)idVehicle);
            return;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            _motorcycles.Remove((Motorcycle)idVehicle);
            return;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            _truck.Remove((Truck)idVehicle);
            return;
        }

        Console.WriteLine("Vehicle doesnt exist");
    }

    public void GetAllCars()
    {
        if (_cars == null)
        {
            Console.WriteLine("Dont have cars");
        }
        else
        {
            foreach (var item in _cars)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void GetAllMotorcycles()
    {
        if (_motorcycles == null)
        {
            Console.WriteLine("Dont have motorcycles");
        }
        else
        {
            foreach (var item in _motorcycles)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void GetAllTrucks()
    {
        if (_truck == null)
        {
            Console.WriteLine("Dont have cars");
        }
        else
        {
            foreach (var item in _truck)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void IsAvaliable(bool avaliable)
    {
        var carsAvaliable = _cars.Where(x => x.IsAvailable == avaliable);
        foreach(var item in carsAvaliable.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }


        var motorcyclesAvaliable = _motorcycles.Where(x => x.IsAvailable == avaliable);
        foreach (var item in motorcyclesAvaliable.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }

        var trucksAvaliable = _truck.Where(x => x.IsAvailable == avaliable);
        foreach (var item in trucksAvaliable.OrderBy(x => x.Model))
        {
            Console.WriteLine(item);
        }
    }
    public void VehicleAvaliable(int id)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            if(idVehicle.IsAvailable == false)
            {
                Console.WriteLine("this car has already been rented");
            }
            else
            {
                idVehicle.SetIsAvaliable(false);
            }
                
            return;
        }
       

            idVehicle = _motorcycles.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            if (idVehicle.IsAvailable == false)
            {
                Console.WriteLine("this motorcycle has already been rented");
            }
            else
            {
                idVehicle.SetIsAvaliable(false);
            }

            return;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {

            if (idVehicle.IsAvailable == false)
            {
                Console.WriteLine("this truck has already been rented");
            }
            else
            {
                idVehicle.SetIsAvaliable(false);
            }

            return;
        }

        Console.WriteLine("Not found");
    }
}