using System;
using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DrinkMenus
{
    internal class BeverageMenu : IDrinkMenu
    {
        protected IReadOnlyList<string> drinkMenu;

        public void DisplayDrinks()
        {
            Console.WriteLine(" \n Drinks: ");
            foreach (var drink in drinkMenu)
            {
                Console.WriteLine($"  -{drink}");
            }
        }
    }
}
