using System;
using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DessertMenus
{
    internal abstract class DessertMenu : IDessertMenu
    {
        protected IReadOnlyList<string> dessertMenu;

        public void DisplayDesserts()
        {
            Console.WriteLine("  \n Desserts: ");
            foreach (var dessert in dessertMenu)
            {
                Console.WriteLine($"   -{dessert}");
            }
        }
    }
}
