using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Sandwich
    {
        public BreadType breadType { get; set; }
        public bool isToasted { get; set; }
        public CheeseType cheeseType { get; set; }
        public MeatType meatType { get; set; }
        public bool hasMustard { get; set; }
        public bool hasMayo { get; set; }
        public List<string> vegetables { get; set; }

        public Sandwich(BreadType breadType, bool isToasted, CheeseType cheeseType, MeatType meatType, bool hasMustard, bool hasMayo, List<string> vegetables)
        {
            this.breadType = breadType;
            this.isToasted = isToasted;
            this.cheeseType = cheeseType;
            this.meatType = meatType;
            this.hasMustard = hasMustard;
            this.hasMayo = hasMayo;
            this.vegetables = vegetables;
        }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", breadType);
            if(isToasted)
                Console.WriteLine("Toasted");
            if(hasMayo)
                Console.WriteLine("With Mayo");
            if (hasMustard)
                Console.WriteLine("With Mustard");
            Console.WriteLine("Meat: {0}", meatType);
            Console.WriteLine("Cheese: {0}", cheeseType);
            Console.WriteLine("Veggies:");
            foreach (var vegetable in vegetables)
                Console.WriteLine("     {0}", vegetable);
        }
    }
}
