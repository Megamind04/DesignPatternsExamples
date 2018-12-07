
namespace Creational.Prototype.Entities.Parts
{
    internal class Color
    {
        public string ColorType { get; set; }
        public float ColorPrice { get; set; }

        public Color(string color, float price)
        {
            ColorType = color; ColorPrice = price;
        }
    }
}
