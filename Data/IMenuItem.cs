/*
 * IMenuItem.cs
 * Author: Alisha C.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data
{
    /// <summary>
    /// Implements interface
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// price of the menu item
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// calories of the menu item
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// special instructions for preparing the menu item
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }
    }
}
