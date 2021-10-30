/*
 * RegisterViewModel.cs
 * Author: Alisha C.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data
{
    public class RegisterViewModel
    {

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

        /// <summary>
        /// backing field for pennies
        /// </summary>
        public int _pennies;

        /// <summary>
        /// Pennies in cash register
        /// </summary>
        public decimal Pennies
        {
            get { return _pennies; }

            set
            {
                if (_pennies != value)
                {
                    _pennies = (int)value;
                    OnPropertyChanged(nameof(Pennies));
                }
            }
        }

        /// <summary>
        /// backing field for nickels
        /// </summary>
        public int _nickels;

        /// <summary>
        /// Nickels in cash register
        /// </summary>
        public decimal Nickels
        {
            get { return _nickels; }

            set
            {
                if (_nickels != value)
                {
                    _nickels = (int)value;
                    OnPropertyChanged(nameof(Nickels));
                }
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _dimes;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Dimes
        {
            get { return _dimes; }

            set
            {
                if (_dimes != value)
                {
                    _dimes = (int)value;
                    OnPropertyChanged(nameof(Dimes));
                }
            }
        }
    }
}
