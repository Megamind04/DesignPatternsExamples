using Creational.Builder.Entities.Entities;

namespace Creational.Builder.Entities.Builders
{
    internal abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public abstract void CreateNewSandwich();
        public abstract void SandwichName();
        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments(bool hasMayo, bool hasMustard);

        public abstract ISandwich GetSandwich();
    }
}
