using Creational.Builder.Entities.Entities;
using System.Collections.Generic;

namespace Creational.Builder.Entities.Builders
{
    internal class JambonBeurreSandwichBuilder : SandwichBuilder
    {
        public override void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
      
        public override void SandwichName()
        {
            sandwich.SandwichName = "Jambon Beurre";
        }
     
        public override void PrepareBread()
        {
            sandwich.IsToasted = false;
            sandwich.BreadType = BreadType.White;
        }
        
        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Ham;
            sandwich.CheeseType = CheeseType.American;
        }
      
        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<Vegetable> { Vegetable.Cucumber };
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
