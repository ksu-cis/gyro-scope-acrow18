/*
 * Treat.cs
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A base class for all treats sold at GyroScope
    /// </summary>
    public abstract class Treat
    {
        /// <summary>
        /// Size of treat
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Name of treat
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// The price of the treat
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat
        /// </summary>
        public abstract uint Calories { get; }
    }
}

