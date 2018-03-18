using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Interfaces.Models
{
    public interface IVehicle
    {
        void GetOnPassenger(Person passenger);
        void GetOffPassenger(Person passenger);
        void AssignDriver(Person driver);
    }
}
