using LocadoraCarros.Services;

namespace LocadoraCarros.Models;

internal class VehicleRental
{
    public VehicleRepositoryService VehicleManager { get; set; }
    public ClientRepositoryService ClientManager { get; set; }
    public VehicleRentalService RentalManager { get; set; }

    public VehicleRental()
    {
        VehicleManager = new VehicleRepositoryService();
        ClientManager = new ClientRepositoryService();
        RentalManager = new VehicleRentalService();
    }

    public void GetAllClients()
    {
        ClientManager.GetAll();
    }

    public void GetAllVehicles()
    {
        VehicleManager.GetAll();
    }
}
