using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DessertMenus
{
    internal class CakeMenu : DessertMenu
    {
        internal CakeMenu()
        {
            dessertMenu = new List<string>
            {
                "Pineapple", "Eggless Truffle", "Mango Meringue", "Cherry Cheesecake"
            };
        }
    }
}
