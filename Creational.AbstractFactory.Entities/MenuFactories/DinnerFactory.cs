using Creational.AbstractFactory.Entities.Menus.DessertMenus;
using Creational.AbstractFactory.Entities.Menus.DrinkMenus;
using Creational.AbstractFactory.Entities.Menus.MealMenus;

namespace Creational.AbstractFactory.Entities.MenuFactories
{
    internal class DinnerFactory : IOrderMealFactory
    {
        public IMealMenu GetMealMenu => new DinnerMenu();

        public IDrinkMenu GetDrinkMenu(DrinkType drinkType)
        {
            IDrinkMenu drinkMenu;
            switch (drinkType)
            {
                case DrinkType.AlcoholicBeverage:
                    drinkMenu = new AlcoholicBeverageMenu();
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
                case DesserType.Cake:
                    dessertMenu = new CakeMenu();
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
