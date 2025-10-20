namespace LocadoraCarros.Contracts;

internal interface IVehicleRental
{
    public void GetAll();
    public void GetCars();
    public void GetMotorcycles();
    public void GetTrucks();
    public void RentVehicle(int id);
}
