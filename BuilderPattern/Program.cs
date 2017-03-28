using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwichMaker = new SandwichMaker(new MySandwichBuilder());
            sandwichMaker.BuildSandwich();
            var sandwich1 = sandwichMaker.GetSandwich();
            sandwich1.Display();

            var sandwichMaker2 = new SandwichMaker(new ClubSandwichBuilder());
            sandwichMaker2.BuildSandwich();
            var sandwich2 = sandwichMaker2.GetSandwich();
            sandwich2.Display();

            Console.ReadKey();
        }
    }
}
