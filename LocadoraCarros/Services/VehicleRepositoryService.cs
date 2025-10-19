using LocadoraCarros.Contracts;
using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;

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

    public void GetById(int id)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Id == id);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
        }
    }

    public void GetByModel(string model)
    {
        AbstractVehicle idVehicle = _cars.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
        }

        idVehicle = _motorcycles.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
        }

        idVehicle = _truck.FirstOrDefault(x => x.Model == model);
        if (idVehicle != null)
        {
            Console.WriteLine(idVehicle);
            return;
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
}