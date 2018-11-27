using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.DessertMenus
{
    internal class BiscuitMenu : DessertMenu
    {
        internal BiscuitMenu()
        {
            dessertMenu = new List<string>
            {
                "Ginger Nut", "Malted Milk", "Chocolate Chip", "Custard Cream"
            };
        }
    }
}
