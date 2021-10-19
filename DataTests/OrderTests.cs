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
            Assert.Equal(order, args.NewItems[0]);
            Assert.Equal(1, args.NewItems.Count);
            Assert.Null(args.OldItems);
        }

        /// <summary>
        /// Notifies of collection changed on add
        /// </summary>
        [Fact]
        public void ShouldNotifyOfCollectionChangedORemove()
        {
            var order = new Order<IMenuItem>();
            NotifyCollectionChangedEventArgs args = null;

            order.CollectionChanged += (sender, e) =>
            {
                args = e;
            };

            var leoLambGyro = new LeoLambGyro();
            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            order.Add(leoLambGyro);
            order.Add(scorpioSpicyGyro);

            order.Remove(leoLambGyro, 0);
            Assert.NotNull(args);
            Assert.Equal(NotifyCollectionChangedAction.Remove, args.Action);
            Assert.Equal(order, args.NewItems[0]);
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
    }
}
