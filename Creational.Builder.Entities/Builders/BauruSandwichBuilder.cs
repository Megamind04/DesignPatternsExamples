using Creational.Builder.Entities.Entities;
using System.Collections.Generic;

namespace Creational.Builder.Entities.Builders
{
    internal class BauruSandwichBuilder : SandwichBuilder
    {
        public override void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
        
        public override void SandwichName()
        {
            sandwich.SandwichName = "Bauru";
        }
        
        public override void PrepareBread()
        {
            sandwich.IsToasted = false;
            sandwich.BreadType = BreadType.Brown;
        }
        
        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Beef;
            sandwich.CheeseType = CheeseType.Mozzarella;
        }
        
        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<Vegetable> { Vegetable.Tomato, Vegetable.Cucumber };
        }
        
        public override void AddCondiments(bool hasMayo, bool hasMustard)
        {
            sandwich.HasMayo = hasMayo;
            sandwich.HasMustard = hasMustard;
        }
        
        public override ISandwich GetSandwich()
        {
            return sandwich;
        }
    }
}
