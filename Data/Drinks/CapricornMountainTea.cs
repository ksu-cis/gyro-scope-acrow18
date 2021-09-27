/*
 * CapricornMountainTea.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
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
    public class CapricornMountainTea : Drink
    {
        /// <summary>
        /// Price of Capricorn Mountain Tea
        /// </summary>
        public override decimal Price { get; set; } = 2.50M;

        /// <summary>
        /// Calories of Capricorn Mountain Tea
        /// </summary>
        public override uint Calories 
        { 
            get 
            {
                if (Honey == true)
                {
                    return 64;
                }

                else 
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Determines if Capricorn Mountain Tea has honey.
        /// </summary>
        public bool Honey { get; set; } = false;

    }
}
