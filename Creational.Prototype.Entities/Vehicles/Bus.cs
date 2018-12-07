using Creational.Prototype.Entities.Parts;
using System.Collections.Generic;

namespace Creational.Prototype.Entities.Vehicles
{
    internal class Bus : Vehicle
    {
        public Bus(string model, string engine, float price, int numOfTiresr) : base(model, engine, price)
        {
            _vehicleType = VehicleType.Bus;
            Color = new Color("White", 350.00f);
            Tires = new Tires("Original", numOfTiresr, 102.00f);
            Accessories = new List<Accessories>();
        }

        public override IVehicle ShallowCopy()
        {
            return MemberwiseClone() as IVehicle;
        }

        public override IVehicle DeepCopy()
        {
            Bus bus = ShallowCopy() as Bus;

            bus.Color = new Color(Color.ColorType, Color.ColorPrice);
            bus.Tires = new Tires(Tires.TiresType, Tires.NumberOFTires, Tires.TirePrice);

            return bus;
        }
    }
}
