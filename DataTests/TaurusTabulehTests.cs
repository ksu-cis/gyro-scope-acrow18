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
            var taurusTabuleh = new TaurusTabouleh();
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
            var taurusTabuleh = new TaurusTabouleh();
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
            var taurusTabuleh = new TaurusTabouleh()
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
            var taurusTabuleh = new TaurusTabouleh()
            {
                Size = size,
            };

            Assert.Equal(calories, taurusTabuleh.Calories);
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var taurusTabuleh = new TaurusTabouleh();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(taurusTabuleh);
        }

        /// <summary>
        /// Notifies of property change when size is changed
        /// </summary>
        /// <param name="size">Size of Taurus Tabuleh</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(Size.Large, "Size")]
        [InlineData(Size.Medium, "Size")]
        [InlineData(Size.Small, "Size")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Large, "Calories")]
        [InlineData(Size.Medium, "Calories")]
        [InlineData(Size.Small, "Calories")]
        [InlineData(Size.Large, "Name")]
        [InlineData(Size.Medium, "Name")]
        [InlineData(Size.Small, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {

            var taurusTabuleh = new TaurusTabouleh();

            //A quick hack to avoid not changing size when setting to default size
            if (size == Size.Small)
            {
                taurusTabuleh.Size = Size.Medium;
            }


            Assert.PropertyChanged(taurusTabuleh, propertyName, () =>
            {
                taurusTabuleh.Size = size;
            });
        }
    }
}
