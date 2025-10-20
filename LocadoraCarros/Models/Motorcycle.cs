using LocadoraCarros.Abstract;
using LocadoraCarros.Enumerators;

namespace LocadoraCarros.Models;

internal class Motorcycle(
    string model,
    string brand,
    string licensePlate,
    EKind kind,
    string color,
    double dailyCost,
    int cc,
    int numberOfPassengers
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
    private int _cc { get; set; } = cc;
    private int _numberOfPassengers { get; set; } = numberOfPassengers;
}
