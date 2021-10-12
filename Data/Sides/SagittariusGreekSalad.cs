/*
 * SagittariusGreekSalad.cs
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
    /// Declares a class for the side SagittariusGreekSalad
    /// </summary>
    public class SagittariusGreekSalad : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for size
        /// </summary>
        public Size _size = Size.Small;

        /// <summary>
        /// The size of this SaggitariusGreekSalad
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

                }
            }
        }

        /// <summary>
        /// Price of Greek Salad
        /// (2.00 for S, 2.50 for M, 3.00 for L)
        /// </summary>
        public override decimal Price
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 2.00M;
                }

                if (Size == Size.Medium)
                {
                    return 2.50M;
                }

                if (Size == Size.Large)
                {
                    return 3.00M;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

        /// <summary>
        /// Calories of greek salad
        /// </summary>
        public uint calories = 0;

        /// <summary>
        /// Calorie of greek salad
        /// (180 for S, 270 for M, 360 for L)
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 180;
                }

                if (Size == Size.Medium)
                {
                    return 270;
                }

                if (Size == Size.Large)
                {
                   return 360;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }

        }
    }
}
