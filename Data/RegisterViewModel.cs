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
        private readonly Order _order;

        /// <summary>
        /// The order the viewmodel is based on
        /// </summary>
        public Order Order => _order;


        /// <summary>
        /// Default constructor 
        /// </summary>
        public RegisterViewModel(Order order)
        {
            this._order = order;
        }

        /// <summary>
        /// Represents how much the order costs
        /// </summary>
        public decimal Total => _order.Total;

        //Beginning of cash drawer properties

        /// <summary>
        /// backing field for cash drawer pennies
        /// </summary>
        public int _cashDrawerPennies = CashDrawer.Pennies;

        /// <summary>
        /// Pennies in cash register
        /// </summary>
        public int CashDrawerPennies
        {
            get { return _cashDrawerPennies; }
            set
            {
                if (_cashDrawerPennies != value)
                {
                    _cashDrawerPennies = value;
                    OnPropertyChanged(nameof(CashDrawerPennies));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field cash drawer nickels
        /// </summary>
        public int _cashDrawerNickels = CashDrawer.Nickels;

        /// <summary>
        /// Nickels in cash register
        /// </summary>
        public int CashDrawerNickels
        {
            get { return _cashDrawerNickels; }
            set
            {
                if (_cashDrawerNickels != value)
                {
                    _cashDrawerNickels = value;
                    OnPropertyChanged(nameof(CashDrawerNickels));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field cash drawer dimes
        /// </summary>
        public int _cashDrawerDimes = CashDrawer.Dimes;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public int CashDrawerDimes
        {
            get { return _cashDrawerDimes; }
            set
            {
                if (_cashDrawerDimes != value)
                {
                    _cashDrawerDimes = value;
                    OnPropertyChanged(nameof(CashDrawerDimes));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field cash drawer quarters
        /// </summary>
        public int _cashDrawerQuarters = CashDrawer.Quarters;

        /// <summary>
        /// Quarters in cash register
        /// </summary>
        public int CashDrawerQuarters 
        {
            get { return _cashDrawerQuarters; }
            set
            {
                if (_cashDrawerQuarters != value)
                {
                    _cashDrawerQuarters = value;
                    OnPropertyChanged(nameof(CashDrawerQuarters));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field cash drawer half dollars
        /// </summary>
        public int _cashDrawerHalfDollars = CashDrawer.HalfDollars;

        /// <summary>
        /// Half dollars in cash register
        /// </summary>
        public int CashDrawerHalfDollars
        {
            get { return _cashDrawerHalfDollars; }
            set
            {
                if (_cashDrawerHalfDollars != value)
                {
                    _cashDrawerHalfDollars = value;
                    OnPropertyChanged(nameof(CashDrawerHalfDollars));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }


        /// <summary>
        /// backing field for dollars in cents
        /// </summary>
        public int _cashDrawerDollarsInCents = CashDrawer.Dollars;

        /// <summary>
        /// Dollars in cash register (cent)
        /// </summary>
        public int CashDrawerDollarsInCents 
        {
            get { return _cashDrawerDollarsInCents; }
            set
            {
                if (_cashDrawerDollarsInCents != value)
                {
                    _cashDrawerDollarsInCents = value;
                    OnPropertyChanged(nameof(CashDrawerDollarsInCents));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }


        /// <summary>
        /// backing field for ones
        /// </summary>
        public int _cashDrawerOnes = CashDrawer.Ones;

        /// <summary>
        /// Ones in cash register
        /// </summary>
        public int CashDrawerOnes
        {
            get { return _cashDrawerOnes; }
            set
            {
                if (_cashDrawerOnes != value)
                {
                    _cashDrawerOnes = value;
                    OnPropertyChanged(nameof(CashDrawerOnes));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for twos
        /// </summary>
        public int _cashDrawerTwos = CashDrawer.Twos;

        /// <summary>
        /// Twos in cash register
        /// </summary>
        public int CashDrawerTwos 
        {
            get { return _cashDrawerTwos; }
            set
            {
                if (_cashDrawerTwos != value)
                {
                    _cashDrawerTwos = value;
                    OnPropertyChanged(nameof(CashDrawerTwos));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for fives
        /// </summary>
        public int _cashDrawerFives = CashDrawer.Fives;

        /// <summary>
        /// Fives in cash register
        /// </summary>
        public int CashDrawerFives 
        {
            get { return _cashDrawerFives; }
            set
            {
                if (_cashDrawerFives != value)
                {
                    _cashDrawerFives = value;
                    OnPropertyChanged(nameof(CashDrawerFives));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for tens
        /// </summary>
        public int _cashDrawerTens = CashDrawer.Tens;

        /// <summary>
        /// Tens in cash register
        /// </summary>
        public int CashDrawerTens 
        {
            get { return _cashDrawerTens; }
            set
            {
                if (_cashDrawerTens != value)
                {
                    _cashDrawerTens = value;
                    OnPropertyChanged(nameof(CashDrawerTens));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for twenties
        /// </summary>
        public int _cashDrawerTwenties = CashDrawer.Twenties;

        /// <summary>
        /// Twenties in cash register
        /// </summary>
        public int CashDrawerTwenties
        {
            get { return _cashDrawerTwenties; }
            set
            {
                if (_cashDrawerTwenties != value)
                {
                    _cashDrawerTwenties = value;
                    OnPropertyChanged(nameof(CashDrawerTwenties));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for fifties
        /// </summary>
        public int _cashDrawerFifties = CashDrawer.Fifties;

        /// <summary>
        /// Fifties in cash register
        /// </summary>
        public int CashDrawerFifties 
        {
            get { return _cashDrawerFifties; }
            set
            {
                if (_cashDrawerFifties != value)
                {
                    _cashDrawerFifties = value;
                    OnPropertyChanged(nameof(CashDrawerFifties));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for hundreds
        /// </summary>
        public int _cashDrawerHundreds = CashDrawer.Hundreds;

        /// <summary>
        /// Hundreds in cash register
        /// </summary>
        public int CashDrawerHundreds 
        {
            get { return _cashDrawerHundreds; }
            set
            {
                if (_cashDrawerHundreds != value)
                {
                    _cashDrawerHundreds = value;
                    OnPropertyChanged(nameof(CashDrawerHundreds));
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// backing field for total of cash drawer
        /// </summary>
        public double _totalOfCashDrawer = CashDrawer.Total;

        /// <summary>
        /// Total of Cash drawer
        /// </summary>
        public double TotalOfCashDrawer
        {
            get { return _totalOfCashDrawer; }
            set
            {
                if (_totalOfCashDrawer != value)
                {
                    _totalOfCashDrawer = value;
                    OnPropertyChanged(nameof(TotalOfCashDrawer));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }


        /// <summary>
        /// backing field for incoming
        /// </summary>
        public decimal _customer;

        /// <summary>
        /// Represents how much the customer has paid so far
        /// </summary>
        public decimal Customer
        {
            get
            {
                decimal customerTotal = 0.0m;
                customerTotal += 0.01m * CustomerPennies;
                customerTotal += 0.05m * CustomerNickels;
                customerTotal += 0.10m * CustomerDimes;
                customerTotal += 0.25m * CustomerQuarters;
                customerTotal += 0.50m * CustomerHalfDollars;
                customerTotal += 1.00m * CustomerDollars;
                customerTotal += 1.00m * CustomerOnes;
                customerTotal += 2.00m * CustomerTwos;
                customerTotal += 5.00m * CustomerFives;
                customerTotal += 10.00m * CustomerTens;
                customerTotal += 20.00m * CustomerTwenties;
                customerTotal += 50.00m * CustomerFifties;
                customerTotal += 100.00m * CustomerHundreds;
                return customerTotal;
            }

        }

        /// <summary>
        /// backing field for outgoing
        /// </summary>
        public decimal _change;

        /// <summary>
        /// Represents how much the customer has paid so far
        /// </summary>
        public decimal Change
        {
            get { return _change; }
            set
            {
                if (_change != value)
                {
                    _change = value;
                    OnPropertyChanged(nameof(Change));
                    OnPropertyChanged(nameof(ChangeOwed));
                    OnPropertyChanged(nameof(DrawerTotal));
                }
            }
        }

        /// <summary>
        /// How much the customer still owes 
        /// </summary>
        public decimal AmountDue
        {
            get
            {
                if (Total < Customer)
                {
                    return 0M;
                }

                else
                {
                    return Total - Customer;
                }
            }
        }


        /// <summary>
        /// Amount of change owed to customer
        /// </summary>
        public decimal ChangeOwed
        {
            get
            {
                if (Customer < Total)
                {
                    return 0M;
                }

                else
                {
                    return Customer - Total;
                }
            }
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
        public int CustomerPennies
        {
            get { return _customerPennies; }

            set
            {
                if (_customerPennies < value)
                {
                    _customerPennies = value;
                    CashDrawerPennies += _customerPennies;
                }
                else 
                {
                    _customerPennies = value;
                    CashDrawerPennies -= _customerPennies;
                }
                    OnPropertyChanged(nameof(CustomerPennies));
                    OnPropertyChanged(nameof(Customer));
                    MakeChange();
                    OnPropertyChanged(nameof(ChangePennies));
                    OnPropertyChanged(nameof(ChangeOwed));
            }
        }
        

        /// <summary>
        /// backing field for nickels
        /// </summary>
        public int _customerNickels;

        /// <summary>
        /// Nickels customer has
        /// </summary>
        public int CustomerNickels
        {
            get { return _customerNickels; }

            set
            {
                if (_customerNickels < value)
                {
                    _customerNickels = value;
                    CashDrawerNickels += _customerNickels;
                }
                else
                {
                    _customerNickels = value;
                    CashDrawerNickels -= _customerNickels;
                }

                OnPropertyChanged(nameof(CustomerNickels));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeNickels));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for dimes
        /// </summary>
        public int _customerDimes;

        /// <summary>
        /// Dimes customer has
        /// </summary>
        public int CustomerDimes
        {
            get { return _customerDimes; }

            set
            {
                if (_customerDimes < value)
                {
                    _customerDimes = value;
                    CashDrawerDimes += _customerDimes;
                }
                else
                {
                    _customerDimes = value;
                    CashDrawerDimes -= _customerDimes;
                }

                OnPropertyChanged(nameof(CustomerDimes));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeDimes));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for quarters
        /// </summary>
        public int _customerQuarters;

        /// <summary>
        /// Quarters customer has
        /// </summary>
        public int CustomerQuarters
        {
            get { return _customerQuarters; }

            set
            {
                if (_customerQuarters < value)
                {
                    _customerQuarters = value;
                    CashDrawerQuarters += _customerQuarters;
                }
                else
                {
                    _customerQuarters = value;
                    CashDrawerQuarters -= _customerQuarters;
                }

                OnPropertyChanged(nameof(CustomerQuarters));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeQuarters));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }


        /// <summary>
        /// backing field for half dollars
        /// </summary>
        public int _customerHalfDollars;

        /// <summary>
        /// Half Dollars customer has
        /// </summary>
        public int CustomerHalfDollars
        {
            get { return _customerHalfDollars; }

            set
            {
                if (_customerHalfDollars < value)
                {
                    _customerHalfDollars = value;
                    CashDrawerHalfDollars += _customerHalfDollars;
                }
                else
                {
                    _customerHalfDollars = value;
                    CashDrawerHalfDollars -= _customerHalfDollars;
                }

                OnPropertyChanged(nameof(CustomerHalfDollars));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeHalfDollars));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }


        /// <summary>
        /// backing field for dollars (cents)
        /// </summary>
        public int _customerDollars;

        /// <summary>
        /// Dollars customer has
        /// </summary>
        public int CustomerDollars
        {
            get { return _customerDollars; }

            set
            {
                if (_customerDollars < value)
                {
                    _customerDollars = value;
                    CashDrawerDollarsInCents += _customerDollars;
                }
                else
                {
                    _customerDollars = value;
                    CashDrawerDollarsInCents -= _customerDollars;
                }

                OnPropertyChanged(nameof(CustomerDollars));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeDollars));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }


        /// <summary>
        /// backing field for one dollar bills
        /// </summary>
        public int _customerOnes;

        /// <summary>
        /// One dollar bills customer has
        /// </summary>
        public int CustomerOnes
        {
            get { return _customerOnes; }

            set
            {
                if (_customerOnes < value)
                {
                    _customerOnes = value;
                    CashDrawerOnes += _customerOnes;
                }
                else
                {
                    _customerOnes = value;
                    CashDrawerOnes -= _customerOnes;
                }

                OnPropertyChanged(nameof(CustomerOnes));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeOnes));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for two dollar bills
        /// </summary>
        public int _customerTwos;

        /// <summary>
        /// Two dollar bills customer has
        /// </summary>
        public int CustomerTwos
        {
            get { return _customerTwos; }

            set
            {
                if (_customerTwos < value)
                {
                    _customerTwos = value;
                    CashDrawerTwos += _customerTwos;
                }
                else
                {
                    _customerTwos = value;
                    CashDrawerTwos -= _customerTwos;
                }

                OnPropertyChanged(nameof(CustomerTwos));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeTwos));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for five dollar bills
        /// </summary>
        public int _customerFives;

        /// <summary>
        /// Five dollar bills customer has
        /// </summary>
        public int CustomerFives
        {
            get { return _customerFives; }

            set
            {
                if (_customerFives < value)
                {
                    _customerFives = value;
                    CashDrawerFives += _customerFives;
                }
                else
                {
                    _customerFives = value;
                    CashDrawerFives -= _customerFives;
                }

                OnPropertyChanged(nameof(CustomerFives));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeFives));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for ten dollar bills
        /// </summary>
        public int _customerTens;

        /// <summary>
        /// Ten dollar bills customer has
        /// </summary>
        public int CustomerTens
        {
            get { return _customerTens; }

            set
            {
                if (_customerTens < value)
                {
                    _customerTens = value;
                    CashDrawerTens += _customerFives;
                }
                else
                {
                    _customerTens = value;
                    CashDrawerTens -= _customerTens;
                }

                OnPropertyChanged(nameof(CustomerTens));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeTens));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }


        /// <summary>
        /// backing field for twenty dollar bills
        /// </summary>
        public int _customerTwenties;

        /// <summary>
        /// Twenty dollar bills customer has
        /// </summary>
        public int CustomerTwenties
        {
            get { return _customerTwenties; }

            set
            {
                if (_customerTwenties < value)
                {
                    _customerTwenties = value;
                    CashDrawerTwenties += _customerTwenties;
                }
                else
                {
                    _customerTwenties = value;
                    CashDrawerTwenties -= _customerTwenties;
                }

                OnPropertyChanged(nameof(CustomerTwenties));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeTwenties));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for fifty dollar bills
        /// </summary>
        public int _customerFifties;

        /// <summary>
        /// Fity dollar bills customer has
        /// </summary>
        public int CustomerFifties
        {
            get { return _customerFifties; }

            set
            {
                if (_customerFifties < value)
                {
                    _customerFifties = value;
                    CashDrawerFifties += _customerFifties;
                }
                else
                {
                    _customerFifties = value;
                    CashDrawerFifties -= _customerFifties;
                }

                OnPropertyChanged(nameof(CustomerFifties));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeFifties));
                OnPropertyChanged(nameof(ChangeOwed));
            }
        }

        /// <summary>
        /// backing field for one hundred dollar bills
        /// </summary>
        public int _customerHundreds;

        /// <summary>
        /// One hundred dollar bills customer has
        /// </summary>
        public int CustomerHundreds
        {
            get { return _customerHundreds; }

            set
            {
                if (_customerHundreds < value)
                {
                    _customerHundreds = value;
                    CashDrawerHundreds += _customerHundreds;
                }
                else
                {
                    _customerHundreds = value;
                    CashDrawerHundreds -= _customerHundreds;
                }

                OnPropertyChanged(nameof(CustomerHundreds));
                OnPropertyChanged(nameof(Customer));
                MakeChange();
                OnPropertyChanged(nameof(ChangeHundreds));
                OnPropertyChanged(nameof(ChangeOwed));
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
        public int ChangePennies
        {
            get { return _changePennies; }

            set
            {
                if (_changePennies != value)
                {
                    _changePennies = (int)value;
                    OnPropertyChanged(nameof(ChangePennies));
                    Change += (value - _changePennies) * 0.01M;
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
        public int ChangeNickels
        {
            get { return _changeNickels; }

            set
            {
                if (_changeNickels != value)
                {
                    _changeNickels = (int)value;
                    OnPropertyChanged(nameof(ChangeNickels));
                    Change += (value - _changeNickels) * 0.05M;
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
        public int ChangeDimes
        {
            get { return _changeDimes; }

            set
            {
                if (_changeDimes != value)
                {
                    _changeDimes = (int)value;
                    OnPropertyChanged(nameof(ChangeDimes));
                    Change += (value - _changeDimes) * 0.10M;
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
        public int ChangeQuarters
        {
            get { return _changeQuarters; }

            set
            {
                if (_changeQuarters != value)
                {
                    _changeQuarters = (int)value;
                    OnPropertyChanged(nameof(ChangeQuarters));
                    Change += (value - _changeQuarters) * 0.25M;
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
        public int ChangeHalfDollars
        {
            get { return _changeHalfDollars; }

            set
            {
                if (_changeHalfDollars != value)
                {
                    _changeHalfDollars = (int)value;
                    OnPropertyChanged(nameof(ChangeHalfDollars));
                    Change += (value - _changeHalfDollars) * 0.50M;
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
        public int ChangeDollars
        {
            get { return _changeDollars; }

            set
            {
                if (_changeDollars != value)
                {
                    _changeDollars = (int)value;
                    OnPropertyChanged(nameof(ChangeDollars));
                    Change += (value - _changeDollars) * 1.00M;

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
        public int ChangeOnes
        {
            get { return _changeOnes; }

            set
            {
                if (_changeOnes != value)
                {
                    _changeOnes = (int)value;
                    OnPropertyChanged(nameof(ChangeOnes));
                    Change += (value - _changeOnes) * 1;
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
        public int ChangeTwos
        {
            get { return _changeTwos; }

            set
            {
                if (_changeTwos != value)
                {
                    _changeTwos = (int)value;
                    OnPropertyChanged(nameof(ChangeTwos));
                    Change += (value - _changeTwos) * 2;
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
        public int ChangeFives
        {
            get { return _changeFives; }

            set
            {
                if (_changeFives != value)
                {
                    _changeFives = (int)value;
                    OnPropertyChanged(nameof(ChangeFives));
                    Change += (value - _changeFives) * 5;
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
        public int ChangeTens
        {
            get { return _changeTens; }

            set
            {
                if (_changeTens != value)
                {
                    _changeTens = (int)value;
                    OnPropertyChanged(nameof(ChangeTens));
                    Change += (value - _changeTens) * 10;
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
        public int ChangeTwenties
        {
            get { return _changeTwenties; }

            set
            {
                if (_changeTwenties != value)
                {
                    _changeTwenties = (int)value;
                    OnPropertyChanged(nameof(ChangeTwenties));
                    Change += (value - _changeTwenties) * 20;
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
        public int ChangeFifties
        {
            get { return _changeFifties; }

            set
            {
                if (_changeFifties != value)
                {
                    _changeFifties = (int)value;
                    OnPropertyChanged(nameof(_changeFifties));
                    Change += (value - _changeFifties) * 50;
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
        public int ChangeHundreds
        {
            get { return _changeHundreds; }

            set
            {
                if (_changeHundreds != value)
                {
                    _changeHundreds = (int)value;
                    OnPropertyChanged(nameof(ChangeHundreds));
                    Change += (value - _changeHundreds) * 100;
                }
            }
        }

        /// <summary>
        /// Total of drawer
        /// </summary>
        public decimal DrawerTotal => (CashDrawerHundreds * 100 + CashDrawerFifties * 50 + CashDrawerTwenties * 20 + CashDrawerTens * 10
            + CashDrawerFives * 5 + CashDrawerTwos * 2 + CashDrawerOnes * 1 + CashDrawerDollarsInCents * 1 + CashDrawerHalfDollars * 0.50M
            + CashDrawerQuarters * 0.25M + CashDrawerDimes * 0.10M + CashDrawerNickels * 0.05M + CashDrawerPennies * 0.01M);

        /// <summary>
        /// Calculates change to give back based on Incoming amount and total
        /// </summary>
        public void MakeChange()
        {
            int changeCash = (int)Change; // 400
            int change = (int)((Customer - Total) * 100); // 50 -> 400.500
            int minAmount = 0;
            
            ///beginning of making cash change
            if (changeCash >= 100)
            {
                if (CashDrawerHundreds >= 1) //if a hundred is in the register
                {
                    int hundredAmount = changeCash / 100;
                    minAmount = Math.Min(hundredAmount, CashDrawerHundreds);
                    ChangeHundreds = minAmount;
                    CashDrawerHundreds -= ChangeHundreds;
                    changeCash -= ChangeHundreds * 100;
                }
                else
                {
                    ChangeHundreds = 0;
                }
            }

            if (changeCash >= 50)
            {
                if (CashDrawerFifties >= 1) //if a hundred is in the register
                {
                    int fiftyAmount = changeCash / 50;
                    minAmount = Math.Min(fiftyAmount, CashDrawerFifties);
                    ChangeFifties = minAmount;
                    CashDrawerFifties -= ChangeFifties;
                    changeCash -= ChangeFifties * 50;
                }
                else
                {
                    ChangeFifties = 0;
                }
            }

            if (changeCash >= 20)
            {
                if (CashDrawerTwenties >= 1) //if a hundred is in the register
                {
                    int twentyAmount = changeCash / 20;
                    minAmount = Math.Min(twentyAmount, CashDrawerFifties);
                    ChangeTwenties = minAmount;
                    CashDrawerTwenties -= ChangeTwenties;
                    changeCash -= ChangeTwenties * 20;
                }
                else
                {
                    ChangeTwenties = 0;
                }
            }

            if (changeCash >= 10)
            {
                if (CashDrawerTens >= 1) //if a hundred is in the register
                {
                    int tenAmount = changeCash / 10;
                    minAmount = Math.Min(tenAmount, CashDrawerTens);
                    ChangeTens = minAmount;
                    CashDrawerTens -= ChangeTens;
                    changeCash -= ChangeTens * 10;
                }
                else
                {
                    ChangeTens = 0;
                }
            }

            if (changeCash >= 5)
            {
                if (CashDrawerFives >= 1) //if a hundred is in the register
                {
                    int hundredAmount = changeCash / 5;
                    minAmount = Math.Min(hundredAmount, CashDrawerFives);
                    ChangeFives = minAmount;
                    CashDrawerFives -= ChangeFives;
                    changeCash -= ChangeFives * 5;
                }
                else
                {
                    ChangeFives = 0;
                }
            }

            if (changeCash >= 2)
            {
                if (CashDrawerTwos >= 1) //if a hundred is in the register
                {
                    int onesAmount = changeCash / 2;
                    minAmount = Math.Min(onesAmount, CashDrawerTwos);
                    ChangeOnes = minAmount;
                    CashDrawerTwos -= ChangeTwos;
                    changeCash -= ChangeTwos * 2;
                }
                else
                {
                    ChangeTwos = 0;
                }
            }

            if (changeCash >= 1)
            {
                if (CashDrawerOnes >= 1) //if a hundred is in the register
                {
                    int onesAmount = changeCash / 1;
                    minAmount = Math.Min(onesAmount, CashDrawerOnes);
                    ChangeOnes = minAmount;
                    CashDrawerOnes -= ChangeOnes;
                    changeCash -= ChangeOnes * 1;
                }
                else
                {
                    ChangeOnes = 0;
                }
            }

            ///end of making cash change
            ///beginning of making coin change

            if (change >= 1)
            {
                if (CustomerPennies >= 1) //if a hundred is in the register
                {
                    int penniesAmount = change / 1;
                    minAmount = Math.Min(penniesAmount, CustomerPennies);
                    ChangePennies = minAmount;
                    CashDrawerPennies -= ChangePennies;
                    change -= ChangePennies * 1;
                }
                else
                {
                    ChangePennies = 0;
                }
            }

            if (change >= 5)
            {
                if (CustomerNickels >= 1) //if a hundred is in the register
                {
                    int nickelsAmount = change / 5;
                    minAmount = Math.Min(nickelsAmount, CustomerNickels);
                    ChangeNickels = minAmount;
                    CashDrawerNickels -= ChangeNickels;
                    change -= ChangeNickels * 5;
                }
                else
                {
                    ChangeNickels = 0;
                }
            }

            if (change >= 10)
            {
                if (CustomerDimes >= 1) //if a hundred is in the register
                {
                    int dimesAmount = change / 5;
                    minAmount = Math.Min(dimesAmount, CustomerDimes);
                    ChangeDimes = minAmount;
                    CashDrawerDimes -= ChangeDimes;
                    change -= ChangeDimes * 5;
                }
                else
                {
                    ChangeDimes = 0;
                }
            }

            if (change >= 25)
            {
                if (CustomerQuarters >= 1) //if a hundred is in the register
                {
                    int quartersAmount = change / 5;
                    minAmount = Math.Min(quartersAmount, CustomerQuarters);
                    ChangeQuarters = minAmount;
                    CashDrawerQuarters -= ChangeQuarters;
                    change -= ChangeQuarters * 5;
                }
                else
                {
                    ChangeQuarters = 0;
                }
            }

            if (change >= 50)
            {
                if (CustomerHalfDollars >= 1) //if a hundred is in the register
                {
                    int halfDollarsAmount = change / 5;
                    minAmount = Math.Min(halfDollarsAmount, CustomerHalfDollars);
                    ChangeHalfDollars = minAmount;
                    CashDrawerHalfDollars -= ChangeHalfDollars;
                    change -= ChangeHalfDollars * 5;
                }
                else
                {
                    ChangeHalfDollars = 0;
                }
            }

            if (change >= 100)
            {
                if (CustomerDollars >= 1) //if a hundred is in the register
                {
                    int dollarsAmount = change / 5;
                    minAmount = Math.Min(dollarsAmount, CustomerDollars);
                    ChangeDollars = minAmount;
                    CashDrawerDollarsInCents -= ChangeDollars;
                    change -= ChangeDollars * 5;
                }
                else
                {
                    ChangeDollars = 0;
                }
            }

            if (change > 0 || changeCash > 0) 
            {
                //MessageBox.Show("There is not enough change in the cash register");
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollars"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
        }

        /// <summary>
        /// Represents opening the drawer and changing currency, as well as printing the recipt
        /// </summary>
        public void FinalizeSale()
        {
            CashDrawer.OpenDrawer();
            if ((ChangeHundreds + CustomerHundreds) != 0)
            {
                CashDrawer.Hundreds -= ChangeHundreds;
                CashDrawer.Hundreds += CustomerHundreds;
                OnPropertyChanged(nameof(CashDrawerHundreds));
            }

            if ((ChangeFifties + CustomerFifties) != 0)
            {
                CashDrawer.Fifties -= ChangeFifties;
                CashDrawer.Fifties += CustomerFifties;
                OnPropertyChanged(nameof(CashDrawerFifties));
            }

            if ((ChangeTwenties + CustomerTwenties) != 0)
            {
                CashDrawer.Twenties -= ChangeTwenties;
                CashDrawer.Twenties += CustomerTwenties;
                OnPropertyChanged(nameof(CashDrawerTwenties));

            }

            if ((ChangeTens + CustomerTens) != 0)
            {
                CashDrawer.Tens -= ChangeTens;
                CashDrawer.Tens += CustomerTens;
                OnPropertyChanged(nameof(CashDrawerTens));

            }

            if ((ChangeFives + CustomerFives) != 0)
            {
                CashDrawer.Fives -= ChangeFives;
                CashDrawer.Fives += CustomerFives;
                OnPropertyChanged(nameof(CashDrawerFives));
            }

            if ((ChangeTwos + CustomerTwos) != 0)
            {
                CashDrawer.Twos -= ChangeTwos;
                CashDrawer.Twos += CustomerTwos;
                OnPropertyChanged(nameof(CashDrawerTwos));
            }

            if ((ChangeOnes + CustomerOnes) != 0)
            {
                CashDrawer.Ones -= ChangeOnes;
                CashDrawer.Ones += CustomerOnes;
                OnPropertyChanged(nameof(CashDrawerOnes));
            }

            if ((ChangeNickels + CustomerNickels) != 0)
            {
                CashDrawer.Nickels -= ChangeNickels;
                CashDrawer.Nickels += CustomerNickels;
                OnPropertyChanged(nameof(CashDrawerNickels));
            }

            if ((ChangeDimes + CustomerDimes) != 0)
            {
                CashDrawer.Dimes -= ChangeDimes;
                CashDrawer.Dimes += CustomerDimes;
                OnPropertyChanged(nameof(CashDrawerDimes));
            }

            if ((ChangeQuarters + CustomerQuarters) != 0)
            {
                CashDrawer.Quarters -= ChangeQuarters;
                CashDrawer.Quarters += CustomerQuarters;
                OnPropertyChanged(nameof(CashDrawerQuarters));
            }

            if ((ChangeHalfDollars + CustomerHalfDollars) != 0)
            {
                CashDrawer.HalfDollars -= ChangeHalfDollars;
                CashDrawer.HalfDollars += CustomerHalfDollars;
                OnPropertyChanged(nameof(CashDrawerHalfDollars));
            }

            if ((ChangeDollars + CustomerDollars) != 0)
            {
                CashDrawer.Ones -= ChangeDollars;
                CashDrawer.Ones += CustomerDollars;
                OnPropertyChanged(nameof(CashDrawerDollarsInCents));
            }
        }

        /// <summary>
        /// Print Receipt
        /// </summary>
        public void PrintReceipt()
        {
            RecieptPrinter.PrintLine("Order Number: " + Order.Number.ToString());
            RecieptPrinter.PrintLine("Date and Time: " + Order.PlacedAt.ToString());
            RecieptPrinter.PrintLine(" ");
            RecieptPrinter.PrintLine("Order: ");

            foreach (IMenuItem item in Order.menuItemList)
            {
                RecieptPrinter.PrintLine(item.ToString() + " $" + item.Price.ToString());
                if (item.SpecialInstructions != null)
                {
                    foreach (string special in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("   - " + special);
                    }

                    RecieptPrinter.PrintLine(" ");
                }
            }

            RecieptPrinter.PrintLine(" ");
            RecieptPrinter.PrintLine($"Subtotal: ${Decimal.Round(Order.Subtotal, 2)}");
            RecieptPrinter.PrintLine($"Tax: ${Decimal.Round(Order.Tax, 2)}");
            RecieptPrinter.PrintLine($"Total: ${Decimal.Round(Order.Total, 2)}");
            RecieptPrinter.PrintLine("Payment method: Cash");
            RecieptPrinter.PrintLine($"Changed owed is: $ + {Decimal.Round(ChangeOwed, 2)}");
            RecieptPrinter.CutTape();
        }

    }
}
