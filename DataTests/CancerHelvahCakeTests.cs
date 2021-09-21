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
    public class CancerHelvahCakeTests
    {
        /// <summary>
        /// Checks price of Cancer Helvah Cake
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var cancerHelvahCake = new CancerHelvahCake();
            Assert.Equal(3.00M, cancerHelvahCake.Price);
        }


        /// <summary>
        /// Checks calories for Cancer Helvah Cake
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect() 
        {
            var cancerHelvahCake = new CancerHelvahCake();
            Assert.Equal(272U, cancerHelvahCake.Calories);
        }

    }
}