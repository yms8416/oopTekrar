using BilgeAdam.OOP.Interfaces.Models;
using System;

namespace BilgeAdam.OOP.Interfaces.Exceptions
{
    public class VehicleFullException : Exception
    {
        public VehicleFullException(string exceptionMessage, IVehicle vehicle = null, Person passenger = null) : base(exceptionMessage)
        {
            Vehicle = vehicle;
            Passenger = passenger;
        }
        public IVehicle Vehicle { get; set; }
        public Person Passenger { get; set; }
    }
}
