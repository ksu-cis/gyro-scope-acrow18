/*
 * Entree.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entree
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Entree base class
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Price of Entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Calories of Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }
    }
}
