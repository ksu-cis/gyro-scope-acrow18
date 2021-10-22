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
            this.CollectionChanged(this, e);
        }


        /// <summary>
        /// Helper method for the notify property changed event.
        /// </summary>
        /// <param name="sender">The object.</param>
        /// <param name="e">The event.</param>
        protected virtual void HelperPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("Price"))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
            if (e.PropertyName.Equals("Calories"))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
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
        List<IMenuItem> menuItemList = new List<IMenuItem>();

        /// <summary>
        /// Adds a Menu Item
        /// </summary>
        /// <param name="menuItem">Menu item to add</param>
        public void Add(IMenuItem menuItem)
        {
            menuItemList.Add(menuItem);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, menuItem));
            ((INotifyPropertyChanged)menuItem).PropertyChanged += HelperPropertyChanged;
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
                ((INotifyPropertyChanged)menuItem).PropertyChanged += HelperPropertyChanged;
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
        public decimal SalesTaxRate { get => _salesTaxRate; }


        /// <summary>
        /// backing field for Tax
        /// </summary>
        public decimal _tax;

        /// <summary>
        /// Tax
        /// </summary>
        public decimal Tax
        {
            get 
            {
                _tax = Subtotal * SalesTaxRate;
                return _tax;
            }
        }


        /// <summary>
        /// backing field for Subtotal
        /// </summary>
        public decimal _subtotal;

        /// <summary>
        /// Subtotal
        /// </summary>
        public decimal Subtotal
        {
            get
            {
                _subtotal = Tax * SalesTaxRate;
                return _subtotal;
            }
        }

        /// <summary>
        /// backing field for Total
        /// </summary>
        public decimal _total;

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total
        {
            get
            {
                _total = Subtotal + Tax;
                return _total;
            }
        }


        /// <summary>
        /// backing field for Calories
        /// </summary>
        public uint _calories;

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
                    _calories = menuItem.Calories;
                    sumOfCalories = _calories++;
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
               _number = NextOrderNumber;
                return _number;
            }

            set => NextOrderNumber++;
        }

        /// <summary>
        /// Ensures uniqueness of order number
        /// </summary>
        private static int NextOrderNumber { get; set; } = 1;


        /// <summary>
        /// backing field for PlacedAt
        /// </summary>
        public DateTime _placedAt = DateTime.Now;

        /// <summary>
        /// Data and time the order was placed
        /// </summary>
        public DateTime PlacedAt { get => _placedAt; }
        
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

    }
}
