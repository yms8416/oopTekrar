using BilgeAdam.OOP.Generics;
using System;

namespace BilgeAdam.OOP.GenericsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = ComplexTypes.SaveStudents();
            foreach (var item in result)
            {
                Console.WriteLine("{0,8} {1} {2}", item.Number, item.FirstName, item.LastName);
            }
            Console.ReadKey();
        }
    }
}
