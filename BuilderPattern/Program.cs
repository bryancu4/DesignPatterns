using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MySandwichBuilder();

            builder.CreateSandwich();
            var sandwich = builder.GetSandwich();
            sandwich.Display();

            Console.ReadKey();
        }
    }
}
