using Creational.Prototype.Entities.Parts;
using System.Collections.Generic;

namespace Creational.Prototype.Entities.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string model, string engine, float price) : base(model, engine, price)
        {
            _vehicleType = VehicleType.Car;
            Color = new Color("White", 150.00f);
            Tires = new Tires("Original", 4, 46.00f);
            Accessories = new List<Accessories>();
        }

        public override IVehicle ShallowCopy()
        {
            return MemberwiseClone() as IVehicle;
        }

        public override IVehicle DeepCopy()
        {
            Car car = ShallowCopy() as Car;

            car.Color = new Color(Color.ColorType, Color.ColorPrice);
            car.Tires = new Tires(Tires.TiresType, Tires.NumberOFTires, Tires.TirePrice);

            return car;
        }
    }
}
