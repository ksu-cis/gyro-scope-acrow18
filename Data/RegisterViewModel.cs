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
using RoundRegister;

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

        //Beginning of cash drawer properties

        /// <summary>
        /// Pennies in cash register
        /// </summary>
        public decimal CashDrawerPennies => CashDrawer.Pennies;

        /// <summary>
        /// Nickels in cash register
        /// </summary>
        public decimal CashDrawerNickels => CashDrawer.Nickels;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal CashDrawerDimes => CashDrawer.Dimes;

        /// <summary>
        /// Quarters in cash register
        /// </summary>
        public decimal CashDrawerQuarters => CashDrawer.Quarters;

        /// <summary>
        /// Half dollars in cash register
        /// </summary>
        public decimal CashDrawerHalfDollars => CashDrawer.HalfDollars;

        /// <summary>
        /// Dollars in cash register
        /// </summary>
        public decimal CashDrawerDollarsInCents => CashDrawer.Dollars;

        /// <summary>
        /// Ones in cash register
        /// </summary>
        public decimal CashDrawerOnes => CashDrawer.Ones;

        /// <summary>
        /// Twos in cash register
        /// </summary>
        public decimal CashDrawerTwos => CashDrawer.Twos;

        /// <summary>
        /// Fives in cash register
        /// </summary>
        public decimal CashDrawerFives => CashDrawer.Fives;

        /// <summary>
        /// Tens in cash register
        /// </summary>
        public decimal CashDrawerTens => CashDrawer.Tens;

        /// <summary>
        /// Twenties in cash register
        /// </summary>
        public decimal CashDrawerTwenties => CashDrawer.Twenties;

        /// <summary>
        /// Fifties in cash register
        /// </summary>
        public decimal CashDrawerFifties => CashDrawer.Fifties;

        /// <summary>
        /// Hundreds in cash register
        /// </summary>
        public decimal CashDrawerHundreds => CashDrawer.Hundreds;

        /// <summary>
        /// Total of Cash drawer
        /// </summary>
        public int Total { get; }

        /// <summary>
        /// Used to open drawer 
        /// </summary>
        public void OpenDrawer() 
        {

        }

        //End of cashdrawer properties

        
        /// <summary>
        /// backing field for pennies
        /// </summary>
        public int _customerPennies;

        /// <summary>
        /// Pennies in cash register
        /// </summary>
        public decimal CustomerPennies
        {
            get { return _customerPennies; }

            set
            {
                if (_customerPennies != value)
                {
                    _customerPennies = (int)value;
                    OnPropertyChanged(nameof(CustomerPennies));
                }
            }
        }

        /// <summary>
        /// backing field for nickels
        /// </summary>
        public int _customerNickels;

        /// <summary>
        /// Nickels in cash register
        /// </summary>
        public decimal CustomerNickels
        {
            get { return _customerNickels; }

            set
            {
                if (_customerNickels != value)
                {
                    _customerNickels = (int)value;
                    OnPropertyChanged(nameof(CustomerNickels));
                }
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _customerDimes;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public decimal CustomerDimes
        {
            get { return _customerDimes; }

            set
            {
                if (_customerDimes != value)
                {
                    _customerDimes = (int)value;
                    OnPropertyChanged(nameof(CustomerDimes));
                }
            }
        }

        /// <summary>
        /// backing field for quarters
        /// </summary>
        public int _customerQuarters;

        /// <summary>
        /// Quarters in cash register
        /// </summary>
        public decimal CustomerQuarters
        {
            get { return _customerQuarters; }

            set
            {
                if (_customerQuarters != value)
                {
                    _customerQuarters = (int)value;
                    OnPropertyChanged(nameof(CustomerQuarters));
                }
            }
        }


        /// <summary>
        /// backing field for half dollars
        /// </summary>
        public int _customerHalfDollars;

        /// <summary>
        /// Half Dollars in cash register
        /// </summary>
        public decimal CustomerHalfDollars
        {
            get { return _customerHalfDollars; }

            set
            {
                if (_customerHalfDollars != value)
                {
                    _customerHalfDollars = (int)value;
                    OnPropertyChanged(nameof(CustomerHalfDollars));
                }
            }
        }


        /// <summary>
        /// backing field for dollars (cents)
        /// </summary>
        public int _customerDollars;

        /// <summary>
        /// Dollars (cents) in cash register
        /// </summary>
        public decimal CustomerDollars
        {
            get { return _customerDollars; }

            set
            {
                if (_customerDollars != value)
                {
                    _customerDollars = (int)value;
                    OnPropertyChanged(nameof(CustomerDollars));
                }
            }
        }


        /// <summary>
        /// backing field for one dollar bills
        /// </summary>
        public int _customerOnes;

        /// <summary>
        /// One dollar bills in cash register
        /// </summary>
        public decimal CustomerOnes
        {
            get { return _customerOnes; }

            set
            {
                if (_customerOnes != value)
                {
                    _customerOnes = (int)value;
                    OnPropertyChanged(nameof(CustomerOnes));
                }
            }
        }

        /// <summary>
        /// backing field for two dollar bills
        /// </summary>
        public int _twos;

        /// <summary>
        /// Two dollar bills in cash register
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
        /// backing field for five dollar bills
        /// </summary>
        public int _fives;

        /// <summary>
        /// Five dollar bills in cash register
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

        /// <summary>
        /// backing field for ten dollar bills
        /// </summary>
        public int _tens;

        /// <summary>
        /// Ten dollar bills in cash register
        /// </summary>
        public decimal Tens
        {
            get { return _tens; }

            set
            {
                if (_tens != value)
                {
                    _tens = (int)value;
                    OnPropertyChanged(nameof(Tens));
                }
            }
        }


        /// <summary>
        /// backing field for twenty dollar bills
        /// </summary>
        public int _twenties;

        /// <summary>
        /// Twenty dollar bills in cash register
        /// </summary>
        public decimal Twenties
        {
            get { return _twenties; }

            set
            {
                if (_twenties != value)
                {
                    _twenties = (int)value;
                    OnPropertyChanged(nameof(Twenties));
                }
            }
        }

        /// <summary>
        /// backing field for fifty dollar bills
        /// </summary>
        public int _fifties;

        /// <summary>
        /// Fity dollar bills in cash register
        /// </summary>
        public decimal Fifties
        {
            get { return _fifties; }

            set
            {
                if (_fifties != value)
                {
                    _fifties = (int)value;
                    OnPropertyChanged(nameof(Fifties));
                }
            }
        }

        /// <summary>
        /// backing field for one hundred dollar bills
        /// </summary>
        public int _hundreds;

        /// <summary>
        /// One hundred dollar bills in cash register
        /// </summary>
        public decimal Hundreds
        {
            get { return _hundreds; }

            set
            {
                if (_hundreds != value)
                {
                    _hundreds = (int)value;
                    OnPropertyChanged(nameof(Hundreds));
                }
            }
        }

        /*
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
        /// backing field for quarters
        /// </summary>
        public int _quarters;

        /// <summary>
        /// Quarters in cash register
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
        /// backing field for half dollars
        /// </summary>
        public int _halfDollars;

        /// <summary>
        /// Half Dollars in cash register
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
        /// backing field for dollars (cents)
        /// </summary>
        public int _dollars;

        /// <summary>
        /// Dollars (cents) in cash register
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
        /// backing field for one dollar bills
        /// </summary>
        public int _ones;

        /// <summary>
        /// One dollar bills in cash register
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
        /// backing field for two dollar bills
        /// </summary>
        public int _twos;

        /// <summary>
        /// Two dollar bills in cash register
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
        /// backing field for five dollar bills
        /// </summary>
        public int _fives;

        /// <summary>
        /// Five dollar bills in cash register
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

        /// <summary>
        /// backing field for ten dollar bills
        /// </summary>
        public int _tens;

        /// <summary>
        /// Ten dollar bills in cash register
        /// </summary>
        public decimal Tens
        {
            get { return _tens; }

            set
            {
                if (_tens != value)
                {
                    _tens = (int)value;
                    OnPropertyChanged(nameof(Tens));
                }
            }
        }


        /// <summary>
        /// backing field for twenty dollar bills
        /// </summary>
        public int _twenties;

        /// <summary>
        /// Twenty dollar bills in cash register
        /// </summary>
        public decimal Twenties
        {
            get { return _twenties; }

            set
            {
                if (_twenties != value)
                {
                    _twenties = (int)value;
                    OnPropertyChanged(nameof(Twenties));
                }
            }
        }

        /// <summary>
        /// backing field for fifty dollar bills
        /// </summary>
        public int _fifties;

        /// <summary>
        /// Fity dollar bills in cash register
        /// </summary>
        public decimal Fifties
        {
            get { return _fifties; }

            set
            {
                if (_fifties != value)
                {
                    _fifties = (int)value;
                    OnPropertyChanged(nameof(Fifties));
                }
            }
        }

        /// <summary>
        /// backing field for one hundred dollar bills
        /// </summary>
        public int _hundreds;

        /// <summary>
        /// One hundred dollar bills in cash register
        /// </summary>
        public decimal Hundreds
        {
            get { return _hundreds; }

            set
            {
                if (_hundreds != value)
                {
                    _hundreds = (int)value;
                    OnPropertyChanged(nameof(Hundreds));
                }
            }
        }

        */
    }
}
