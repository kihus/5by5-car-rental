namespace LocadoraCarros.Entities;

internal class VehicleRental
{
    public Car Cars { get; set; }
    public Truck Trucks { get; set; }
    public Motorcycle MotorCycles { get; set; }
    public Individual Individual { get; set; }
    public LegalEntity LegalEntity { get; set; }

    public VehicleRental(Car cars)
    {
        Cars = cars;
    }
    public VehicleRental(Truck truck)
    {
        Trucks = truck;
    }

    public VehicleRental(Individual individual)
    {
        Individual = individual;
    }
}
