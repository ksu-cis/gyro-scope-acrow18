﻿/*
 * LibraLibation.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
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
    public class LibraLibation : Drink
    {
        /// <summary>
        /// backing field for flavor
        /// </summary>
        public LibraLibationFlavor _flavor;

        /// <summary>
        /// Determines flavor of Libra Libation
        /// </summary>
        public LibraLibationFlavor Flavor {
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
        public bool _sparkling;

        /// <summary>
        /// Determines if its Sparkling or not
        /// </summary>
        public bool Sparkling {
            get => _sparkling;
            set
            {
                if (_sparkling != value)
                {
                    _sparkling = value;
                    OnPropertyChanged(nameof(this.Name));

                }
            }
        } 

        /// <summary>
        /// Honey
        /// </summary>
        public bool Honey { get; set; } = false;

        /// <summary>
        /// Calorie of Libra Libation
        /// </summary>
        public uint Calorie;

        /// <summary>
        /// Calories of Libra Libation
        /// </summary>
        public override uint Calories 
        { 
            get 
            {
                if (Flavor == LibraLibationFlavor.Orangeade) 
                {
                    Calorie = 180;
                }

                if (Flavor == LibraLibationFlavor.SourCherry)
                {
                    Calorie = 100;
                }

                if (Flavor == LibraLibationFlavor.Biral)
                {
                    Calorie = 120;
                }

                if (Flavor == LibraLibationFlavor.PinkLemonada)
                {
                    Calorie = 41;
                }

                return Calorie;
            } 
        }

        /// <summary>
        /// Price of Libra Libation
        /// </summary>
        public override decimal Price { get; set; } = 1.00M;

        /// <summary>
        /// Greek Soda
        /// </summary>
        public String Name
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
    }
}
