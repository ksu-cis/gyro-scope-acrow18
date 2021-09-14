﻿/*
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
    public class VirgoClassicGyro : Gyro
    {
        /// <summary>
        /// What kind of meat this Gyro is prepared with
        /// </summary>
        public override DonerMeat Meat { get; set; } = DonerMeat.Pork;

        /// <summary>
        /// Gyro should be served with a pita bread wrap
        /// </summary>
        public override bool Pita { get; set; } = true;

        /// <summary>
        /// Gyro should be served with tomato
        /// </summary>
        public override bool Tomato { get; set; } = true;

        /// <summary>
        /// Gyro should be served with onion
        /// </summary>
        public override bool Onion { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Lettuce
        /// </summary>
        public override bool Lettuce { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Tzatziki sauce
        /// </summary>
        public override bool Tzatziki { get; set; } = true;

        /// <summary>
        /// Gyro should be served with Peppers
        /// </summary>
        public override bool Peppers { get; set; } = false;

        /// <summary>
        /// Gyro should be served with Wing sauce
        /// </summary>
        public override bool WingSauce { get; set; } = false;

        /// <summary>
        /// Gyro should be served with Eggplant
        /// </summary>
        public override bool Eggplant { get; set; } = false;

        /// <summary>
        /// Gyro should be served with MintChutney
        /// </summary>
        public override bool MintChutney { get; set; } = false;

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public override decimal Price { get; } = 5.50M;

        /// <summary>
        /// used to sum calories
        /// </summary>
        public uint calorieSum = 0;

        /// <summary>
        /// Calories for this gyro
        /// </summary>
        public override uint Calories 
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
                
                if (Lettuce != false)
                {
                    calorieSum += 54;
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
        /// Special Instructions
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<bool> listOfBools = new List<bool> { Pita, Tomato, Onion, Lettuce, Tzatziki };
                List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Tomato", "Onion", "Lettuce", "Tzatziki" };

                //add another list of ingredients to add.
                List<bool> listOfBoolsToAdd = new List<bool> { Peppers, WingSauce, Eggplant, MintChutney };
                List<string> listOfBoolsToAddAsStrings = new List<string> { "Peppers", "WingSauce", "Eggplant", "MintChutney" };

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

                    if (Meat != DonerMeat.Pork)
                    {
                        yield return "Use " + Meat;
                    }
                }
            }
        }
    }
}
