/*
 * SagittariusGreekSalad.cs
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
    /// Declares a class for the side SagittariusGreekSalad
    /// </summary>
    public class SagittariusGreekSalad : Side
    {
        /// <summary>
        /// How large a serving of Greek Salad is
        /// </summary>
        public override Size Size { get; set; }


        /// <summary>
        /// Price of greek salad 
        /// </summary>
        public decimal price = 0;

        /// <summary>
        /// Price of Greek Salad
        /// (2.00 for S, 2.50 for M, 3.00 for L)
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    price = 2.00M;
                }

                if (Size == Size.Medium)
                {
                    price = 2.50M;
                }

                if (Size == Size.Large)
                {
                    price = 3.00M;
                }

                return price;
            }
        }

        /// <summary>
        /// Calories of greek salad
        /// </summary>
        public uint calories = 0;

        /// <summary>
        /// Calorie of greek salad
        /// (180 for S, 270 for M, 360 for L)
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    calories = 180;
                }

                if (Size == Size.Medium)
                {
                    calories = 270;
                }

                if (Size == Size.Large)
                {
                    calories = 360;
                }

                return calories;
            }

        }
    }
}
