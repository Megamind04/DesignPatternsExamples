using Creational.Prototype.Entities.Vehicles;
using System.Collections;
using System.Collections.Generic;

namespace Creational.Prototype.Entities
{
    /// <summary>
    /// Collection of available vehicles.
    /// </summary>
    public class AvailableVehicles : IEnumerable<KeyValuePair<string, IVehicle>>
    {
        private readonly Dictionary<string, IVehicle> vehicles;
        /// <summary>
        /// Test data.
        /// </summary>
        public AvailableVehicles()
        {
            vehicles = new Dictionary<string, IVehicle>
            {
                { "AMG_C_43", new Car("AMG C 43", "AMG-enhaced 3.0L V6 bitturbo.", 53000.00f) },
                { "S_450_4MATIC", new Car("S 450 4MATIC", "AMG 3.0L V6 bitturbo.", 94000.00f) },
                { "E_450_4MATIC_Wagon", new Car("E 450 4MATIC Wagon", "AMG 3.0L V6 bitturbo.", 64000.00f) },
                { "Actors1", new Truck("Actors1", " Euro VI OM 471 - 7.7L.", 101000.00f, 10) },
                { "Atego", new Truck("Atego", " OM 904 LA - 6.3L.", 47000.00f, 6) },
                { "Antos", new Truck("Antos", "OM 470 - 10.7 ", 32000.00f, 6) },
                { "Tourismo", new Bus("Tourismo", "OM 470 Euro VI - 10.1L.", 227550.00f, 10) },
                { "TRAVEGO", new Bus("TRAVEGO", "OM 457 LA - 12.9L.", 172500.00f, 6) }
            };
        }
        /// <summary>
        /// Gets vehicle.
        /// </summary>
        /// <param name="key">string name of the vehicle.</param>
        /// <returns>vehicle.</returns>
        public IVehicle this[string key] => vehicles[key];
        /// <summary>
        /// Gets enumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<KeyValuePair<string, IVehicle>> GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
