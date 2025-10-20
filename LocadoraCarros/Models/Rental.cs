using LocadoraCarros.Abstract;

namespace LocadoraCarros.Models;

internal class Rental(AbstractPerson customer, AbstractVehicle vehicle)
{
    private Guid _id { get; set; } = Guid.NewGuid();
    private AbstractPerson _customer { get; set; } = customer;
    private AbstractVehicle _vehicle { get; set; } = vehicle;
    private DateTime _rentalDate { get; set; } = DateTime.Now;
    private DateTime? _returnDate { get; set; } = null;
    private double? _amount { get; set; } = null;

   
}
