using BilgeAdam.OOP.Interfaces.Exceptions;
using System;

namespace BilgeAdam.OOP.Interfaces.Models
{
    public sealed class Car : VehicleBase, IVehicle
    {
        public void AssignDriver(Person driver)
        {
            throw new NotImplementedException();
        }

        public void GetOffPassenger(Person passenger)
        {
            throw new NotImplementedException();
        }

        public void GetOnPassenger(Person passenger)
        {
            if (Capacity >= Passengers.Count)
            {
                AddNewPassenger(passenger);
                //DRY -> Don't Repeat Yourself
            }
            else
            {
                throw new VehicleFullException("Araba kapasitesi aşılamadığından yolcu eklenemedi", this, passenger);
            }
        }
    }
}
