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
        }

        /// <summary>
        /// Removes a Menu item
        /// </summary>
        /// <param name="menuItem">Menu item to remove</param>
        public void Remove(IMenuItem menuItem)
        {
            menuItemList.Remove(menuItem);
        }


        /// <summary>
        /// Rate of sales tax
        /// </summary>
        public decimal SaleTaxRate { get; set; } = 0.09M;


        /// <summary>
        /// backing field for tax
        /// </summary>
        public decimal _tax;

        /// <summary>
        /// Tax
        /// </summary>
        public decimal Tax
        {
            get => _tax;
        }


        /// <summary>
        /// backing field for subtotal
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
               _number = nextOrderNumber;
                return _number;
            }

            set => nextOrderNumber++;
        }

        /// <summary>
        /// Ensures uniqueness of order number
        /// </summary>
        private static int nextOrderNumber { get; set; } = 1;

        /// <summary>
        /// Data and time the order was placed
        /// </summary>
        public DateTimeKind PlacedAt;

        
        /// <summary>
        /// Gets count of items in Menu Item List
        /// </summary>
        public int Count => menuItemList.Count;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
