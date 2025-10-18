using LocadoraCarros.Entities.Base;
using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities;

internal class Motorcycle : AbstractVehicle
{
    public int EngineCylinderCapacityCC { get; private set; }
    public bool HasStorageBox { get; private set; }
    public bool IsAutomatic { get; private set; }
    public Motorcycle(int id, string model, string manufacturer, int manufacturerYear, Color color,
        decimal dailyRentalPrice, int mileage, VehicleType vehicleType, string licensePlate,
        int engineCylinderCapacityCC, bool hasStorageBox, bool isAutomatic)
    : base(id, model, manufacturer, manufacturerYear, color, dailyRentalPrice, mileage, vehicleType, licensePlate)
    {
        EngineCylinderCapacityCC = engineCylinderCapacityCC;
        HasStorageBox = hasStorageBox;
        IsAutomatic = isAutomatic;
    }

    public override string ToString()
    {
        return $"\nMotocycle\n\r" +
               $"{base.ToString()}\n\r" +
               $"Engine cylinder capacity: {EngineCylinderCapacityCC}cc\n\r" +
               $"{(HasStorageBox ? "Has storage box" : "Don't have storage box")}\n\r" +
               $"{(IsAutomatic ? "Is automatic" : "Is manual")}\n\r";
    }
}
