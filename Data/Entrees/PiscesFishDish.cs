/*
 * PiscesFishDish.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class PiscesFishDish : Entree, IMenuItem, INotifyPropertyChanged
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

        /// <summary>
        /// backing field for name
        /// </summary>
        public string _name = "Pisces Fish Dish";

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// Same name as ToString
        /// </summary>
        public override string Name { get => _name; }

        /// <summary>
        /// backing field for description
        /// </summary>
        public string _description = "Halibut baked with onions and tomatoes in a red wine sauce.";

        /// <summary>
        /// Description of Libra Libation
        /// </summary>
        public override string Description { get => _description; }
    }
}
