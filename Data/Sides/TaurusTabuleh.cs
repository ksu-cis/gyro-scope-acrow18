/*
 * TaurusTabuleh.cs
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
    /// Declares a class for the side Taurus Tabuleh
    /// </summary>
    public class TaurusTabuleh
    {
        /// <summary>
        /// How large a serving of Taurus Tabuleh is
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Price of Taurus Tabuleh
        /// (1.50 for S, 2.00 for M, 2.50 for L)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Calorie of fries 
        /// (124 for S, 186 for M, 248 for L)
        /// </summary>
        public uint Calories { get; }

    }
}

