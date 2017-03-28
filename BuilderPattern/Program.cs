using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich();
            sandwich.BreadType = BreadType.White;
            sandwich.CheeseType = CheeseType.Cheddar;
            sandwich.HasMayo = false;
            sandwich.IsToasted = true;
            sandwich.HasMustard = true;
            sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
            sandwich.Display();

            Console.ReadKey();
        }
    }
}
