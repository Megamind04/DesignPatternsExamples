using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Entities
{
    /// <summary>
    /// Represents types of vegetables.
    /// </summary>
    public enum Vegetable
    {
        ///<summary></summary>
        Lettuce,
        ///<summary></summary>
        Tomato,
        ///<summary></summary>
        Onion,
        ///<summary></summary>
        Peppers,
        ///<summary></summary>
        Cucumber,
        ///<summary></summary>
        ChilliPeppers,
        ///<summary></summary>
        GreenBeans
    }
    /// <summary>
    /// Represents types of meat.
    /// </summary>
    public enum MeatType
    {
        ///<summary></summary>
        Turkey,
        ///<summary></summary>
        Ham,
        ///<summary></summary>
        Chicken,
        ///<summary></summary>
        Beef,
        ///<summary></summary>
        Pork
    }
    /// <summary>
    /// Represents types of cheese.
    /// </summary>
    public enum CheeseType
    {
        ///<summary></summary>
        American,
        ///<summary></summary>
        Swiss,
        ///<summary></summary>
        Cheddar,
        ///<summary></summary>
        Provolone,
        ///<summary></summary>
        Mozzarella,
        ///<summary></summary>
        NoCheese
    }
    /// <summary>
    /// Represents types of bread.
    /// </summary>
    public enum BreadType
    {
        ///<summary></summary>
        White,
        ///<summary></summary>
        Brown
    }
    /// <summary>
    /// Abstract Produc
    /// </summary>
    public interface ISandwich
    {
        /// <summary>
        /// Display info.
        /// </summary>
        void Display();
    }
}
