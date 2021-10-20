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
    public class Order<IMenuItems> : ICollection, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event handlerfor changing collections
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
        /// Used to trigger a collection changed add event
        /// </summary>
        /// <param name="menuItem">Menu item to add</param>
        protected void OnCollectionChangedAdd(IMenuItem menuItem) 
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs((NotifyCollectionChangedAction)CollectionChangeAction.Add, menuItem));
        }

        /// <summary>
        /// Used to trigger a collection changed removed event
        /// </summary>
        /// <param name="menuItem">Menu item to remove</param>
        /// <param name="index">Index of menu item to remove</param>
        protected void OnCollectionChangedRemove(IMenuItem menuItem, int index)
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs((NotifyCollectionChangedAction)CollectionChangeAction.Remove, menuItem, index));
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
            OnCollectionChangedAdd(menuItem);
            OnPropertyChanged(nameof(this.Subtotal));
            OnPropertyChanged(nameof(this.Tax));
            OnPropertyChanged(nameof(this.Total));
            OnPropertyChanged(nameof(this.Calories));
        }

        /// <summary>
        /// Removes a Menu item
        /// </summary>
        /// <param name="menuItem">Menu item to remove</param>
        /// <param name="index">Index of menu item to remove</param>
        public void Remove(IMenuItem menuItem, int index)
        {
            menuItemList.Remove(menuItem);
            OnCollectionChangedRemove(menuItem, index);
            OnPropertyChanged(nameof(this.Subtotal));
            OnPropertyChanged(nameof(this.Tax));
            OnPropertyChanged(nameof(this.Total));
            OnPropertyChanged(nameof(this.Calories));
        }


        /// <summary>
        /// Rate of sales tax
        /// </summary>
        public decimal SaleTaxRate { get; set; } = 0.09M;


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
                _tax = Subtotal * SaleTaxRate;
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
                _subtotal = Tax * SaleTaxRate;
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
        /// Data and time the order was placed
        /// </summary>
        public DateTime PlacedAt;
        
        /// <summary>
        /// Gets count of items in Menu Item List
        /// </summary>
        public int Count => menuItemList.Count;


        /// <summary>
        /// Not implemented
        /// </summary>
        public bool IsSynchronized => throw new NotImplementedException();

        /// <summary>
        /// Not implemented
        /// </summary>
        public object SyncRoot => throw new NotImplementedException();

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index">Index</param>
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <returns>not implemented exception</returns>
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
