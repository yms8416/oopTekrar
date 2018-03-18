using BilgeAdam.OOP.StockManagement.Models;
using System;

namespace BilgeAdam.OOP.StockManagement.Helpers
{
    public class ProductManager<T> where T: ProductBase
    {
        private T product;
        public ProductManager(T product)
        {
            this.product = product;
        }
        public void AddToStock(int amount)
        {
            product.UnitsInStock += amount;
        }

        public void Sell(int amount)
        {
            if (Exists())
            {
                product.UnitsInStock -= amount;
            }
            else
            {
                throw new Exception($"{product.Barcode} kodlu ürün stokta yeteli miktarda olmadığından satılamadı");
            }
        }

        public bool Exists()
        {
            return product.UnitsInStock > 0;
        }
    }
}
