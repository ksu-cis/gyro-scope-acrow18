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
    public class LeoLambGyro : Gyro
    {

        public LeoLambGyro() 
        {
            Meat = DonerMeat.Lamb;
            Pita = true;
            Tomato = true;
            Onion = true;
            Eggplant = true;
            Lettuce = true;
            MintChutney = true;
            Peppers = false;
            WingSauce = true;
            Tzatziki = false;
        }

        /// <summary>
        /// Price of Gyro
        /// </summary>
        public override decimal Price { get; } = 5.75M;

        /// <summary>
        /// used to sum calories
        /// </summary>
        public uint calorieSum = 0;

         
        /// <summary>
        /// Special Instructions
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                List<bool> listOfBools = new List<bool> { Pita, Tomato, Onion, Eggplant, Lettuce, MintChutney };
                List<string> listOfBoolsAsStrings = new List<string> { "Pita", "Tomato", "Onion", "Eggplant", "Lettuce", "Mint Chutney" };
                
                //add another list of ingredients to add.
                List<bool> listOfBoolsToAdd = new List<bool> {Peppers, WingSauce, Tzatziki};
                List<string> listOfBoolsToAddAsStrings = new List<string> { "Peppers", "WingSauce", "Tzatziki"};

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

                if (Meat != DonerMeat.Lamb)
                {
                    yield return "Use " + Meat;
                }
            }
        }

    }
}
