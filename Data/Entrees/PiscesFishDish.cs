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
    public class PiscesFishDish : Entree
    {
        /// <summary>
        /// Price of Dish
        /// </summary>
        public override decimal Price { get; } = 5.99M;

        /// <summary>
        /// Calorie of dish
        /// </summary>
        public override uint Calories { get; } = 726;

        /// <summary>
        /// Special instructions
        /// </summary>
        public override IEnumerable<string> SpecialInstructions { get; } = null;
    }
}
