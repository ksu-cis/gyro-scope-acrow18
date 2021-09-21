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
    }
}
