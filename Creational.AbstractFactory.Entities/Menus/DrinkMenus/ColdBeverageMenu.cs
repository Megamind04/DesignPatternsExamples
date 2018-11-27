using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DrinkMenus
{
    internal class ColdBeverageMenu : BeverageMenu
    {       
        internal ColdBeverageMenu()
        {
            drinkMenu = new List<string>
            {
                "Frozen Lemonade", "Iced Latte", "Fruit Smoothie", "Fanta", "Coca-Cola"
            };
        }
    }
}
