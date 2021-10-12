/*
 * CapricornMountainTeaTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Drinks;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for Capricorn Mountain Tea
    /// </summary>
    public class CapricornMountainTeaTests
    {
        /// <summary>
        /// Price with/without honey
        /// </summary>
        /// <param name="honey">Honey</param>
        /// <param name="price">Price</param>
        [Theory]
        [InlineData(true, 2.50)]
        [InlineData(false, 2.50)]
        public void PriceShouldBeCorrectForHoney(bool honey, decimal price) 
        {
            var capricornMountainTea = new CapricornMountainTea()
            {
                Honey = honey
            };
            Assert.Equal(price, capricornMountainTea.Price);
        }

        /// <summary>
        /// Calories with/without honey
        /// </summary>
        /// <param name="honey">Honey</param>
        /// <param name="calories">Calories</param>
        [Theory]
        [InlineData(true, 64)]
        [InlineData(false, 0)]
        public void CaloriesShouldBeCorrectForHoney(bool honey, uint calories) 
        {
            var capricornMountainTea = new CapricornMountainTea()
            {
                Honey = honey
            };
            Assert.Equal(calories, capricornMountainTea.Calories);
        }


        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var capricornMountainTea = new CapricornMountainTea();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(capricornMountainTea);
        }

        /// <summary>
        /// Notifies of property change when honey is changed
        /// </summary>
        /// <param name="honey">Honey</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenHoneyChanges(bool honey, string propertyName)
        {

            var capricornMountainTea = new CapricornMountainTea();

            //A quick hack to avoid not changing honey when set to default 
            if (honey == false)
            {
                capricornMountainTea.Honey = true;
            }


            Assert.PropertyChanged(capricornMountainTea, propertyName, () =>
            {
                capricornMountainTea.Honey = honey;
            });
        }
    }
}
