using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for GeminiStuffedGrapeLeaves
    /// </summary>
    public class GeminiStuffedGrapeLeavesTests
    {
        /// <summary>
        /// Checks default flavor
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            var geminiStuffedGrapeLeaves = new GeminiStuffedGrapeLeaves();
            Assert.Equal(Size.Small, geminiStuffedGrapeLeaves.Size);
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
            var geminiStuffedGrapeLeaves = new GeminiStuffedGrapeLeaves();
            geminiStuffedGrapeLeaves.Size = size;
            Assert.Equal(size, geminiStuffedGrapeLeaves.Size);
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
            var geminiStuffedGrapeLeaves = new GeminiStuffedGrapeLeaves()
            {
                Size = size
            };
            Assert.Equal(price, geminiStuffedGrapeLeaves.Price);
        }

        /// <summary>
        /// Gemini Stuffed Grape Leaves should have calories for size
        /// </summary>
        /// <param name="size">Size</param>
        /// <param name="calories">Calories</param>
        [Theory]
        [InlineData(Size.Small, 360)]
        [InlineData(Size.Medium, 540)]
        [InlineData(Size.Large, 720)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            var geminiStuffedGrapeLeaves = new GeminiStuffedGrapeLeaves()
            {
                Size = size,
            };

            Assert.Equal(calories, geminiStuffedGrapeLeaves.Calories);
        }


    }
}
