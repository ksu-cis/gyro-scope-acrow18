/*
 * PiscesFishDishTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for PiscesFishDish
    /// </summary>
    public class PiscesFishDishTests
    {
        /// <summary>
        /// Checks price of fish dish
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var PiscesFishDish = new PiscesFishDish();
            Assert.Equal(5.99M, PiscesFishDish.Price);
        }

        /// <summary>
        /// Checks calories of fish dish
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect() 
        {
            var PiscesFishDish = new PiscesFishDish();
            Assert.Equal(726U, PiscesFishDish.Calories); //not sure if this is correct
        }

        /// <summary>
        /// Checks special instructions of fish dish
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeEmpty() 
        {
            var PiscesFishDish = new PiscesFishDish();
            Assert.Null(PiscesFishDish.SpecialInstructions);
        }
    }
}