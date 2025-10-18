namespace LocadoraCarros;

internal abstract class Vehicle(int id, string model, string manufacturer, int manufacturerYear, Color color, string licensePlate)
{
    public int Id { get; init; } = id;
    public string Model { get; private set; } = model;
    public string Manufacturer { get; private set; } = manufacturer;
    public Color Color { get; private set; } = color;
    public int ManufacturerYear { get; private set; } = manufacturerYear;
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
