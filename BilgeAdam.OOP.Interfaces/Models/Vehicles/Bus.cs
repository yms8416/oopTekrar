using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Interfaces.Models
{
    public sealed class Bus : VehicleBase, IVehicle
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
            var capacity = Capacity + 5;
            if (capacity > Passengers.Count)
            {
                AddNewPassenger(passenger);
            }
            else
            {
                throw new Exception("Otobüs kapasitesi sadece 5 kişiye kadar artırılabilir. Otobüs doluluk oranını kontrol ediniz");
            }
        }
    }
}
