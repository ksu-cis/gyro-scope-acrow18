/*
 * VirgoClassicGyro.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public class VirgoClassicGyro : Gyro, IMenuItem, INotifyPropertyChanged
    {

        public VirgoClassicGyro()
        {
            Meat = DonerMeat.Pork;
            Pita = true;
            Tomato = true;
            Onion = true;
            Eggplant = false;
            Lettuce = true;
            MintChutney = false;
            Peppers = false;
            WingSauce = false;
            Tzatziki = true;
        }


        /// <summary>
        /// Price of Gyro
        /// </summary>
        public override decimal Price { get; } = 5.50M;
        

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
                }

                if (Meat != DonerMeat.Pork)
                {
                    yield return "Use " + Meat;
                }
            }
        }

        /// <summary>
        /// backing field for name
        /// </summary>
        public string _name = "Virgo Classic Gyro";

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return _name;
        }

        /// <summary>
        /// Same name as ToString
        /// </summary>
        public override string Name { get => _name; }


        /// <summary>
        /// backing field for description
        /// </summary>
        public string _description = "The classic American gyro - seasoned doner pork, fresh sliced tomato, diced onion, " +
            "shredded lettuce, and tzatziki sauce, wrapped in a warm flaky pita.";

        /// <summary>
        /// Description of Virgo Classic Gyro
        /// </summary>
        public override string Description { get => _description; }
    }
}
