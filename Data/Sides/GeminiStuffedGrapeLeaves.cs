/*
 * GeminiStuffedGrapeLeaves.cs
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
    /// Declares a class for the side GeminiStuffedGrapeLeaves
    /// </summary>
    public class GeminiStuffedGrapeLeaves : Side, INotifyPropertyChanged
    {
        /// <summary>
        /// backing field for size
        /// </summary>
        public Size _size = Size.Small;

        /// <summary>
        /// The size of this GeminiStuffedGrapeLeaves
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
        /// Price of stuffed grape leaves
        /// (1.50 for S, 2.00 for M, 2.50 for L)
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
        /// Calorie of stuffed grape leaves 
        /// (360 for S, 540 for M, 720 for L)
        /// </summary>
        public override uint Calories 
        {
            get
            {
                if (Size == Size.Small)
                {
                    return 360;
                }

                if (Size == Size.Medium)
                {
                    return 540;
                }

                if (Size == Size.Large)
                {
                    return 720;
                }

                throw new InvalidOperationException("Unknown size: " + Size);
            }
        }

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return "Gemini Stuffed Grape Leaves";
        }

    }
}

