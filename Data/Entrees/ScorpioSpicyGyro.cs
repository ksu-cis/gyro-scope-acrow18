﻿/*
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
    public class ScorpioSpicyGyro : Gyro, IMenuItem
    {

        public ScorpioSpicyGyro()
        {
            Meat = DonerMeat.Chicken;
            Pita = true;
            Tomato = false;
            Onion = true;
            Eggplant = false;
            Lettuce = true;
            MintChutney = false;
            Peppers = true;
            WingSauce = true;
            Tzatziki = false;
        }

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public override decimal Price { get; } = 6.20M;

       
       
        /// <summary>
        /// Special Instructions
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
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


        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return "Scorpio Spicy Gyro";
        }

    }
}
