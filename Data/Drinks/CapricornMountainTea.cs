/*
 * CapricornMountainTea.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// Capricorn Mountain Tea
    /// </summary>
    public class CapricornMountainTea
    {
        /// <summary>
        /// Price of Capricorn Mountain Tea
        /// </summary>
        public decimal Price { get; set; } = 2.50M;

        /// <summary>
        /// Calories of Capricorn Mountain Tea
        /// </summary>
        public uint Calories = 0;

        /// <summary>
        /// Determines if Capricorn Mountain Tea has honey.
        /// </summary>
        public bool Honey { get; set; } = false;

        /// <summary>
        /// Checks if Honey was added
        /// </summary>
        public uint IsHoney
        {
            get
            {
                if (Honey == true) 
                {
                    return Calories = 64;
                }

                return Calories;
            }
        }
    }
}
