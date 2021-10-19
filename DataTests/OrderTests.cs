/*
 * OrderTests.cs
 * Author: Alisha C.
 */

using GyroScope.Data;
using GyroScope.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for order class
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// Notifies of collection changed on add
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnAdd()
        {
            var order = new Order<IMenuItem>();
            NotifyCollectionChangedEventArgs args = null;

            order.CollectionChanged += (sender, e) =>
            {
                args = e;
            };

            var leoLambGyro = new LeoLambGyro();
            order.Add(leoLambGyro);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Add, args.Action);
            Assert.Equal(leoLambGyro, args.NewItems[0]);
            Assert.Equal(1, args.NewItems.Count);
            Assert.Null(args.OldItems);
        }

        /// <summary>
        /// Notifies of collection changed on add
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedOnRemove()
        {
            var order = new Order<IMenuItem>();
            NotifyCollectionChangedEventArgs args = null;

            order.CollectionChanged += (sender, e) =>
            {
                args = e;
            };

            var leoLambGyro = new LeoLambGyro();
            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            ///adding items to be able to remove an item
            order.Add(leoLambGyro);
            order.Add(scorpioSpicyGyro);

            order.Remove(leoLambGyro, 0);

            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Remove, args.Action);
            Assert.Equal(order, args.NewItems[0]);
            Assert.Equal(order, args.NewItems[1]);
            Assert.Equal(1, args.NewItems.Count);
            Assert.Null(args.OldItems);
        }

        /// <summary>
        /// Checks if INotifyCollectionChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyCollectionChanged()
        {
            var order = new Order<IMenuItem>();
            Assert.IsAssignableFrom<System.Collections.Specialized.INotifyCollectionChanged>(order);
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var order = new Order<IMenuItem>();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(order);
        }

        /// <summary>
        /// Notifies of total changing when adding an item
        /// </summary>
        [Fact]
        public void ShouldNotifyofTotalChangingOnAdd()
        {
            var order = new Order<IMenuItem>();
            var leoLambGyro = new LeoLambGyro();
            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(leoLambGyro);
            });
        }

        /// <summary>
        /// Notifies of Subtotal changing when adding an item
        /// </summary>
        [Fact]
        public void ShouldNotifyofSubtotalChangingOnAdd()
        {
            var order = new Order<IMenuItem>();
            var leoLambGyro = new LeoLambGyro();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(leoLambGyro);
            });
        }

        /// <summary>
        /// Notifies of Tax changing when adding an item
        /// </summary>
        [Fact]
        public void ShouldNotifyofTaxChangingOnAdd()
        {
            var order = new Order<IMenuItem>();
            var leoLambGyro = new LeoLambGyro();
            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(leoLambGyro);
            });
        }

        /// <summary>
        /// Notifies of calories changing when adding an item
        /// </summary>
        [Fact]
        public void ShouldNotifyofCaloriesChangingOnAdd()
        {
            var order = new Order<IMenuItem>();
            var leoLambGyro = new LeoLambGyro();
            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(leoLambGyro);
            });
        }
    }
}
