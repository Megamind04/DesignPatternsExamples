
namespace Creational.Builder.Entities.Builders
{
    /// <summary>
    /// Interface needed for enforcing order of method chaining.
    /// </summary>
    public interface IDoneSandwich
    {
        /// <summary>
        /// Third step for creating sandwich.
        /// </summary>
        /// <returns>Sandwich instance.</returns>
        ISandwich GetSandwhich();
    }
}
