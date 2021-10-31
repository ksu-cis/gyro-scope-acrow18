﻿/*
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
    /// <summary>
    /// Intermediate class for CashRegister
    /// </summary>
    public class RegisterViewModel : INotifyPropertyChanged
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
        /// Backing field to hold the order
        /// </summary>
        private Order _order;

        /// <summary>
        /// The order the viewmodel is based on
        /// </summary>
        public Order Order => _order;

        /// <summary>
        /// Default constructor 
        /// </summary>
        public RegisterViewModel() 
        {
            this._order = Order;
            _order.PropertyChanged += OnOrderChanged();
        }

        /// <summary>
        /// Represents how much the order costs
        /// </summary>
        public decimal Total => _order.Total;

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
        //Beginning of customer properties
        
        /// <summary>
        /// backing field for pennies
        /// </summary>
        public int _customerPennies;

        /// <summary>
        /// Pennies customer has
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
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
                }
            }
        }

        /// <summary>
        /// backing field for nickels
        /// </summary>
        public int _customerNickels;

        /// <summary>
        /// Nickels customer has
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
        /// Dimes customer has
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
        /// Quarters customer has
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
        /// Half Dollars customer has
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
        /// Dollars customer has
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
        /// One dollar bills customer has
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
        public int _customerTwos;

        /// <summary>
        /// Two dollar bills customer has
        /// </summary>
        public decimal CustomerTwos
        {
            get { return _customerTwos; }

            set
            {
                if (_customerTwos != value)
                {
                    _customerTwos = (int)value;
                    OnPropertyChanged(nameof(CustomerTwos));
                }
            }
        }

        /// <summary>
        /// backing field for five dollar bills
        /// </summary>
        public int _customerFives;

        /// <summary>
        /// Five dollar bills customer has
        /// </summary>
        public decimal CustomerFives
        {
            get { return _customerFives; }

            set
            {
                if (_customerFives != value)
                {
                    _customerFives = (int)value;
                    OnPropertyChanged(nameof(CustomerFives));
                }
            }
        }

        /// <summary>
        /// backing field for ten dollar bills
        /// </summary>
        public int _customerTens;

        /// <summary>
        /// Ten dollar bills customer has
        /// </summary>
        public decimal CustomerTens
        {
            get { return _customerTens; }

            set
            {
                if (_customerTens != value)
                {
                    _customerTens = (int)value;
                    OnPropertyChanged(nameof(CustomerTens));
                }
            }
        }


        /// <summary>
        /// backing field for twenty dollar bills
        /// </summary>
        public int _customerTwenties;

        /// <summary>
        /// Twenty dollar bills customer has
        /// </summary>
        public decimal CustomerTwenties
        {
            get { return _customerTwenties; }

            set
            {
                if (_customerTwenties != value)
                {
                    _customerTwenties = (int)value;
                    OnPropertyChanged(nameof(CustomerTwenties));
                }
            }
        }

        /// <summary>
        /// backing field for fifty dollar bills
        /// </summary>
        public int _customerFifties;

        /// <summary>
        /// Fity dollar bills customer has
        /// </summary>
        public decimal CustomerFifties
        {
            get { return _customerFifties; }

            set
            {
                if (_customerFifties != value)
                {
                    _customerFifties = (int)value;
                    OnPropertyChanged(nameof(CustomerFifties));
                }
            }
        }

        /// <summary>
        /// backing field for one hundred dollar bills
        /// </summary>
        public int _customerHundreds;

        /// <summary>
        /// One hundred dollar bills customer has
        /// </summary>
        public decimal CustomerHundreds
        {
            get { return _customerHundreds; }

            set
            {
                if (_customerHundreds != value)
                {
                    _customerHundreds = (int)value;
                    OnPropertyChanged(nameof(CustomerHundreds));
                }
            }
        }

        //End of customer properties
        //Beginning of change properties

        /// <summary>
        /// backing field for pennies
        /// </summary>
        public int _changePennies;

        /// <summary>
        /// Pennies owed in change
        /// </summary>
        public decimal ChangePennies
        {
            get { return _changePennies; }

            set
            {
                if (_changePennies != value)
                {
                    _changePennies = (int)value;
                    OnPropertyChanged(nameof(ChangePennies));
                }
            }
        }



        /// <summary>
        /// backing field for nickels
        /// </summary>
        public int _changeNickels;

        /// <summary>
        /// Nickels owed in change
        /// </summary>
        public decimal ChangeNickels
        {
            get { return _changeNickels; }

            set
            {
                if (_changeNickels != value)
                {
                    _changeNickels = (int)value;
                    OnPropertyChanged(nameof(ChangeNickels));
                }
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _changeDimes;

        /// <summary>
        /// Dimes owed in change
        /// </summary>
        public decimal ChangeDimes
        {
            get { return _changeDimes; }

            set
            {
                if (_changeDimes != value)
                {
                    _changeDimes = (int)value;
                    OnPropertyChanged(nameof(ChangeDimes));
                }
            }
        }

        /// <summary>
        /// backing field for quarters
        /// </summary>
        public int _changeQuarters;

        /// <summary>
        /// Quarters owed in change
        /// </summary>
        public decimal ChangeQuarters
        {
            get { return _changeQuarters; }

            set
            {
                if (_changeQuarters != value)
                {
                    _changeQuarters = (int)value;
                    OnPropertyChanged(nameof(ChangeQuarters));
                }
            }
        }


        /// <summary>
        /// backing field for half dollars
        /// </summary>
        public int _changeHalfDollars;

        /// <summary>
        /// Half Dollars owed in change
        /// </summary>
        public decimal ChangeHalfDollars
        {
            get { return _changeHalfDollars; }

            set
            {
                if (_changeHalfDollars != value)
                {
                    _changeHalfDollars = (int)value;
                    OnPropertyChanged(nameof(ChangeHalfDollars));
                }
            }
        }


        /// <summary>
        /// backing field for dollars (cents)
        /// </summary>
        public int _changeDollars;

        /// <summary>
        /// Dollars owed in change
        /// </summary>
        public decimal ChangeDollars
        {
            get { return _changeDollars; }

            set
            {
                if (_changeDollars != value)
                {
                    _changeDollars = (int)value;
                    OnPropertyChanged(nameof(ChangeDollars));
                }
            }
        }


        /// <summary>
        /// backing field for one dollar bills
        /// </summary>
        public int _changeOnes;

        /// <summary>
        /// One dollar bills owed in change
        /// </summary>
        public decimal ChangeOnes
        {
            get { return _changeOnes; }

            set
            {
                if (_changeOnes != value)
                {
                    _changeOnes = (int)value;
                    OnPropertyChanged(nameof(ChangeOnes));
                }
            }
        }

        /// <summary>
        /// backing field for two dollar bills
        /// </summary>
        public int _changeTwos;

        /// <summary>
        /// Two dollar bills owed in change
        /// </summary>
        public decimal ChangeTwos
        {
            get { return _changeTwos; }

            set
            {
                if (_changeTwos != value)
                {
                    _changeTwos = (int)value;
                    OnPropertyChanged(nameof(ChangeTwos));
                }
            }
        }

        /// <summary>
        /// backing field for five dollar bills
        /// </summary>
        public int _changeFives;

        /// <summary>
        /// Five dollar bills owed in change
        /// </summary>
        public decimal ChangeFives
        {
            get { return _changeFives; }

            set
            {
                if (_changeFives != value)
                {
                    _changeFives = (int)value;
                    OnPropertyChanged(nameof(ChangeFives));
                }
            }
        }

        /// <summary>
        /// backing field for ten dollar bills
        /// </summary>
        public int _changeTens;

        /// <summary>
        /// Ten dollar bills owed in change
        /// </summary>
        public decimal ChangeTens
        {
            get { return _changeTens; }

            set
            {
                if (_changeTens != value)
                {
                    _changeTens = (int)value;
                    OnPropertyChanged(nameof(ChangeTens));
                }
            }
        }


        /// <summary>
        /// backing field for twenty dollar bills
        /// </summary>
        public int _changeTwenties;

        /// <summary>
        /// Twenty dollar bills owed in change
        /// </summary>
        public decimal ChangeTwenties
        {
            get { return ChangeTwenties; }

            set
            {
                if (_changeTwenties != value)
                {
                    _changeTwenties = (int)value;
                    OnPropertyChanged(nameof(ChangeTwenties));
                }
            }
        }

        /// <summary>
        /// backing field for fifty dollar bills
        /// </summary>
        public int _changeFifties;

        /// <summary>
        /// Fity dollar bills owed in change
        /// </summary>
        public decimal ChangeFifties
        {
            get { return _changeFifties; }

            set
            {
                if (_changeFifties != value)
                {
                    _changeFifties = (int)value;
                    OnPropertyChanged(nameof(_changeFifties));
                }
            }
        }

        /// <summary>
        /// backing field for one hundred dollar bills
        /// </summary>
        public int _changeHundreds;

        /// <summary>
        /// One hundred dollar bills owed in change
        /// </summary>
        public decimal ChangeHundreds
        {
            get { return _changeHundreds; }

            set
            {
                if (_changeHundreds != value)
                {
                    _changeHundreds = (int)value;
                    OnPropertyChanged(nameof(ChangeHundreds));
                }
            }
        }
    }
}
