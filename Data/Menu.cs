/*
 * Menu.cs
 * Author: ALisha C.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GyroScope.Data
{
    /// <summary>
    /// Static class for the menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets a list of the entrees
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees { get; set; }

        /// <summary>
        /// Gets a list of the sides
        /// </summary>
        public static IEnumerable<IMenuItem> Sides{ get; set; }

        /// <summary>
        /// Gets a list of drinks 
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks { get; set; }

        /// <summary>
        /// Gets a list of drinks 
        /// </summary>
        public static IEnumerable<IMenuItem> Treats { get; set; }

        /// <summary>
        /// Gets a full menu list of all gyro scope options
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu { get; set; }
    }
}
