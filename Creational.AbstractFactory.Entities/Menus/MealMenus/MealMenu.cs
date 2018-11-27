using System;
using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.MealMenus
{
    internal abstract class MealMenu : IMealMenu
    {
        protected IReadOnlyDictionary<string, IReadOnlyList<string>> mealMenu;

        protected abstract string GetName { get; }

        public void DisplayMeals()
        {            
            Console.WriteLine(GetName + ": \n");
            foreach (var menu in mealMenu)
            {
                Console.WriteLine(menu.Key + " --Ingredients: ");
                foreach (var ingredient in menu.Value)
                {
                    Console.WriteLine($"  -{ingredient}");
                }
            }
        }
    }
}
