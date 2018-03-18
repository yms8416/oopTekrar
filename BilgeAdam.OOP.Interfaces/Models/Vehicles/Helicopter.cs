using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Interfaces.Models
{
    public sealed class Helicopter : VehicleBase, IVehicle
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
            throw new NotImplementedException();
        }
    }
}
