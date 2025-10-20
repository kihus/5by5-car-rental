using LocadoraCarros.Models;
using LocadoraCarros.Models.Abstractions;

namespace LocadoraCarros.Contracts;

internal interface IVehicleRepository
{
    public void AddMotorcycle(Motorcycle vehicle);
    public void AddCar(Car vehicle);
    public void AddTruck(Truck vehicle);
    public void GetAllCars();
    public void GetAllMotorcycles();
    public void GetAllTrucks();
    public void RemoveVehicleById(int id);
    public void RemoveVehicleByModel(string model);
    public void GetAll();
    public AbstractVehicle GetById(int id);
    public AbstractVehicle GetByModel(string model);
    public void VehicleAvaliable(int id);
}
