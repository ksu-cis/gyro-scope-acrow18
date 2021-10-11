/*
 * Treat.cs
 */

using GyroScope.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A base class for all treats sold at GyroScope
    /// </summary>
    public abstract class Treat : INotifyPropertyChanged
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
        /// Name of treat
        /// </summary>
        public abstract String Name { get; }

        /// <summary>
        /// The price of the treat
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Used to trigger a property changed event
        /// </summary>
        /// <param name="propertyName">The name of property that is changing</param>
        protected void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

