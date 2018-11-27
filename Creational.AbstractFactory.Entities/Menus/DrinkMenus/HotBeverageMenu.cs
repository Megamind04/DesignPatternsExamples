using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DrinkMenus
{
    internal class HotBeverageMenu : BeverageMenu
    {
        internal HotBeverageMenu()
        {
            drinkMenu = new List<string>
            {
                "Hot Chocolate", "Cappuccino", "Hot Mocha", "Cafe Latte", "Macchiato", "Ristretto", "Piccolo Latte"
            };
        }
    }
}
