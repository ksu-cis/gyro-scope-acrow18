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
    public class ScorpioSpicyGyro : Gyro
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public override DonerMeat Meat { get; set; } = DonerMeat.Chicken;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public override bool Pita { get; set; } = true;

        /// <summary>
        /// Gyro should be served with peppers
        /// </summary>
        public override bool Peppers { get; set; } = true;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public override bool Onion { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public override bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public override bool WingSauce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Tomato
        /// </summary>
        public override bool Tomato { get; set; } = false;

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public override bool Eggplant { get; set; } = false;

        /// <summary>
        /// Gyro should be served with Mint chutney
        /// </summary>
        public override bool MintChutney { get; set; } = false;

        /// <summary>
        /// Gyro should be served with Tzatziki
        /// </summary>
        public override bool Tzatziki { get; set; } = false;

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
        /// Special Instructions
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<bool> listOfBools = new List<bool> { Pita, Peppers, Onion, Lettuce, WingSauce };
                List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Peppers", "Onion", "Lettuce", "Wing Sauce" };

                //add another list of ingredients to add.
                List<bool> listOfBoolsToAdd = new List<bool> { Tomato, Eggplant, MintChutney, Tzatziki };
                List<string> listOfBoolsToAddAsStrings = new List<string> { "Tomato", "Eggplant", "MintChutney", "Tzatziki" };


                for (int i = 0; i < listOfBools.Count; i++)
                {
                    if (listOfBools[i] == false)
                    {
                        yield return "Hold " + listOfBoolsAsStrings[i];
                    }
                }

                //used to add extra ingredients
                for (int i = 0; i < listOfBoolsToAdd.Count; i++)
                {
                    if (listOfBoolsToAdd[i] == true)
                    {
                        yield return "Add " + listOfBoolsToAddAsStrings[i];
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
