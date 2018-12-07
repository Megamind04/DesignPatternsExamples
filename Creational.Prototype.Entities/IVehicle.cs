
namespace Creational.Prototype.Entities
{
    /// <summary>
    /// Type of Vehicle.
    /// </summary>
    public enum VehicleType
    {
        /// <value>Car.</value>
        Car,
        /// <value>Truck.</value>
        Truck,
        /// <value>Bus.</value>
        Bus
    }
    /// <summary>
    /// Accessories to add.
    /// </summary>
    public enum Accessories
    {
        /// <value>Alarm price-300$.</value>
        Alarm = 300,
        /// <value>Stereo price-150$.</value>
        Stereo = 150,
        /// <value>Speakers price-200$.</value>
        Speakers = 200,
        /// <value>GPS price-120$.</value>
        GPS = 120,
        /// <value>A/C price-280$.</value>
        A_C = 280
    }
    /// <summary>
    /// Abstract Produc
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// Get Shallow Copy.
        /// </summary>
        /// <returns></returns>
        IVehicle ShallowCopy();
        /// <summary>
        /// Get Deep Copy.
        /// </summary>
        /// <returns></returns>
        IVehicle DeepCopy();
        /// <summary>
        /// Change color of the vehicle.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="price">extra price for color.</param>
        void ChooseColor(string color, float price);
        /// <summary>
        /// Change tires of the vehicle.
        /// </summary>
        /// <param name="tiresType">tires type.</param>
        /// <param name="price">extra price for tires.</param>
        void ChooseTires(string tiresType, float price);
        /// <summary>
        /// Adds accessories.
        /// </summary>
        /// <param name="accessories">extra parts.</param>
        void ChooseAccessories(params Accessories[] accessories);
        /// <summary>
        /// Calculates the full price.
        /// </summary>
        /// <returns>price of the vehicle.</returns>
        float GetPrice();
        /// <summary>
        /// Gets info.
        /// </summary>
        void DisplayInfo();
    }
}
