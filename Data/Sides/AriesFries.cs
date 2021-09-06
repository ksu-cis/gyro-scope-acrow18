/*
 * AriesFries.cs
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
    /// Declares a class for the side AresFries
    /// </summary>
    public class AriesFries
    {
        /// <summary>
        /// How large a serving of fries is
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Price of fries
        /// (1.50 for S, 2.00 for M, 2,50 for L)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Calorie of fries 
        /// (304 for S, 456 for M, 608 for L)
        /// </summary>
        public uint Calories { get; }

    }
}
