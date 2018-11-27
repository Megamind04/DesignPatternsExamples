using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DessertMenus
{
    internal class FrozenDessertMenu : DessertMenu
    {
        internal FrozenDessertMenu()
        {
            dessertMenu = new List<string>
            {
                "Ice Cream", "Sherbets", "Frozen Yogurt", "Novelties"
            };
        }
    }
}
