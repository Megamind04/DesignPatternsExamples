using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.MealMenus
{
    internal class DinnerMenu : MealMenu
    {
        protected override string GetName => nameof(DinnerMenu).Remove(nameof(DinnerMenu).IndexOf("Menu"));

        internal DinnerMenu()
        {
            mealMenu = new Dictionary<string, IReadOnlyList<string>>
            {
                {"Glazed Steak", new List<string>{ "sirloin steaks", "soy sauce", "cornstarch", "vegetable oil", "garlic", "ketchup", "broccoli florets" } },
                {"Pork Chops", new List<string>{ "pork chops", "olive oil", "garlic", "onion", "red pepper", "tomato paste", "red wine" } },
                {"Shrimp and Kale Pitas", new List<string>{ "low-fat yogurt", "olive oil", "lemon", "garlic", "Kosher salt", "medium shrimp", "tomatoes", "pita bread" } }
            };
        }
    }
}
