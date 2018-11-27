using Creational.AbstractFactory.Entities.MenuFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Creational.AbstractFactory.Entities
{
    /// <summary>
    /// Client class for geting the right factory.
    /// </summary>
    public static class FactoryCreator
    {
        /// <summary>
        /// Method for geting facotries.
        /// </summary>
        /// <param name="mealType">Meal Type</param>
        /// <returns>IOrderMealFactory</returns>
        public static IOrderMealFactory GetFactory(MealType mealType)
        {
            IOrderMealFactory orderMealFactory;
            switch (mealType)
            {
                case MealType.Breakfast:
                    orderMealFactory = new BreakfastFactory();
                    break;
                case MealType.Lunch:
                    orderMealFactory = new LunchFactory();
                    break;
                case MealType.Dinner:
                    orderMealFactory = new DinnerFactory();
                    break;
                default:
                    orderMealFactory = null;
                    break;
            }
            return orderMealFactory;
        }
        /// <summary>
        /// Gets available types of meals.
        /// </summary>
        /// <returns>dictionary representing int value of MealType enum and string value for the type of meal.</returns>
        public static IReadOnlyDictionary<int,string> GetAvailableMeals()
        {
            return Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && x.Namespace == "Creational.AbstractFactory.Entities.Menus.MealMenus")
                .Select(x => x.Name)
                .Select(x => x.Remove(x.IndexOf("Menu")))
                .Where(x => x != "Meal")
                .ToDictionary(v => (int)Enum.Parse(typeof(MealType), v), k => k);
        }
        /// <summary>
        /// Gets available types of beverages.
        /// </summary>
        /// <returns>dictionary representing int value of DrinkType enum and string value for the type of beverage.</returns>
        public static IReadOnlyDictionary<int,string> GetAvailableBeverages()
        {
            return Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && x.Namespace == "Creational.AbstractFactory.Entities.Menus.DrinkMenus")
                .Select(x => x.Name)
                .Select(x => x.Remove(x.IndexOf("Menu")))
                .Where(x => x != "NullBeverage" && x != "Beverage")
                .ToDictionary(v => (int)Enum.Parse(typeof(DrinkType), v), k => k);
        }
        /// <summary>
        /// Gets available types of desserts.
        /// </summary>
        /// <returns>dictionary representing int value of DesserType enum and string value for the type of dessert.</returns>
        public static IReadOnlyDictionary<int,string> GetAvailableDesserts()
        {
            return Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsClass && x.Namespace == "Creational.AbstractFactory.Entities.Menus.DessertMenus")
                .Select(x => x.Name)
                .Select(x => x.Remove(x.IndexOf("Menu")))
                .Where(x => x != "NullDesser" && x != "Dessert")
                .ToDictionary(v => (int)Enum.Parse(typeof(DesserType), v), k => k);              
        }
    }
}
