/*
 * CancerHalvehCake.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// Cancer Halveh Cake
    /// </summary>
    public class CancerHalvaCake : Treat, IMenuItem, INotifyPropertyChanged
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
        /// Cancer Halva doesn't have a size
        /// </summary>
        public override Size Size
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
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
