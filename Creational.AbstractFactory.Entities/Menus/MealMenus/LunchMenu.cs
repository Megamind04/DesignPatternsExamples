using System.Collections.Generic;

namespace Creational.AbstractFactory.Entities.Menus.MealMenus
{
    internal class LunchMenu : MealMenu
    {
        protected override string GetName => nameof(LunchMenu).Remove(nameof(LunchMenu).IndexOf("Menu"));

        internal LunchMenu()
        {
            mealMenu = new Dictionary<string, IReadOnlyList<string>>
            {
                {"Chicken Salad", new List<string>{ "chicken breasts", "eblack pepper", "tomato", "black beans", "onion", "cheddar cheese", "tortilla strips" } },
                {"Fish finger sarnie", new List<string>{ "two salmon fillets", "lemon", "wholemeal flour", "cabbage", "carrots", "hot chilli sauce", "ciabatta loaf" } },
                {"Chicken noodle soup", new List<string>{ "chicken breast", "onion", "carrots", "garlic", "green beans", "spinach", "fresh egg", "flat-leaf parsley" } }
            };
        }
    }
}
