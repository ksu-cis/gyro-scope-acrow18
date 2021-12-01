/*
 * CancerHelvahCakeTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for Aries Fries
    /// </summary>
    public class CancerHalvaCakeTests
    {
        /// <summary>
        /// Checks price of Cancer Helvah Cake
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var cancerHelvahCake = new CancerHalvaCake();
            Assert.Equal(3.00M, cancerHelvahCake.Price);
        }

        /// <summary>
        /// Checks to make sure description matches
        /// </summary>
        [Fact]
        public void CheckDescription()
        {
            var cancerHelvahCake = new CancerHalvaCake();
            Assert.Equal("A gluten-free cake made from sesame seeds.", cancerHelvahCake.Description);
        }

        /// <summary>
        /// Checks calories for Cancer Helvah Cake
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect() 
        {
            var cancerHelvahCake = new CancerHalvaCake();
            Assert.Equal(272U, cancerHelvahCake.Calories);
        }

    }
}