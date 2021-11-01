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
        /// Pennies in cash register
        /// </summary>
        public static int CashDrawerPennies => CashDrawer.Pennies;

        /// <summary>
        /// Nickels in cash register
        /// </summary>
        public static int CashDrawerNickels => CashDrawer.Nickels;

        /// <summary>
        /// Dimes in cash register
        /// </summary>
        public static int CashDrawerDimes => CashDrawer.Dimes;

        /// <summary>
        /// Quarters in cash register
        /// </summary>
        public static int CashDrawerQuarters => CashDrawer.Quarters;

        /// <summary>
        /// Half dollars in cash register
        /// </summary>
        public static int CashDrawerHalfDollars => CashDrawer.HalfDollars;

        /// <summary>
        /// Dollars in cash register
        /// </summary>
        public static int CashDrawerDollarsInCents => CashDrawer.Dollars;

        /// <summary>
        /// Ones in cash register
        /// </summary>
        public static int CashDrawerOnes => CashDrawer.Ones;

        /// <summary>
        /// Twos in cash register
        /// </summary>
        public static int CashDrawerTwos => CashDrawer.Twos;

        /// <summary>
        /// Fives in cash register
        /// </summary>
        public static int CashDrawerFives => CashDrawer.Fives;

        /// <summary>
        /// Tens in cash register
        /// </summary>
        public static int CashDrawerTens => CashDrawer.Tens;

        /// <summary>
        /// Twenties in cash register
        /// </summary>
        public static int CashDrawerTwenties => CashDrawer.Twenties;

        /// <summary>
        /// Fifties in cash register
        /// </summary>
        public static int CashDrawerFifties => CashDrawer.Fifties;

        /// <summary>
        /// Hundreds in cash register
        /// </summary>
        public static int CashDrawerHundreds => CashDrawer.Hundreds;

        /// <summary>
        /// Total of Cash drawer
        /// </summary>
        public static double TotalOfCashDrawer => CashDrawer.Total;


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
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
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
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
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
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
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
                    OnPropertyChanged(nameof(AmountDue));
                    OnPropertyChanged(nameof(ChangeOwed));
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
            if (Customer < Total)
            {
                int change = (int)((Customer - Total) * 100);

                int check = change / 10000;

                if (CashDrawerHundreds > check)
                {
                    change -= check * 10000;
                    ChangeHundreds = check;
                }

                else
                {
                    change -= CashDrawerHundreds * 10000;
                    ChangeHundreds = CashDrawerHundreds;
                }


                if (CashDrawerFifties > check)
                {
                    change -= check * 5000;
                    ChangeFifties = check;
                }

                else
                {
                    change -= CashDrawerFifties * 5000;
                    ChangeFifties = CashDrawerFifties;
                }

                if (CashDrawerTwenties > check)
                {
                    change -= check * 2000;
                    ChangeTwenties = check;
                }

                else
                {
                    change -= CashDrawerTwenties * 2000;
                    ChangeTwenties = CashDrawerTwenties;
                }

                if (CashDrawerTens > check)
                {
                    change -= check * 1000;
                    ChangeTens = check;
                }

                else
                {
                    change -= CashDrawerTens * 1000;
                    ChangeTens = CashDrawerTens;
                }

                if (CashDrawerFives > check)
                {
                    change -= check * 500;
                    ChangeFives = check;
                }

                else
                {
                    change -= CashDrawerFives * 500;
                    ChangeFives = CashDrawerFives;
                }

                if (CashDrawerTwos > check)
                {
                    change -= check * 200;
                    ChangeTwenties = check;
                }

                else
                {
                    change -= CashDrawerTwos * 200;
                    ChangeTwos = CashDrawerTwos;
                }

                if (CashDrawerOnes > check)
                {
                    change -= check * 100;
                    ChangeOnes = check;
                }

                else
                {
                    change -= CashDrawerOnes * 100;
                    ChangeOnes = CashDrawerOnes;


                    if (CashDrawerDollarsInCents >= check)
                    {
                        change -= (check - ChangeOnes) * 100;
                        ChangeDollars = check;
                    }
                }


                check = change / 50;

                if (CashDrawerHalfDollars >= check)
                {
                    change -= check * 50;
                    ChangeHalfDollars = check;
                }

                else
                {
                    change -= CashDrawerHalfDollars * 50;
                    ChangeHalfDollars = CashDrawerHalfDollars;
                }

                if (CashDrawerQuarters >= check)
                {
                    change -= check * 25;
                    ChangeQuarters = check;
                }

                else
                {
                    change -= CashDrawerQuarters * 25;
                    ChangeQuarters = CashDrawerQuarters;
                }


                if (CashDrawerDimes >= check)
                {
                    change -= check * 10;
                    ChangeDimes = check;
                }

                else
                {
                    change -= CashDrawerDimes * 10;
                    ChangeDimes = CashDrawerDimes;
                }

                if (CashDrawerNickels >= check)
                {
                    change -= check * 5;
                    ChangeQuarters = check;
                }

                else
                {
                    change -= CashDrawerNickels * 5;
                    ChangeNickels = CashDrawerNickels;
                }

                check = change;
                if (CashDrawerPennies >= check)
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
            RecieptPrinter.PrintLine("Subtotal: $" + Order.Subtotal.ToString());
            RecieptPrinter.PrintLine("Tax: $" + Order.Tax.ToString());
            RecieptPrinter.PrintLine("Total: $" + Order.Total.ToString());
            RecieptPrinter.PrintLine("Payment method: ");
            RecieptPrinter.PrintLine("Changed owed is: " + ChangeOwed);
        }

    }
}
