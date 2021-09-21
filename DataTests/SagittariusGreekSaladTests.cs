/*
 * SagittariusGreekSaladTest.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for SagittariusGreekSalad
    /// </summary>
    public class SagittariusGreekSaladTests
    {
        /// <summary>
        /// Checks default size
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            var sagittariusGreekSalad = new SagittariusGreekSalad();
            Assert.Equal(Size.Small, sagittariusGreekSalad.Size);
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
            var sagittariusGreekSalad = new SagittariusGreekSalad();
            sagittariusGreekSalad.Size = size;
            Assert.Equal(size, sagittariusGreekSalad.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 2.00)]
        [InlineData(Size.Medium, 2.50)]
        [InlineData(Size.Large, 3.00)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            var sagittariusGreekSalad = new SagittariusGreekSalad()
            {
                Size = size
            };
            Assert.Equal(price, sagittariusGreekSalad.Price);
        }

        /// <summary>
        /// Sagittarius Greek Salad should have calories for size
        /// </summary>
        /// <param name="size">Size</param>
        /// <param name="calories">Calories</param>
        [Theory]
        [InlineData(Size.Small, 180)]
        [InlineData(Size.Medium, 270)]
        [InlineData(Size.Large, 360)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            var sagittariusGreekSalad = new SagittariusGreekSalad()
            {
                Size = size,
            };

            Assert.Equal(calories, sagittariusGreekSalad.Calories);
        }
    }
}
