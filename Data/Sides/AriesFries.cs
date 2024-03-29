﻿/*
 * AriesFries.cs
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
/// Sides
/// </summary>
namespace GyroScope.Data.Sides
{
    /// <summary>
    /// Declares a class for the side AresFries
    /// </summary>
    public class AriesFries : Side, IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// backing field for size
        /// </summary>
        public Size _size = Size.Small;

        /// <summary>
        /// The size of this Aries Fries
        /// </summary>
        public override Size Size
        {
            get => _size;
            set
            {
                if (_size != value)
                {
                    _size = value;
                    OnPropertyChanged(nameof(this.Size));
                    OnPropertyChanged(nameof(this.Price));
                    OnPropertyChanged(nameof(this.Calories));
                    OnPropertyChanged(nameof(this.Name));

                }
            }
        }

        /// <summary>
        /// Price of fries
        /// (1.50 for S, 2.00 for M, 2,50 for L)
        /// </summary>
        public override decimal Price 
        {
            get
            {   
                if (Size == Size.Small)
                {
                    return 1.50M;
                }

                if (Size == Size.Medium)
                {
                     return 2.00M;
                }

                if (Size == Size.Large)
                {
                    return 2.50M;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

        /// <summary>
        /// Calorie of fries 
        /// (304 for S, 456 for M, 608 for L)
        /// </summary>
        public override uint Calories 
        {
            get 
            { 
                if (Size == Size.Small) 
                {
                    return 304;
                }

                if (Size == Size.Medium)
                {
                    return 456;
                }

                if (Size == Size.Large)
                {
                    return 608;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

        /// <summary>
        /// backing field for name
        /// </summary>
        public string _name;

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            OnPropertyChanged(nameof(this.Name));
            return _name = $"{ Size} Aries Fries";
        }

        /// <summary>
        /// Same name as ToString
        /// </summary>
        public override string Name { get => $"{ Size} Aries Fries"; }

        /// <summary>
        /// backing field for description
        /// </summary>
        public string _description = "Crispy fried potatoes topped with feta cheese, onions, and herbs.";

        /// <summary>
        /// Description of Aries Fries
        /// </summary>
        public override string Description { get => _description; }

    }
}
