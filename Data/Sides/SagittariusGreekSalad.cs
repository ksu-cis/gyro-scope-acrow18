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
        /// Price of Greek Salad
        /// (2.00 for S, 2.50 for M, 3.00 for L)
        /// </summary>
        public override decimal Price { get; set; }

        /// <summary>
        /// Calorie of Greek Salad
        /// (180 for S, 270 for M, 360 for L)
        /// </summary>
        public override uint Calories { get; }

    }
}
