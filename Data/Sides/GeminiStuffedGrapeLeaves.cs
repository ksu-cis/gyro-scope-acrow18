/*
 * GeminiStuffedGrapeLeaves.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Sides
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// Declares a class for the side GeminiStuffedGrapeLeaves
    /// </summary>
    public class GeminiStuffedGrapeLeaves : Side
    {
        /// <summary>
        /// How large a serving of stuffed grape leaves is
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Price of stuffed grape leaves
        /// </summary>
        public decimal price = 0;

        /// <summary>
        /// Price of stuffed grape leaves
        /// (1.50 for S, 2.00 for M, 2.50 for L)
        /// </summary>
        public override decimal Price 
        {
            get 
            {
                if (Size == Size.Small)
                {
                    price = 1.50M;
                }

                if (Size == Size.Medium)
                {
                    price = 2.00M;
                }

                if (Size == Size.Large)
                {
                    price = 2.50M;
                }

                return price;
            }
        }


        /// <summary>
        /// Calories of stuffed grape leaves
        /// </summary>
        public uint calories = 0;

        /// <summary>
        /// Calorie of stuffed grape leaves 
        /// (360 for S, 540 for M, 720 for L)
        /// </summary>
        public override uint Calories 
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 360;
                }

                if (Size == Size.Medium)
                {
                    calories = 540;
                }

                if (Size == Size.Large)
                {
                    calories = 720;
                }

                return calories;
            }
        }

    }
}

