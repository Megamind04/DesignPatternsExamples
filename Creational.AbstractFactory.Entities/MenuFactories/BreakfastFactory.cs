using Creational.AbstractFactory.Entities.Menus.DessertMenus;
using Creational.AbstractFactory.Entities.Menus.DrinkMenus;
using Creational.AbstractFactory.Entities.Menus.MealMenus;

namespace Creational.AbstractFactory.Entities.MenuFactories
{
    internal class BreakfastFactory : IOrderMealFactory
    {
        public IMealMenu GetMealMenu => new BreakfastMenu();

        public IDrinkMenu GetDrinkMenu(DrinkType drinkType)
        {
            IDrinkMenu drinkMenu;
            switch (drinkType)
            {
                case DrinkType.ColdBeverage:
                    drinkMenu = new ColdBeverageMenu();
                    break;
                case DrinkType.HotBeverage:
                    drinkMenu = new HotBeverageMenu();
                    break;
                default:
                    drinkMenu = new NullBeverageMenu();
                    break;
            }
            return drinkMenu;
        }

        public IDessertMenu GetDessertMenu(DesserType desserType)
        {
            IDessertMenu dessertMenu;
            switch (desserType)
            {
                case DesserType.Biscuit:
                    dessertMenu = new BiscuitMenu();
                    break;
                case DesserType.FrozenDessert:
                    dessertMenu = new FrozenDessertMenu();
                    break;
                default:
                    dessertMenu = new NullDesserMenu();
                    break;
            }
            return dessertMenu;
        }
    }
}
