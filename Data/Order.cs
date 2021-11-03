/*
 * Order.cs
 * Author: Alisha C.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data
{
    /// <summary>
    /// Represents an order
    /// </summary>
    /// <typeparam name="IMenuItems">Collection of IMenuItems</typeparam>
    public class Order : IMenuItem, ICollection<IMenuItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event handler for changing collections
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        /// <summary>
        /// Used to trigger a property changed event
        /// </summary>
        /// <param name="propertyName">The name of property that is changing</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Used to trigger a collection changed event
        /// </summary>
        /// <param name="e">Name of collection that is changing</param>
        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) 
        {
            CollectionChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Clears data from order
        /// </summary>
        public void Clear() 
        {
            menuItemList.Clear();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            OnPropertyChanged(nameof(this.Subtotal));
            OnPropertyChanged(nameof(this.Tax));
            OnPropertyChanged(nameof(this.Total));
            OnPropertyChanged(nameof(this.Calories));
        }

        /// <summary>
        /// Collections of menu items
        /// </summary>
        public List<IMenuItem> menuItemList = new List<IMenuItem>();

        /// <summary>
        /// Adds a Menu Item
        /// </summary>
        /// <param name="menuItem">Menu item to add</param>
        public void Add(IMenuItem menuItem)
        {
            menuItemList.Add(menuItem);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, menuItem));
            OnPropertyChanged(nameof(this.Subtotal));
            OnPropertyChanged(nameof(this.Tax));
            OnPropertyChanged(nameof(this.Total));
            OnPropertyChanged(nameof(this.Calories));
        }

        
        /// <summary>
        /// Removes the item
        /// </summary>
        /// <param name="menuItem">Item to be removed</param>
        /// <returns>True if the item is in the list false if not</returns>
        public bool Remove(IMenuItem menuItem)
        {
            if (menuItemList.Contains(menuItem))
            {
                int index = menuItemList.IndexOf(menuItem);
                menuItemList.Remove(menuItem);
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, menuItem, index));
                OnPropertyChanged(nameof(this.Subtotal));
                OnPropertyChanged(nameof(this.Tax));
                OnPropertyChanged(nameof(this.Total));
                OnPropertyChanged(nameof(this.Calories));
                return true;
            }

            else 
            { 
                return false;
            }
        }

        /// <summary>
        /// backing field for sales tax rate
        /// </summary>
        public decimal _salesTaxRate = 0.09M;

        /// <summary>
        /// Rate of sales tax
        /// </summary>
        public decimal SalesTaxRate
        {
            get { return _salesTaxRate; }

            set
            {
                if(_salesTaxRate != value) 
                {
                    _salesTaxRate = value;
                    OnPropertyChanged(nameof(Total));
                    OnPropertyChanged(nameof(Tax));
                    OnPropertyChanged(nameof(SalesTaxRate));
                }
            }
        }


        /// <summary>
        /// Calculates the Tax
        /// </summary>
        public decimal Tax => Subtotal * SalesTaxRate;

        /// <summary>
        /// Subtotal
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                decimal subtotalSum = 0M;

                foreach (IMenuItem menuItem in menuItemList) 
                {
                    subtotalSum += menuItem.Price;
                }

                return subtotalSum;
            }
        }


        /// <summary>
        /// Calculates the Total (round with Math.Floor)
        /// </summary>
        public decimal Total => Math.Round(Subtotal + Tax, 2);


        /// <summary>
        /// Calories
        /// </summary>
        public uint Calories
        {
            get 
            {
                uint sumOfCalories = 0;
                foreach (IMenuItem menuItem in menuItemList) 
                {
                    sumOfCalories += menuItem.Calories;
                }


                return sumOfCalories;
            }
        }

        /// <summary>
        /// backing field for Number
        /// </summary>
        public int _number;

        /// <summary>
        /// Unique order number 
        /// </summary>
        public int Number 
        {
            get
            {
                return _number;
            }

            set 
            {
                if (_number != value) 
                {
                    _number = value;
                    OnPropertyChanged(nameof(Number));
                }
            }
        }

        /// <summary>
        /// Ensures uniqueness of order number
        /// </summary>
        private static int NextOrderNumber { get; set; } = 1;


        /// <summary>
        /// backing field for PlacedAt
        /// </summary>
        public DateTime _placedAt;

        /// <summary>
        /// Data and time the order was placed
        /// </summary>
        public DateTime PlacedAt => _placedAt;
        
        /// <summary>
        /// Gets count of items in Menu Item List
        /// </summary>
        public int Count => menuItemList.Count;


        /// <summary>
        /// IsSynchronized property (Not used)
        /// </summary>
        public bool IsSynchronized { get; }

        /// <summary>
        /// Sync root property (Not used)
        /// </summary>
        public object SyncRoot { get; }

        /// <summary>
        /// Price of item
        /// </summary>
        public decimal Price { get; }


        /// <summary>
        /// Special instructions of order
        /// </summary>
        public IEnumerable<string> SpecialInstructions { get; }

        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Checks if order is read only
        /// </summary>
        public bool IsReadOnly => true;

        /// <summary>
        /// Checks to see if them menu item list contains the item
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        /// Returns true if contains, otherwise false.
        /// </returns>
        public bool Contains(IMenuItem item)
        {
            return menuItemList.Contains(item);
        }


        /// <summary>
        /// Copies the data of the menu item array
        /// </summary>
        /// <param name="menuItemArray">Array</param>
        /// <param name="index">Index</param>
        public void CopyTo(IMenuItem[] menuItemArray, int index)
        {
            menuItemList.CopyTo(menuItemArray, index);
        }


        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>
        /// Returns the enumerator.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return menuItemList.GetEnumerator();
        }

        /// <summary>
        /// Enumerator for IMenuItem (Not used)
        /// </summary>
        /// <returns>not implemented exception</returns>
        public IEnumerator<IMenuItem> GetEnumerator()
        {
            return menuItemList.GetEnumerator();
        }

        /// <summary>
        /// Constructor for order class
        /// </summary>
        public Order() 
        {
            Number = NextOrderNumber;
            NextOrderNumber++;
            _placedAt = DateTime.Now;
        }

    }
}
