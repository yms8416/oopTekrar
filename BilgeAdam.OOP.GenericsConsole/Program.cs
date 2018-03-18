using BilgeAdam.OOP.Generics;
using System;

namespace BilgeAdam.OOP.GenericsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = SampleGenerics.Dictionaries();
            foreach (var item in result)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
