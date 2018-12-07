using System;
using System.Collections.Generic;

namespace Creational.Builder.Entities.Entities
{
    internal class Sandwich : ISandwich
    {
        public string SandwichName { get; set; }
        public bool IsToasted { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public List<Vegetable> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine($"{SandwichName} Sandwich: ");
            Console.WriteLine($"Meat: {MeatType}");
            if (CheeseType != CheeseType.NoCheese) Console.WriteLine($"Cheese: {CheeseType}");
            Console.WriteLine("Veggies:");
            foreach (var item in Vegetables)
            {
                Console.WriteLine($"\t{item}");
            }
            if (IsToasted) Console.WriteLine("Toasted.");
            if (HasMayo) Console.WriteLine("With Mayo");
            if (HasMustard) Console.WriteLine("With Mustard");
            Console.WriteLine();
        }
    }
}
