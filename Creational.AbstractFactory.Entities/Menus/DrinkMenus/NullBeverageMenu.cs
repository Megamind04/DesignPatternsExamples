using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DrinkMenus
{
    internal class NullBeverageMenu : BeverageMenu
    {
        internal NullBeverageMenu()
        {
            drinkMenu = new List<string>
            {
                "Menu without drinks."
            };
        }
    }
}
