using LocadoraCarros.Contracts;

namespace LocadoraCarros.Services;

internal class VehicleRentalService : IVehicleRental
{
    private VehicleRepositoryService _vehicleRepositoryService;

    public VehicleRentalService()
    {
        _vehicleRepositoryService = new VehicleRepositoryService();
    }

    public void GetAll()
    {
        _vehicleRepositoryService.GetAll();
    }

    public void GetCars()
    {
        _vehicleRepositoryService.GetAllCars();
    }

    public void GetMotorcycles()
    {
        _vehicleRepositoryService.GetAllMotorcycles();
    }

    public void GetTrucks()
    {
        _vehicleRepositoryService.GetAllTrucks();
    }

    public void RentVehicle(int id)
    {
        _vehicleRepositoryService.VehicleAvaliable(id);       
    }
    public void ReturnVehicle(int id)
    {
        _vehicleRepositoryService.VehicleAvaliable(id);
    }

}
