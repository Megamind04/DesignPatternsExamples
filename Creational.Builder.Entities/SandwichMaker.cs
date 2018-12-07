using Creational.Builder.Entities.Builders;

namespace Creational.Builder.Entities
{
    /// <summary>
    /// Type of Sandwich
    /// </summary>
    public enum SandwichType
    {
        ///<summary></summary>
        Bauru,
        ///<summary></summary>
        Chacarero,
        ///<summary></summary>
        Jambon
    }
    /// <summary>
    /// The Director.
    /// </summary>
    public class SandwichMaker : IBuildSandwich, IDoneSandwich
    {
        private readonly SandwichBuilder _builder;
        private readonly bool _hasMustard;
        private readonly bool _hasMayo;

        private SandwichMaker(SandwichType sandwichTyp, bool hasMayo, bool hasMustard)
        {
            switch (sandwichTyp)
            {
                case SandwichType.Bauru:
                    _builder = new BauruSandwichBuilder();
                    break;
                case SandwichType.Chacarero:
                    _builder = new ChacareroSandwichBuilder();
                    break;
                case SandwichType.Jambon:
                    _builder = new JambonBeurreSandwichBuilder();
                    break;
                default:
                    _builder = null;
                    break;
            }
            _hasMayo = hasMayo; _hasMustard = hasMustard;
        }
        /// <summary>
        /// First step for creating sandwich.
        /// </summary>
        /// <param name="sandwichType">type of sandwich.</param>
        /// <param name="hasMayo">to have mayo or no.</param>
        /// <param name="hasMustard">to have mustard or no.</param>
        /// <returns>SandwichMaker instance.</returns>
        public static IBuildSandwich CreateSandwich(SandwichType sandwichType, bool hasMayo, bool hasMustard)
        {
            return new SandwichMaker(sandwichType, hasMayo, hasMustard);
        }
        /// <summary>
        /// First step for creating sandwich.
        /// </summary>
        /// <param name="sandwichType">type of sandwich.</param>
        /// <returns>SandwichMaker instance.</returns>
        public static IBuildSandwich CreateSandwich(SandwichType sandwichType)
        {
            return new SandwichMaker(sandwichType, true, false);
        }
        ///<inheritDoc/>
        public IDoneSandwich BuildSandwich()
        {
            _builder.CreateNewSandwich();
            _builder.SandwichName();
            _builder.PrepareBread();
            _builder.ApplyMeatAndCheese();
            _builder.ApplyVegetables();
            _builder.AddCondiments(_hasMayo, _hasMustard);
            return this;
        }
        ///<inheritDoc/>
        public ISandwich GetSandwhich()
        {
            return _builder.GetSandwich();
        }
    }
}
