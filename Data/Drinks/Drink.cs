using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// A base class for all Drinks sold at GyroScope
    /// </summary>
    public abstract class Drink : IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of drink
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// Calories of drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions
        /// </summary>
        public abstract IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// Name of drink
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
