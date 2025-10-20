using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class RentalCompany
{
    public List<AbstractVehicle> Vehicles = [];
    public List<AbstractPerson> Customer = [];
    public List<AbstractVehicle> Rentals = [];
}
