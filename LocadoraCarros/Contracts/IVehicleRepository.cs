using LocadoraCarros.Entities.Base;

namespace LocadoraCarros.Contracts;

internal interface IVehicleRepository
{
    public List<AbstractVehicle> Vehicle { get; set; }

    public void AddVehicle(AbstractVehicle vehicle);
    public void RemoveVehicle(AbstractVehicle vehicle);
    public List<AbstractVehicle> GetAll()
    {
        return Vehicle;
    }

    public List<AbstractVehicle> GetById(int id)
    {
        return Vehicle.Where(x => x.Id == id).ToList();
    }

    public List<AbstractVehicle> GetByModel(string model)
    {
        return Vehicle.Where(x => x.Model == model).ToList();
    }
}
