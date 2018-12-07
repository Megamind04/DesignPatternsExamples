
namespace Creational.Builder.Entities.Builders
{
    /// <summary>
    /// Interface needed for enforcing order of method chaining.
    /// </summary>
    public interface IBuildSandwich
    {
        /// <summary>
        /// Second step for creating sandwich.
        /// </summary>
        /// <returns>SandwichMaker instance.</returns>
        IDoneSandwich BuildSandwich();
    }
}
