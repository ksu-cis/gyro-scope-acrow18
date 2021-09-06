/*
 * VirgoClassicGyro.cs
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
    /// Virgo Classic Gyro
    /// </summary>
    public class VirgoClassicGyro<T>
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        DonerMeat Meat { get; set; } = DonerMeat.Pork;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public static bool Pita { get; set; } = true;

        /// <summary>
        /// Gyro should be served with tomato
        /// </summary>
        public static bool Tomato { get; set; } = true;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public static bool Onion { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public static bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Tzatziki sauce
        /// </summary>
        public static bool Tzatziki { get; set; } = true;

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public decimal Price { get; } = 5.50M;

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
                else if (Tomato != false) 
                {
                    calorieSum += 30;
                }
                else if (Onion != false)
                {
                    calorieSum += 30;
                }
                else if (Lettuce != false)
                {
                    calorieSum += 54;
                }
                else if (Tzatziki != false)
                {
                    calorieSum += 30;
                }

                return calorieSum;
            } 
        }

        /// <summary>
        /// List of the bool properties
        /// </summary>
        public List<bool> listOfBools = new List<bool>{ Pita, Tomato, Onion, Lettuce, Tzatziki };
        public List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Tomato", "Onion", "Lettuce", "Tzatziki"};

        /// <summary>
        /// Special Instructions
        /// </summary>
        IEnumerable<string> SpecialInstructions 
        {
            get 
            {
                for(int i = 0; i < listOfBools.Count; i++) 
                {
                    if (listOfBools[i] == false) 
                    {
                        yield return "Hold " + listOfBoolsAsStrings[i];
                    }
                }

                if (Meat != DonerMeat.Lamb) 
                {
                    yield return "Hold " + Meat;
                }
            } 
        }

    }
}
