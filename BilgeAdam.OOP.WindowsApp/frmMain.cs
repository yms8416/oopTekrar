using BilgeAdam.OOP.Interfaces.Models;
using System;
using System.Windows.Forms;

namespace BilgeAdam.OOP.WindowsApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //var plane = new Plane
            //{
            //    Code = "TK 938",
            //    Capacity = 420
            //};

            //var v = new VehicleBase();


            var e1 = new Exam
            {
                FullName = "B",
                Exam1 = 12,
                Exam2 = 90
            };

            var e2 = new Exam
            {
                FullName = "C",
                Exam1 = 45,
                Exam2 = 87
            };

            var e3 = new Exam();
            e3.FullName = "V";
            e3.Exam1 = 34;
            e3.Exam2 = 98;
        }

        private void btnGetOn_Click(object sender, EventArgs e)
        {
            //var s = 4 / int.Parse("0");

            var bike = new Bike { Capacity = 1 };
            bike.GetOnPassenger(new Person { FirstName = "Can", LastName = "PERK" });

            var car = new Car();
            car.Capacity = 4;
            car.Code = "06 YU 784";

            car.GetOnPassenger(new Person { FirstName = "Can" });
            car.GetOnPassenger(new Person { FirstName = "Emir" });
            car.GetOnPassenger(new Person { FirstName = "Ecem" });
            car.GetOnPassenger(new Person { FirstName = "Saadet" });
            car.GetOnPassenger(new Person { FirstName = "Elham" });
            car.GetOnPassenger(new Person { FirstName = "Burcu" });
        }
    }
}
