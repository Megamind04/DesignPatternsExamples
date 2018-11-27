using Creational.AbstractFactory.Entities;
using System;
using System.Collections.Generic;

namespace Creational.AbstractFactory.Client
{
    internal class Client
    {
        private IOrderMealFactory orderMealFactory;
        private DrinkType drinkType;
        private DesserType desserType;

        internal void RunClient() => ChooseMeal();        

        private void ChooseMeal()
        {
            Console.WriteLine("Choose meal: ");
            DisplayChooses(FactoryCreator.GetAvailableMeals());
            CheckMeal();
        }

        private void ChooseBeverage()
        {
            Console.WriteLine("Do you want something to drink with your meal?");
            DisplayChooses(FactoryCreator.GetAvailableBeverages());
            CheckBeverage();
        }

        private void ChooseDessert()
        {
            Console.WriteLine("Do you want dessert?");
            DisplayChooses(FactoryCreator.GetAvailableDesserts());
            CheckDessert();
        }

        private void CheckMeal()
        {
            bool isInt = int.TryParse(Console.ReadLine(), out int mealTypeNum);

            if (isInt && Enum.IsDefined(typeof(MealType), mealTypeNum))
            {
                orderMealFactory = FactoryCreator.GetFactory((MealType)mealTypeNum);
                Console.Clear();
                ChooseBeverage();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You didn't choose correctly.");
                ChooseMeal();
            }
        }

        private void CheckBeverage()
        {
            bool isInt = int.TryParse(Console.ReadLine(), out int drinkTypeNum);

            if (isInt)
            {
                if(Enum.IsDefined(typeof(DrinkType), drinkTypeNum))
                {
                    drinkType = (DrinkType)drinkTypeNum;
                }
                else
                {
                    drinkType = DrinkType.NothingBeverage;
                }
                Console.Clear();
                ChooseDessert();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You didn't choose correctly.");
                ChooseBeverage();
            }
        }

        private void CheckDessert()
        {
            bool isInt = int.TryParse(Console.ReadLine(), out int dessertTypeNum);

            if (isInt)
            {
                if (Enum.IsDefined(typeof(DesserType), dessertTypeNum))
                {
                    desserType = (DesserType)dessertTypeNum;
                }
                else
                {
                    desserType = DesserType.Nothing;
                }
                Console.Clear();
                ShowMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You didn't choose correctly.");
                ChooseBeverage();
            }
        }

        private void ShowMenu()
        {
            IMealMenu mealMenu = orderMealFactory.GetMealMenu;
            IDrinkMenu drinkMenu = orderMealFactory.GetDrinkMenu(drinkType);
            IDessertMenu dessertMenu = orderMealFactory.GetDessertMenu(desserType);

            mealMenu.DisplayMeals();
            drinkMenu.DisplayDrinks();
            dessertMenu.DisplayDesserts();
        }

        private void DisplayChooses(IReadOnlyDictionary<int, string> pairs)
        {
            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Value} - {item.Key}.");
            }
        }
    }
}
