
namespace Creational.Prototype.Entities.Parts
{
    internal class Tires
    {
        public string TiresType { get; set; }
        public float TirePrice { get; set; }
        public int NumberOFTires { get; set; }

        public Tires(string type, int numOfTires, float price)
        {
            TiresType = type; NumberOFTires = numOfTires; TirePrice = price;
        }

        public float GetPrice()
        {
            return TirePrice * NumberOFTires;
        }
    }
}
