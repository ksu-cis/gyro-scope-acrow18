/*
 * Side.cs
 * Author: Alisha C.
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A base class for all sides sold at GyroScope
    /// </summary>
    public abstract class Side : IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Notifies when a property of this class changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Size of treat
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Price of side
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Calorie of side 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Name of Side
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Used to trigger a property changed event
        /// </summary>
        /// <param name="propertyName">The name of property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        public IEnumerable<string> SpecialInstructions => throw new NotImplementedException();
    }
}
