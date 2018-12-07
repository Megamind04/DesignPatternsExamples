using Creational.Prototype.Entities.Parts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Creational.Prototype.Entities.Vehicles
{
    internal abstract class Vehicle : IVehicle
    {
        protected VehicleType _vehicleType;
        protected string _model;
        protected string _engine;
        protected float _price;

        public Tires Tires { get; set; }
        public Color Color { get; set; }
        public List<Accessories> Accessories { get; set; }

        public void ChooseColor(string color, float price)
        {
            Color.ColorType = color;
            Color.ColorPrice = price;
        }

        public void ChooseTires(string tiresType, float price)
        {
            Tires.TiresType = tiresType;
            Tires.TirePrice = price;
        }

        public void ChooseAccessories(Accessories[] accessories)
        {
            Accessories = accessories.ToList();
        }

        protected Vehicle(string model, string engine, float price)
        {
            _model = model;
            _engine = engine;
            _price = price;
        }

        public float GetPrice()
        {
            var price = _price + Color.ColorPrice;
            price += Tires.GetPrice();

            foreach (var item in Accessories)
            {
                price += (float)item;
            }
            return price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{_vehicleType}-model {_model} : ");
            Console.WriteLine($"Engine : {_engine}");
            Console.WriteLine($"Color of the {_model} : {Color.ColorType}");
            Console.WriteLine($"Type of Tires: {Tires.TiresType}");
            if (Accessories.Count > 0)
            {
                Console.WriteLine("Accessories:");
                foreach (var item in Accessories)
                {
                    Console.WriteLine($"  - {item}");
                }
            }
            Console.WriteLine($"--- Total Price: {GetPrice().ToString("C", CultureInfo.CurrentCulture)} ---");
            Console.WriteLine();
        }

        public abstract IVehicle ShallowCopy();
        public abstract IVehicle DeepCopy();
    }
}
