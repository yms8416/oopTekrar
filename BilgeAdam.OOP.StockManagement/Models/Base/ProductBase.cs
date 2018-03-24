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
            //this.OnStockOver += StockOver;
            this.OnStockOver += StockOver;
        }

        internal void StockOver(string barcode)
        {
            
        }

        //internal void StockOver(object sender, EventArgs e)
        //{

        //    //this.OnStockOver -= StockOver;
        //}

        [DisplayName("Barkodu")]
        public string Barcode { get; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Fiyat")]
        public double Price { get; set; }
        [DisplayName("Stok Miktarı")]
        public int UnitsInStock { get; set; }

        public event EventHandler OnSell;
        public event StockOverEventHandler OnStockOver;

        internal void Sell()
        {
            if (OnSell != null)
            {
                OnSell(this, null);
            }
        }
    }

    public delegate void StockOverEventHandler(string barcode);
}
