using BilgeAdam.OOP.Generics;
using BilgeAdam.OOP.StockManagement.Helpers;
using BilgeAdam.OOP.StockManagement.Models;
using System;

namespace BilgeAdam.OOP.GenericsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Computer { UnitsInStock = 30 };
            var b = new Book { UnitsInStock = 130 };
            var gc = new GamingConsole { UnitsInStock = 10 };
            var pmc = new ProductManager<Computer>(c);
            var pmb = new ProductManager<Book>(b);
            var pmg = new ProductManager<GamingConsole>(gc);
            pmc.AddToStock(5);
            pmc.AddToStock(20);
            pmc.Sell(45);
            pmc.Sell(16);
            pmb.AddToStock(8);
            pmb.Sell(80);
            pmg.AddToStock(10);
            pmg.Sell(7);

            //I am from Mut -> Mutluyum
            //DRY - Don't repeat yourself
            //YAGNI - You aren't gonna need it
            //KISS - Keep it simple & stupid


            var result = ComplexTypes.SaveStudents();
            foreach (var item in result)
            {
                Console.WriteLine("{0,8} {1} {2}", item.Number, item.FirstName, item.LastName);
            }
            Console.ReadKey();
        }
    }
}
