using LocadoraCarros.Entities.Enums;

namespace LocadoraCarros.Entities.Base;

internal abstract class AbstractVehicle(int id, string model, string manufacturer, int manufacturerYear,
                                        Color color, decimal dailyRentalPrice, int mileage, VehicleType vehicleType, string licensePlate)
{
    public int Id { get; init; } = id;
    public string Model { get; private set; } = model;
    public string Manufacturer { get; private set; } = manufacturer;
    public Color Color { get; private set; } = color;
    public int ManufacturerYear { get; private set; } = manufacturerYear;
    public decimal DailyRentalPrice { get; private set; } = dailyRentalPrice;
    public int Mileage { get; private set; } = mileage;
    public bool IsAvaliabe { get; private set; } = false;
    public VehicleType VehicleType { get; private set; } = vehicleType;
    public string LicensePlate
    {
        get;
        private set
        {
            if (licensePlate.Length < 7)
            {
                Console.WriteLine("this plate must be greatest 7 chars");
                return;
            }
            else
            {
                LicensePlate = licensePlate;
            }
        }

    }

    public override string ToString()
    {
        return $"\n" +
            $"Vehicle\n" +
            $"Model: {Model}\n" +
            $"License Plate: {LicensePlate}\n" +
            $"Color: {Color}\n" +
            $"Manufacturer: {Manufacturer}\n" +
            $"Manufacturer Year: {ManufacturerYear}\n";
    }

}
