using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class MySandwichBuilder
    {
        private Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateSandwich()
        {
            sandwich = new Sandwich();

            PrepareBread();
            ApplyMeatAndCheese();
            ApplyVegetables();
            AddCondiments();
        }

        private void AddCondiments()
        {
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        private void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        private void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.Cheddar;
            sandwich.MeatType = MeatType.Turkey;
        }

        private void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
