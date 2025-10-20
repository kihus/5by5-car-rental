using LocadoraCarros.Abstract;
using LocadoraCarros.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraCarros.Models
{
    internal class Car(
        string model, 
        string brand, 
        string licensePlate, 
        EKind kind, 
        string color, 
        double dailyCost,
        bool manualGearBox,
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
        private bool _manualGearBox { get; set; } = manualGearBox;
        private int _numberOfPassengers { get; set; } = numberOfPassengers;

    }
}
