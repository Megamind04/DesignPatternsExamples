using Creational.Builder.Entities.Entities;
using System.Collections.Generic;

namespace Creational.Builder.Entities.Builders
{
    internal class ChacareroSandwichBuilder : SandwichBuilder
    {        
        public override void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
        
        public override void SandwichName()
        {
            sandwich.SandwichName = "Chacarero";
        }
        
        public override void PrepareBread()
        {
            sandwich.IsToasted = true;
            sandwich.BreadType = BreadType.White;
        }
        
        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Pork;
            sandwich.CheeseType = CheeseType.NoCheese;
        }
        
        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<Vegetable> { Vegetable.Tomato, Vegetable.ChilliPeppers, Vegetable.GreenBeans };
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
