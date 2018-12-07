using Creational.Builder.Entities;
using System;

namespace Creational.Builder.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ISandwich sandwich1 = SandwichMaker
                .CreateSandwich(SandwichType.Bauru, true, true)
                .BuildSandwich()
                .GetSandwhich();

            sandwich1.Display();

            ISandwich sandwich2 = SandwichMaker
                .CreateSandwich(SandwichType.Chacarero, false, true)
                .BuildSandwich()
                .GetSandwhich();

            sandwich2.Display();

            ISandwich sandwich3 = SandwichMaker
                .CreateSandwich(SandwichType.Jambon)
                .BuildSandwich()
                .GetSandwhich();

            sandwich3.Display();

            Console.ReadLine();
        }
    }
}
