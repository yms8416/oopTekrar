using BilgeAdam.OOP.StockManagement.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.StockManagement.Models
{
    public abstract class ProductBase
    {
        public ProductBase()
        {
            Barcode = TextHelper.GenerateCode();
        }
        public string Barcode { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
