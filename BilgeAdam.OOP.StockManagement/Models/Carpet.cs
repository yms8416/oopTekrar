using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.StockManagement.Models
{
    public class Carpet : ProductBase
    {
        public Carpet()
        {
            this.OnSell += Carpet_OnSell;
        }

        private void Carpet_OnSell(object sender, EventArgs e)
        {
            //Halı satıldı bilgisini admine gönder
        }
    }
}
