using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.MealMenus
{
    internal class BreakfastMenu : MealMenu
    {
        protected override string GetName => nameof(BreakfastMenu).Remove(nameof(BreakfastMenu).IndexOf("Menu"));

        internal BreakfastMenu()
        {
            mealMenu = new Dictionary<string, IReadOnlyList<string>>
            {
                {"SANDWICH", new List<string>{ "ham","egg","cheese", "texas toast" } },
                {"BURRITO", new List<string>{ "two scrambled eggs", "ham", "bacon", "cheese", "fresh tortilla" } },
                {"MIXED GRILL", new List<string>{ "two eggs", "bacon", "ham", "sausage" , "homemade hashbrowns", "texas toast" } },
                {"VEGGIE EGGS", new List<string>{ "two scrambled eggs", "veggies", "cheddar cheese", "hashbrowns", "texas toast" } }
            };
        }
    }
}
