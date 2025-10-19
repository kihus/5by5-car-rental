using LocadoraCarros.Contracts;
using LocadoraCarros.Entities;
using LocadoraCarros.Entities.Base;

namespace LocadoraCarros.Services;

internal class VehicleRepositoryService : IVehicleRepository
{
    private List<Car> _cars { get; set; }
    private List<Motorcycle> _motorcycle { get; set; }
    private List<Truck> _truck { get; set; }

    public void AddVehicle(AbstractVehicle vehicle)
    {
        throw new NotImplementedException();
    }

    public List<AbstractVehicle> GetAll()
    {
        throw new NotImplementedException();
    }

    public List<AbstractVehicle> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<AbstractVehicle> GetByModel(string model)
    {
        throw new NotImplementedException();
    }

    public void RemoveVehicle(AbstractVehicle vehicle)
    {
        throw new NotImplementedException();
    }
}
