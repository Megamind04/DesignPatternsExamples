using Creational.Prototype.Entities;
using System;

namespace Creational.Prototype.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            AvailableVehicles availableVehicles = new AvailableVehicles();

            IVehicle prototype = availableVehicles["Antos"];
            IVehicle vehicle = prototype.DeepCopy();

            vehicle.ChooseColor("Black", 400.00f);
            vehicle.ChooseTires("Thunderer R404 AT", 134.00f);
            vehicle.ChooseAccessories(Accessories.A_C, Accessories.Stereo, Accessories.Speakers);

            vehicle.DisplayInfo();
            prototype.DisplayInfo();

            Console.WriteLine($"prototype and vehicle are the same instance: {ReferenceEquals(prototype, vehicle)}\n");

            Console.ReadLine();
        }
    }
}
