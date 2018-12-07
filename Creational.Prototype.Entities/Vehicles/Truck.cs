using Creational.Prototype.Entities.Parts;
using System.Collections.Generic;

namespace Creational.Prototype.Entities.Vehicles
{
    internal class Truck : Vehicle
    {
        public Truck(string model, string engine, float price, int numOfTiresr) : base(model, engine, price)
        {
            _vehicleType = VehicleType.Truck;
            Color = new Color("White", 250.00f);
            Tires = new Tires("Original", numOfTiresr, 76.00f);
            Accessories = new List<Accessories>();
        }

        public override IVehicle ShallowCopy()
        {
            return MemberwiseClone() as IVehicle;
        }

        public override IVehicle DeepCopy()
        {
            Truck truck = ShallowCopy() as Truck;

            truck.Color = new Color(Color.ColorType, Color.ColorPrice);
            truck.Tires = new Tires(Tires.TiresType, Tires.NumberOFTires, Tires.TirePrice);

            return truck;
        }
    }
}
