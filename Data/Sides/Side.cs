/*
 * Side.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A base class for all treats sold at GyroScope
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// How large a serving of side
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Price of side
        /// </summary>
        public abstract decimal Price { get; set; }

        /// <summary>
        /// Calorie of side 
        /// </summary>
        public abstract uint Calories { get; }
    }
}
