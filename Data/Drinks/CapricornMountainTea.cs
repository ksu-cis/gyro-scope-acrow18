/*
 * CapricornMountainTea.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// Capricorn Mountain Tea
    /// </summary>
    public class CapricornMountainTea : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for price
        /// </summary>
        public decimal _price = 2.50M;

        /// <summary>
        /// Price of Capricorn Mountain Tea
        /// </summary>
        public override decimal Price 
        {
            get => _price;
        }
        

        /// <summary>
        /// Calories of Capricorn Mountain Tea
        /// </summary>
        public override uint Calories 
        { 
            get 
            {
                if (Honey == true)
                {
                    return 64;
                }

                else 
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// backing field for honey
        /// </summary>
        public bool _honey = false;

        /// <summary>
        /// Determines if Capricorn Mountain Tea has honey.
        /// </summary>
        public bool Honey
        {
            get => _honey;
            set
            {
                if (_honey != value)
                {
                    _honey = value;
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Honey));

                }
            }
        }

        /// <summary>
        /// backing field for name
        /// </summary>
        public string _name = "Capricorn Mountain Tea";

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
        /// No special instructions
        /// </summary>
        public override IEnumerable<string> SpecialInstructions { get; }


        /// <summary>
        /// backing field for description
        /// </summary>
        public string _description = "Tea brewed from the ironwort plant, a traditional herbal health enhancer.";

        /// <summary>
        /// Description of Capricorn Mountain Tea
        /// </summary>
        public override string Description { get => _description; }

    }
}
