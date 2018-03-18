using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Interfaces.Models
{
    public abstract class VehicleBase
    {
        public VehicleBase()
        {
            Passengers = new List<Person>();
        }
        public string Code { get; set; }
        public int ProductionYear { get; set; }
        public short Capacity { get; set; }
        public string Brand { get; set; }
        public Person Driver { get; set; }
        public List<Person> Passengers { get; private set; }

        protected void AddNewPassenger(Person passenger)
        {
            Passengers.Add(passenger);
            //diğer ortak senaryo kodları
        }
    }
}
