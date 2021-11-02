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
                    OnPropertyChanged(nameof(_cashDrawerDimes));

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
            get { return _customer; }
            set
            {
                if (_customer != value)
                {
                    _customer = value;
                    OnPropertyChanged(nameof(Customer));
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
                    MakeChange();
                }
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
                if (_customerPennies != value)
                {
                    _customerPennies = (int)value;
                    OnPropertyChanged(nameof(CustomerPennies));
                    Customer += (value - _customerPennies) * 0.01M;
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
        public int CustomerNickels
        {
            get { return _customerNickels; }

            set
            {
                if (_customerNickels != value)
                {
                    _customerNickels = (int)value;
                    OnPropertyChanged(nameof(CustomerNickels));
                    Customer += (value - _customerNickels) * 0.05M;
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
        public int CustomerDimes
        {
            get { return _customerDimes; }

            set
            {
                if (_customerDimes != value)
                {
                    _customerDimes = (int)value;
                    OnPropertyChanged(nameof(CustomerDimes));
                    Customer += (value - _customerDimes) * 0.10M;
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
        public int CustomerQuarters
        {
            get { return _customerQuarters; }

            set
            {
                if (_customerQuarters != value)
                {
                    _customerQuarters = (int)value;
                    OnPropertyChanged(nameof(CustomerQuarters));
                    Customer += (value - _customerQuarters) * 0.25M;
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
        public int CustomerHalfDollars
        {
            get { return _customerHalfDollars; }

            set
            {
                if (_customerHalfDollars != value)
                {
                    _customerHalfDollars = (int)value;
                    OnPropertyChanged(nameof(CustomerHalfDollars));
                    Customer += (value - _customerHalfDollars) * .50M;
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
        public int CustomerDollars
        {
            get { return _customerDollars; }

            set
            {
                if (_customerDollars != value)
                {
                    _customerDollars = (int)value;
                    OnPropertyChanged(nameof(CustomerDollars));
                    Customer += (value - _customerDollars) * 1.00M;
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
        public int CustomerOnes
        {
            get { return _customerOnes; }

            set
            {
                if (_customerOnes != value)
                {
                    _customerOnes = (int)value;
                    OnPropertyChanged(nameof(CustomerOnes));
                    Customer += (value - _customerOnes) * 1;
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
        public int CustomerTwos
        {
            get { return _customerTwos; }

            set
            {
                if (_customerTwos != value)
                {
                    _customerTwos = (int)value;
                    OnPropertyChanged(nameof(CustomerTwos));
                    Customer += (value - _customerTwos) * 2;
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
        public int CustomerFives
        {
            get { return _customerFives; }

            set
            {
                if (_customerFives != value)
                {
                    _customerFives = (int)value;
                    OnPropertyChanged(nameof(CustomerFives));
                    Customer += (value - _customerFives) * 5;
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
        public int CustomerTens
        {
            get { return _customerTens; }

            set
            {
                if (_customerTens != value)
                {
                    _customerTens = (int)value;
                    OnPropertyChanged(nameof(CustomerTens));
                    Customer += (value - _customerTens) * 10;
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
        public int CustomerTwenties
        {
            get { return _customerTwenties; }

            set
            {
                if (_customerTwenties != value)
                {
                    _customerTwenties = (int)value;
                    OnPropertyChanged(nameof(CustomerTwenties));
                    Customer += (value - _customerTwenties) * 20;
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
        public int CustomerFifties
        {
            get { return _customerFifties; }

            set
            {
                if (_customerFifties != value)
                {
                    _customerFifties = (int)value;
                    OnPropertyChanged(nameof(CustomerFifties));
                    Customer += (value - _customerFifties) * 50;
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
        public int CustomerHundreds
        {
            get { return _customerHundreds; }

            set
            {
                if (_customerHundreds != value)
                {
                    _customerHundreds = (int)value;
                    OnPropertyChanged(nameof(CustomerHundreds));
                    Customer += (value - _customerHundreds) * 100;
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
            if (Customer > Total)
            {
                int change = (int)((Customer - Total) * 100);

                int count = change / 10000;
                if (CashDrawerHundreds > count)
                {
                    change -= count * 10000;
                    ChangeHundreds = count;
                }

                else
                {
                    change -= CashDrawerHundreds * 10000;
                    ChangeHundreds = CashDrawerHundreds;
                }

                count = change / 5000;
                if (CashDrawerFifties >= count)
                {
                    change -= count * 5000;
                    ChangeFifties = count;
                }

                else
                {
                    change -= CashDrawerFifties * 5000;
                    ChangeFifties = CashDrawerFifties;
                }

                count = change / 2000;
                if (CashDrawerTwenties >= count)
                {
                    change -= count * 2000;
                    ChangeTwenties = count;
                }

                else
                {
                    change -= CashDrawerTwenties * 2000;
                    ChangeTwenties = CashDrawerTwenties;
                }

                count = change / 1000;
                if (CashDrawerTens >= count)
                {
                    change -= count * 1000;
                    ChangeTens = count;
                }

                else
                {
                    change -= CashDrawerTens * 1000;
                    ChangeTens = CashDrawerTens;
                }

                count = change / 500;
                if (CashDrawerFives >= count)
                {
                    change -= count * 500;
                    ChangeFives = count;
                }

                else
                {
                    change -= CashDrawerFives * 500;
                    ChangeFives = CashDrawerFives;
                }

                count = change / 200;
                if (CashDrawerTwos >= count)
                {
                    change -= count * 200;
                    ChangeTwenties = count;
                }

                else
                {
                    change -= CashDrawerTwos * 200;
                    ChangeTwos = CashDrawerTwos;
                }

                count = change / 100;
                if (CashDrawerOnes >= count)
                {
                    change -= count * 100;
                    ChangeOnes = count;
                }

                else
                {
                    change -= CashDrawerOnes * 100;
                    ChangeOnes = CashDrawerOnes;


                    if (CashDrawerDollarsInCents >= count)
                    {
                        change -= (count - ChangeOnes) * 100;
                        ChangeDollars = count;
                    }
                }


                count = change / 50;
                if (CashDrawerHalfDollars >= count)
                {
                    change -= count * 50;
                    ChangeHalfDollars = count;
                }

                else
                {
                    change -= CashDrawerHalfDollars * 50;
                    ChangeHalfDollars = CashDrawerHalfDollars;
                }

                count = change / 25;
                if (CashDrawerQuarters >= count)
                {
                    change -= count * 25;
                    ChangeQuarters = count;
                }

                else
                {
                    change -= CashDrawerQuarters * 25;
                    ChangeQuarters = CashDrawerQuarters;
                }

                count = change / 10;
                if (CashDrawerDimes >= count)
                {
                    change -= count * 10;
                    ChangeDimes = count;
                }

                else
                {
                    change -= CashDrawerDimes * 10;
                    ChangeDimes = CashDrawerDimes;
                }

                count = change / 5;
                if (CashDrawerNickels >= count)
                {
                    change -= count * 5;
                    ChangeQuarters = count;
                }

                else
                {
                    change -= CashDrawerNickels * 5;
                    ChangeNickels = CashDrawerNickels;
                }

                count = change;
                if (CashDrawerPennies >= count)
                {
                    ChangePennies = change;
                }

                else
                {
                    change -= CashDrawerPennies * 100;
                    ChangePennies = CashDrawerPennies;
                }
            }

            else
            {
                //set change to zero
                ChangeHundreds = 0;
                ChangeFifties = 0;
                ChangeTwenties = 0;
                ChangeTens = 0;
                ChangeFives = 0;
                ChangeTwos = 0;
                ChangeOnes = 0;
                ChangeDollars = 0;
                ChangeHalfDollars = 0;
                ChangeQuarters = 0;
                ChangeDimes = 0;
                ChangeNickels = 0;
                ChangePennies = 0;
            }
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
        public void PrintReceipt(Order order, string method)
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
            RecieptPrinter.PrintLine("Payment method: "+ method);
            RecieptPrinter.PrintLine($"Changed owed is: $ + {Decimal.Round(ChangeOwed, 2)}");
            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Keeps track of change owed to customer
        /// </summary>
        public void GiveChange()
        {
            decimal remainingChange = Customer - Total;
            while (remainingChange >= 100)
            {
                remainingChange -= 100;
                CashDrawerHundreds--;
                ChangeHundreds++;
            }

            while (remainingChange >= 50)
            {
                remainingChange -= 50;
                CashDrawerFifties--;
                ChangeFifties++;
            }

            while (remainingChange >= 20)
            {
                remainingChange -= 20;
                CashDrawerFifties--;
                ChangeTwenties++;
            }

            while (remainingChange >= 10)
            {
                remainingChange -= 10;
                CashDrawerTens--;
                ChangeTens++;
            }

            while (remainingChange >= 5)
            {
                remainingChange -= 5;
                CashDrawerFives--;
                ChangeFives++;
            }

            while (remainingChange >= 2)
            {
                remainingChange -= 2;
                CashDrawerTwos--;
                ChangeTwos++;
            }

            while (remainingChange >= 1)
            {
                remainingChange -= 1;
                CashDrawerOnes--;
                ChangeOnes++;
            }

            while (remainingChange >= 1.00M)
            {
                remainingChange -= 1.00M;
                CashDrawerDollarsInCents--;
                ChangeDollars++;
            }

            while (remainingChange >= 0.50M)
            {
                remainingChange -= 0.50M;
                CashDrawerHalfDollars--;
                ChangeHalfDollars++;
            }

            while (remainingChange >= 0.25M)
            {
                remainingChange -= 0.25M;
                CashDrawerQuarters--;
                ChangeQuarters++;
            }

            while (remainingChange >= 0.10M)
            {
                remainingChange -= 0.10M;
                CashDrawerDimes--;
                ChangeDimes++;
            }

            while (remainingChange >= 0.05M)
            {
                remainingChange -= 0.05M;
                CashDrawerNickels--;
                ChangeNickels++;
            }

            while (remainingChange >= 0.01M)
            {
                remainingChange -= 0.01M;
                CashDrawerPennies--;
                ChangePennies++;
            }
        }
    }
}
