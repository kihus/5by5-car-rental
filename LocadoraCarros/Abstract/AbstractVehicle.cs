using LocadoraCarros.Enumerators;

namespace LocadoraCarros.Abstract;

internal abstract class AbstractVehicle(
    string model, 
    string brand, 
    string licensePlate, 
    EKind kind, 
    string color, 
    double dailyCost
    )
{
    private Guid _id { get; set; } = Guid.NewGuid();
    private string _model { get; set; } = model;
    private string _brand { get; set; } = brand;
    private string _licensePlate { get; set; } = licensePlate;
    private EKind _kind { get; set; } = kind;
    private string _color { get; set; } = color;
    private bool _isAvailable { get; set; } = true;
    private double _dailyCost { get; set; } = dailyCost;



}
