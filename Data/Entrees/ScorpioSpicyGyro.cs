/*
 * ScorpioSpicyGyro.cs
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
    /// Scorpio Spicy Gyro
    /// </summary>
    public class ScorpioSpicyGyro
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        DonerMeat Meat { get; set; } = DonerMeat.Chicken;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public static bool Pita { get; set; } = true;

        /// <summary>
        /// Gyro should be served with peppers
        /// </summary>
        public static bool Peppers { get; set; } = true;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public static bool Onion { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public static bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public static bool WingSauce { get; set; } = true;

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public decimal Price { get; } = 6.20M;

        /// <summary>
        /// used to sum calories
        /// </summary>
        public uint calorieSum = 0;

        /// <summary>
        /// Calories for this gyro
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Pita != false)
                {
                    calorieSum += 262;
                }

                if (Peppers != false)
                {
                    calorieSum += 33;
                }

                if (Onion != false)
                {
                    calorieSum += 30;
                }

                if (Lettuce != false)
                {
                    calorieSum += 54;
                }

                if (WingSauce != false)
                {
                    calorieSum += 15;
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
        /// List of the bool properties
        /// </summary>
        public List<bool> listOfBools = new List<bool> { Pita, Peppers, Onion, Lettuce, WingSauce };
        public List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Peppers", "Onion", "Lettuce", "Wing Sauce" };

        /// <summary>
        /// Special Instructions
        /// </summary>
        IEnumerable<string> SpecialInstructions
        {
            get
            {
                for (int i = 0; i < listOfBools.Count; i++)
                {
                    if (listOfBools[i] == false)
                    {
                        yield return "Hold " + listOfBoolsAsStrings[i];
                    }
                }

                if (Meat != DonerMeat.Chicken)
                {
                    yield return "Use " + Meat;
                }
            }
        }

    }
}
