using BilgeAdam.OOP.Interfaces.Exceptions;
using BilgeAdam.OOP.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.OOP.WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmStock());
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //if (e.Exception.GetType() == typeof(VehicleFullException))
            if(e.Exception is VehicleFullException)
            {
                var ex = e.Exception as VehicleFullException;
                var message = new StringBuilder(e.Exception.Message);
                message.AppendLine();
                if (ex.Vehicle != null)
                {
                    //var code = (ex.Vehicle as VehicleBase).Code;
                    //message.AppendLine("$Araç Plakası : {code}");
                    message.AppendLine($"Araç Plakası : {(ex.Vehicle as VehicleBase).Code}");
                }
                if (ex.Passenger != null)
                {
                    message.AppendLine($"Yolcu : {ex.Passenger.FullName}");
                }
                
                MessageBox.Show(message.ToString(), "Araç Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(e.Exception.Message, "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
