using LocadoraCarros.Models.Enums;

namespace LocadoraCarros.Models.Abstractions;

internal abstract class AbstractVehicle(int id, string model, string manufacturer, int manufacturerYear,
                                        EColor color, decimal dailyRentalPrice, int mileage, 
                                        EVehicleType vehicleType, string licensePlate)
{
    public int Id { get; init; } = id;
    public string Model { get; private set; } = model;
    public string Manufacturer { get; private set; } = manufacturer;
    public EColor Color { get; private set; } = color;
    public int ManufacturerYear { get; private set; } = manufacturerYear;
    public decimal DailyRentalPrice { get; private set; } = dailyRentalPrice;
    public int Mileage { get; private set; } = mileage;
    public bool IsAvailable { get; private set; } = true;
    public EVehicleType VehicleType { get; private set; } = vehicleType;
    public string ClientName { get; private set; } = null;
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

    public void SetIsAvaliable(bool isAvaliable)
    {
        IsAvailable = isAvaliable;
    }

    public void SetClientName(string clientName)
    {
        ClientName = clientName;
    }
    public override string ToString()
    {

        return $"[Vehicle]\n\r" +
               $"Id: {Id}\n\r" +
               $"Model: {Model}\n\r" +
               $"License Plate: {LicensePlate}\n\r" +
               $"Color: {Color}\n\r" +
               $"Manufacturer: {Manufacturer}\n\r" +
               $"Manufacturer Year: {ManufacturerYear}\n\r" +
               $"Daily rental price: {DailyRentalPrice}\n\r" +
               $"Mileage: {Mileage}\n\r" +
               $"Situation: {(IsAvailable ? "Avaliabe" : "Unavailable")}\n";
    }

}
