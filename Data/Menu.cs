/*
 * Menu.cs
 * Author: ALisha C.
 */
using GyroScope.Data.Entrees;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GyroScope.Data
{
    /// <summary>
    /// Static class for the menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Gets a list of the entrees
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees 
        { 
            get 
            {
                var entrees = new List<IMenuItem>();
                entrees.Add(new VirgoClassicGyro());
                entrees.Add(new LeoLambGyro());
                entrees.Add(new ScorpioSpicyGyro());
                entrees.Add(new PiscesFishDish());
                return entrees;
            }
        }

        /// <summary>
        /// Gets a list of the sides
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            //change foreach
            get
            {
                var sides = new List<IMenuItem>();
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new AriesFries() { Size = size });
                    sides.Add(new GeminiStuffedGrapeLeaves() { Size = size });
                    sides.Add(new SagittariusGreekSalad() { Size = size });
                    sides.Add(new TaurusTabuleh() { Size = size });
                }

                return sides;
            }
        }

        /// <summary>
        /// Gets a list of drinks 
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks { get;  }

        /// <summary>
        /// Gets a list of drinks 
        /// </summary>
        public static IEnumerable<IMenuItem> Treats { get;  }

        /// <summary>
        /// Gets a full menu list of all gyro scope options
        /// </summary>
        public static IEnumerable<IMenuItem> FullMenu { get; }
    }
}
