using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities;

internal class Truck : AbstractVehicle
{
    public int LoadCapacityTons { get; private set; }
    public int NumberOfAxels { get; private set; }
    public double FuelConsumptionKML { get; private set; }

    public Truck(int id, string model, string manufacturer, int manufacturerYear, Color color,
        decimal dailyRentalPrice, int mileage, VehicleType vehicleType, string licensePlate,
        int loadCapacityTons, int numberOfAxels, double fuelConsumptionKML)
    : base(id, model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, vehicleType, licensePlate)
    {
        LoadCapacityTons = loadCapacityTons;
        NumberOfAxels = numberOfAxels;
        FuelConsumptionKML = fuelConsumptionKML;
    }

    public override string ToString()
    {
        return $"\nTruck\n\r" +
               $"{base.ToString()}\n\r" +
               $"Load capacity tons: {LoadCapacityTons}\n\r" +
               $"Number of axels: {NumberOfAxels}\n\r" +
               $"Fue consumption (KM/L): {FuelConsumptionKML}\n\r";
    }
}
