/*
 * Gyro.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
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
    /// A base class for all Gyros sold at GyroScope
    /// </summary>
    public abstract class Gyro
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public abstract DonerMeat Meat { get; set; }

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public abstract bool Pita { get; set; }

        /// <summary>
        /// Gyro should be served with peppers
        /// </summary>
        public abstract bool Peppers { get; set; }

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public abstract bool Onion { get; set; }

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public abstract bool Lettuce { get; set; }

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public abstract bool WingSauce { get; set; }

        /// <summary>
        /// Gyro should be served with Tomato
        /// </summary>
        public abstract bool Tomato { get; set; }

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public abstract bool Eggplant { get; set; }

        /// <summary>
        /// Gyro should be served with Mint chutney
        /// </summary>
        public abstract bool MintChutney { get; set; }

        /// <summary>
        /// Gyro should be served with Tzatziki sauce
        /// </summary>
        public abstract bool Tzatziki { get; set; }
    }
}
