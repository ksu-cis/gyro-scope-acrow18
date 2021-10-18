/*
 * CancerHalvehCake.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// Cancer Halveh Cake
    /// </summary>
    public class CancerHalvaCake : Treat, IMenuItem
    {
        /// <summary>
        /// Price of Cancer Halveh Cake
        /// </summary>
        public override decimal Price => 3.00M;

        /// <summary>
        /// Calories of Cancer Halveh Cake
        /// </summary>
        public override uint Calories => 272;

        /// <summary>
        /// backing field for size
        /// </summary>
        public Size _size = 0;

        /// <summary>
        /// The size of this Cancer Halva cake
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
                }
            }
        }

        /// <summary>
        /// Name of Halveh Cake
        /// </summary>
        public override string Name { get; } = "";

        /// <summary>
        /// Overridden ToString
        /// </summary>
        /// <returns>Descriptive name</returns>
        public override string ToString()
        {
            return "Cancer Halva Cake";
        }

        
    }
}
