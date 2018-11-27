using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DessertMenus
{
    internal class NullDesserMenu : DessertMenu
    {
        internal NullDesserMenu()
        {
            dessertMenu = new List<string>
            {
                "Menu without Desserts."
            };
        }
    }
}
