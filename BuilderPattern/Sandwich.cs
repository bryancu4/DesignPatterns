using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", BreadType);
            if(IsToasted)
                Console.WriteLine("Toasted");
            if(HasMayo)
                Console.WriteLine("With Mayo");
            if (HasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", MeatType);
            Console.WriteLine("Cheese: {0}", CheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in Vegetables)
                Console.WriteLine("     {0}", vegetable);
        }
    }
}
