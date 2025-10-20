using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class RentalCompany
{
    public List<AbstractVehicle> Vehicles = [];
    public List<AbstractVehicle> Customer = [];
    public List<AbstractVehicle> Rentals = [];
}
