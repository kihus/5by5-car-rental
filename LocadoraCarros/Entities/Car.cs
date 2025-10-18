using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities;

internal class Car : AbstractVehicle
{
    public int NumberOfDoors { get; private set; }
    public int PassengerCapacity { get; private set; }
    public int TrunkCapacityLiters { get; private set; }
    public bool HasAirCondiotioning { get; private set; }

    public Car(int id, string model, string manufacturer, int manufacturerYear, Color color,
        decimal dailyRentalPrice, int mileage, VehicleType vehicleType, string licensePlate,
        int numberOfDoors, int passengerCapacity, int trunkCapacityLiters, bool hasAirCondiotioning)

    : base(id, model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, vehicleType, licensePlate)
    {
        NumberOfDoors = numberOfDoors;
        PassengerCapacity = passengerCapacity;
        TrunkCapacityLiters = trunkCapacityLiters;
        HasAirCondiotioning = hasAirCondiotioning;
    }

    public override string ToString()
    {
        return base.ToString() + "\n\r" +
            "Car\n\r" +
            $"Number of doors: {NumberOfDoors}\n\r" +
            $"Passenger capacity: {PassengerCapacity}\n\r" +
            $"Trunk capacity liters: {TrunkCapacityLiters}\n\r" +
            $"{(HasAirCondiotioning ? "Has air condiotioning" : "Don't have air condiotioning")}";
    }
}
