
namespace Creational.AbstractFactory.Entities
{
    /// <summary>
    /// Type of meal.
    /// </summary>
    public enum MealType
    {
        /// <value>Breakfast.</value>
        Breakfast = 1,
        /// <value>Lunch.</value>
        Lunch = 2,
        /// <value>Dinner.</value>
        Dinner = 3
    }
    /// <summary>
    /// Type of beverage.
    /// </summary>
    public enum DrinkType
    {
        /// <value>Cold Beverage.</value>
        ColdBeverage = 1 ,
        /// <value>Hot Beverage.</value>
        HotBeverage = 2,
        /// <value>Alcoholic Beverage.</value>
        AlcoholicBeverage = 3,
        /// <value>Null.</value>
        NothingBeverage = 4
    }
    /// <summary>
    /// Type of dessert.
    /// </summary>
    public enum DesserType
    {
        /// <value>Biscuit.</value>
        Biscuit = 1,
        /// <value>Cake.</value>
        Cake = 2,
        /// <value>FrozenDessert.</value>
        FrozenDessert = 3,
        /// <value>Null.</value>
        Nothing = 4
    }
    /// <summary>
    /// Abstract Factory
    /// </summary>
    public interface IOrderMealFactory
    {
        /// <summary>
        /// Gets Meal Menu.
        /// </summary>
        IMealMenu GetMealMenu { get; }
        /// <summary>
        /// Gets Beverage part of the Menu.
        /// </summary>
        /// <param name="drinkType">Beverage type.</param>
        /// <returns>Beverage part of the Menu if avaible or Manu without beverages.</returns>
        IDrinkMenu GetDrinkMenu(DrinkType drinkType);
        /// <summary>
        /// Gets Dessert part of the Menu
        /// </summary>
        /// <param name="desserType">Dessert type.</param>
        /// <returns>Dessert part of the Menu if avaible or Manu without Desserts.</returns>
        IDessertMenu GetDessertMenu(DesserType desserType);
    }
}
