/*
 * LeoLambGyro.cs
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
    /// Leo Lamb Gyro
    /// </summary>
    public class LeoLambGyro
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public DonerMeat Meat { get; set; } = DonerMeat.Lamb;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public static bool Pita { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Tomato
        /// </summary>
        public static bool Tomato { get; set; } = true;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public static bool Onion { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public static bool Eggplant { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public static bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Mint chutney
        /// </summary>
        public static bool MintChutney { get; set; } = true;

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public decimal Price { get; } = 5.75M;

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
        /// Special Instructions
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<bool> listOfBools = new List<bool> { Pita, Tomato, Onion, Eggplant, Lettuce, MintChutney };
                List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Tomato", "Onion", "Eggplant", "Lettuce", "Mint Chutney" };
                //add another list of ingredients to add.

                for (int i = 0; i < listOfBools.Count; i++)
                {
                    if (listOfBools[i] == false)
                    {
                        yield return "Hold " + listOfBoolsAsStrings[i];
                    }
                }

                if (Meat != DonerMeat.Lamb)
                {
                    yield return "Use " + Meat;
                }
            }
        }
    }
}
