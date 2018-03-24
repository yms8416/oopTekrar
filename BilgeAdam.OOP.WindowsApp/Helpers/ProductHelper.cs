using BilgeAdam.OOP.StockManagement.Models;

namespace BilgeAdam.OOP.WindowsApp
{
    public class ProductHelper
    {
        public static ProductBase GetProduct(ProductType pt)
        {
            //enum isminden dll içinde class ı bul onun instance ını al
            switch (pt)
            {
                case ProductType.Computer:
                    return new Computer();
                case ProductType.Phone:
                    return new Phone();
                case ProductType.Tablet:
                    return new Tablet();
                case ProductType.Carpet:
                    return new Carpet();
                case ProductType.Book:
                    return new Book();
                case ProductType.GamingConsole:
                    return new GamingConsole();
                default:
                    return null;
            }
        }
    }
}
