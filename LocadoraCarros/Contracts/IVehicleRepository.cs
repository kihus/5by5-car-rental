using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;

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
    public void GetById(int id);
    public AbstractVehicle GetByModel(string model);
    public void VehicleAvaliable(int id);
}
