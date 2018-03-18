using BilgeAdam.OOP.StockManagement.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Barkodu")]
        public string Barcode { get; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok Miktarı")]
        public int UnitsInStock { get; set; }
    }
}
