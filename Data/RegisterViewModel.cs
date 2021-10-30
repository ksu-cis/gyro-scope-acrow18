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

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _quarters;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Quarters
        {
            get { return _quarters; }

            set
            {
                if (_quarters != value)
                {
                    _quarters = (int)value;
                    OnPropertyChanged(nameof(Quarters));
                }
            }
        }


        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _halfDollars;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal HalfDollars
        {
            get { return _halfDollars; }

            set
            {
                if (_halfDollars != value)
                {
                    _halfDollars = (int)value;
                    OnPropertyChanged(nameof(HalfDollars));
                }
            }
        }


        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _dollars;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Dollars
        {
            get { return _dollars; }

            set
            {
                if (_dollars != value)
                {
                    _dollars = (int)value;
                    OnPropertyChanged(nameof(Dollars));
                }
            }
        }


        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _ones;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Ones
        {
            get { return _ones; }

            set
            {
                if (_ones != value)
                {
                    _ones = (int)value;
                    OnPropertyChanged(nameof(Ones));
                }
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _twos;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Twos
        {
            get { return _twos; }

            set
            {
                if (_twos != value)
                {
                    _twos = (int)value;
                    OnPropertyChanged(nameof(Twos));
                }
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _fives;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal Fives
        {
            get { return _fives; }

            set
            {
                if (_fives != value)
                {
                    _fives = (int)value;
                    OnPropertyChanged(nameof(Fives));
                }
            }
        }
    }
}
