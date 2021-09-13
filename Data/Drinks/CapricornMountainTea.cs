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
        public override bool Honey { get; set; } = false;

        /// <summary>
        /// Flavor
        /// </summary>
        public override LibraLibationFlavor Flavor { get; set; }

        /// <summary>
        /// Sparkling
        /// </summary>
        public override bool Sparkling { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public override string Name { get; } = "";

        /// <summary>
        /// Calorie
        /// </summary>
        public uint Calorie = 0;

    }
}
