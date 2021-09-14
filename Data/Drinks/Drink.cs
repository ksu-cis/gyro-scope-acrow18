using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// A base class for all Drinks sold at GyroScope
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Price of drink
        /// </summary>
        public abstract decimal Price { get; set; }

        /// <summary>
        /// Calories of Capricorn Mountain Tea
        /// </summary>
        public abstract uint Calories { get; }

    }
}
