using LocadoraCarros.Abstract;
using LocadoraCarros.Enumerators;

namespace LocadoraCarros.Models;

internal class Truck(
    string model,
    string brand,
    string licensePlate,
    EKind kind,
    string color,
    double dailyCost,
    int axels,
    int loadCapacity
    ) 
    : AbstractVehicle(
        model, 
        brand, 
        licensePlate, 
        kind, 
        color, 
        dailyCost
        )
{
    private int _loadCapacity { get; set; } = loadCapacity;
    private int _axels { get; set; } = axels;
}
