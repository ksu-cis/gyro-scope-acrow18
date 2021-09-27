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
    public abstract class Gyro : Entree
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public abstract DonerMeat Meat { get; set; }

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public bool Pita { get; set; }

        /// <summary>
        /// Gyro should be served with peppers
        /// </summary>
        public bool Peppers { get; set; }

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public bool Onion { get; set; }

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public bool Lettuce { get; set; }

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public bool WingSauce { get; set; }

        /// <summary>
        /// Gyro should be served with Tomato
        /// </summary>
        public bool Tomato { get; set; }

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public bool Eggplant { get; set; }

        /// <summary>
        /// Gyro should be served with Mint chutney
        /// </summary>
        public bool MintChutney { get; set; }

        /// <summary>
        /// Gyro should be served with Tzatziki sauce
        /// </summary>
        public bool Tzatziki { get; set; }

        /// <summary>
        /// Price of Entree
        /// </summary>
        public override abstract decimal Price { get; }

        /// <summary>
        /// Calories for this gyro
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calorieSum = 0;
                if (Pita != false)
                {
                    calorieSum += 262;
                }

                if (Tomato != false)
                {
                    calorieSum += 30;
                }

                if (Onion != false)
                {
                    calorieSum += 30;
                }

                if (Eggplant != false)
                {
                    calorieSum += 47;
                }

                if (Lettuce != false)
                {
                    calorieSum += 54;
                }

                if (MintChutney != false)
                {
                    calorieSum += 10;
                }

                if (WingSauce != false)
                {
                    calorieSum += 15;
                }

                if (Tzatziki != false)
                {
                    calorieSum += 30;
                }

                if (Meat == DonerMeat.Pork)
                {
                    calorieSum += 187;
                }

                if (Meat == DonerMeat.Lamb)
                {
                    calorieSum += 151;
                }

                if (Meat == DonerMeat.Chicken)
                {
                    calorieSum += 113;
                }

                if (Meat == DonerMeat.Beef)
                {
                    calorieSum += 181;
                }

                return calorieSum;
            }
        }

        /// <summary>
        /// Special instructions
        /// </summary>
        public override abstract IEnumerable<string> SpecialInstructions { get; }

    }
}
