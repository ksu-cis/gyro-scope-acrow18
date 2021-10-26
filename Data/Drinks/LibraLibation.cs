/*
 * LibraLibation.cs
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
/// Drinks
/// </summary>
namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// Libra Libation
    /// </summary>
    public class LibraLibation : Drink, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for flavor
        /// </summary>
        public LibraLibationFlavor _flavor = LibraLibationFlavor.PinkLemonada;

        /// <summary>
        /// Determines flavor of Libra Libation
        /// </summary>
        public LibraLibationFlavor Flavor 
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged(nameof(this.Flavor));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));

                }
            }
        }


        /// <summary>
        /// backing field for sparkling
        /// </summary>
        public bool _sparkling = true;

        /// <summary>
        /// Determines if its Sparkling or not
        /// </summary>
        public bool Sparkling 
        {
            get => _sparkling;
            set
            {
                if (_sparkling != value)
                {
                    _sparkling = value;
                    OnPropertyChanged(nameof(this.Name));
                    OnPropertyChanged(nameof(this.Sparkling));

                }
            }
        }

        /// <summary>
        /// backing field for honey
        /// </summary>
        public bool _honey;

        /// <summary>
        /// Determines if LibraLibation has honey.
        /// </summary>
        public bool Honey 
        {
            get => _honey;
            set
            {
                if (_honey != value)
                {
                    _honey = value;
                    OnPropertyChanged(nameof(this.Honey));

                }
            }
        }

        /// <summary>
        /// Calorie of Libra Libation
        /// </summary>
        public uint _calories;

        /// <summary>
        /// Calories of Libra Libation
        /// </summary>
        public override uint Calories 
        { 
            get 
            {
                if (Flavor == LibraLibationFlavor.Orangeade) 
                {
                    _calories = 180;
                }

                if (Flavor == LibraLibationFlavor.SourCherry)
                {
                    _calories = 100;
                }

                if (Flavor == LibraLibationFlavor.Biral)
                {
                    _calories = 120;
                }

                if (Flavor == LibraLibationFlavor.PinkLemonada)
                {
                    _calories = 41;
                }

                return _calories;
            } 
        }

        /// <summary>
        /// backing field for price
        /// </summary>
        public decimal _price = 1.00M;

        /// <summary>
        /// Price of Libra Libation
        /// </summary>
        public override decimal Price 
        {
            get => _price;
        }

        /// <summary>
        /// Greek Soda
        /// </summary>
        public override string Name
        {
            get
            {
                if (Sparkling != true)
                {
                    return $"Still {Flavor} Libra Libation";
                }
                else 
                {
                    return $"Sparkling {Flavor} Libra Libation";
                }
            }
        }

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        public override IEnumerable<string> SpecialInstructions => throw new NotImplementedException();
    }
}
