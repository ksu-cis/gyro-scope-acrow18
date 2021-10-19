/*
 * OrderTests.cs
 * Author: Alisha C.
 */

using GyroScope.Data;
using System;
using System.Collections.Generic;
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
