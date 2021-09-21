/*
 * AriesFriesTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for Aries Fries
    /// </summary>
    public class AriesFriesTests
    {
        /// <summary>
        /// Checks default Size
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            var ariesFries = new AriesFries();
            Assert.Equal(Size.Small, ariesFries.Size);
        }

        /// <summary>
        /// Checks that the <paramref name="Size"/> can be set
        /// </summary>
        /// <param name="Size">The Size to use</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            var ariesFries = new AriesFries();
            ariesFries.Size = size;
            Assert.Equal(size, ariesFries.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 1.50)]
        [InlineData(Size.Medium, 2.00)]
        [InlineData(Size.Large, 2.50)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            var ariesFries = new AriesFries()
            {
                Size = size
            };
            Assert.Equal(price, ariesFries.Price);
        }

        /// <summary>
        /// Aries fries should have calories for size
        /// </summary>
        /// <param name="size">Size</param>
        /// <param name="calories">Calories</param>
        [Theory]
        [InlineData(Size.Small, 304)]
        [InlineData(Size.Medium, 456)]
        [InlineData(Size.Large, 608)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            var ariesFries = new AriesFries()
            {
                Size = size,
            };

            Assert.Equal(calories, ariesFries.Calories);
        }
    }
}