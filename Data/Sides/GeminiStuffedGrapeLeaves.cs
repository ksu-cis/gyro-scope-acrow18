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
    public class GeminiStuffedGrapeLeaves
    {
        /// <summary>
        /// How large a serving of stuffed grape leaves is
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Price of stuffed grape leaves
        /// (1.50 for S, 2.00 for M, 2,50 for L)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Calorie of stuffed grape leaves 
        /// (360 for S, 540 for M, 720 for L)
        /// </summary>
        public uint Calories { get; }

    }
}

