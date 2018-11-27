using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DrinkMenus
{
    internal class AlcoholicBeverageMenu : BeverageMenu
    {
        internal AlcoholicBeverageMenu()
        {
            drinkMenu = new List<string>
            {
                "Beer", "Whiskey", "Wine", "Brandy", "Vodka", "Gin", "Rum"
            };
        }
    }
}
