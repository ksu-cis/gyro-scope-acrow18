/*
 * TaurusTabulehTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for TaurusTabuleh
    /// </summary>
    public class TaurusTabulehTests
    {
        /// <summary>
        /// Checks default Size
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            var taurusTabuleh = new TaurusTabuleh();
            Assert.Equal(Size.Small, taurusTabuleh.Size);
        }

        /// <summary>
        /// Checks that the <paramref name="size"/> can be set
        /// </summary>
        /// <param name="size">The Size to use</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            var taurusTabuleh = new TaurusTabuleh();
            taurusTabuleh.Size = size;
            Assert.Equal(size, taurusTabuleh.Size);
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
            var taurusTabuleh = new TaurusTabuleh()
            {
                Size = size
            };
            Assert.Equal(price, taurusTabuleh.Price);
        }

        /// <summary>
        /// Taurus Tabuleh should have calories for size
        /// </summary>
        /// <param name="size">Size</param>
        /// <param name="calories">Calories</param>
        [Theory]
        [InlineData(Size.Small, 124)]
        [InlineData(Size.Medium, 186)]
        [InlineData(Size.Large, 248)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            var taurusTabuleh = new TaurusTabuleh()
            {
                Size = size,
            };

            Assert.Equal(calories, taurusTabuleh.Calories);
        }
    }
}
