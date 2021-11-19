/*
 * Entree.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Entree
/// </summary>
namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// Entree base class
    /// </summary>
    public abstract class Entree : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price of Entree
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Calories of Entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// Name of Entree
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Description of entree
        /// </summary>
        public abstract string Description { get; }

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
