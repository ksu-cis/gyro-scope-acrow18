/*
 * PiscesFishDish.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entrees
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Pisces Fish Dish
    /// </summary>
    public class PiscesFishDish
    {
        /// <summary>
        /// Price of Dish
        /// </summary>
        public decimal Price { get; } = 5.99M;

        /// <summary>
        /// Calorie of dish
        /// </summary>
        public uint Calories { get; } = 726;

        IEnumerable<string> SpecialInstructions { get; } = null;
    }
}
