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
            var piscesFishDish = new PiscesFishDish();
            Assert.Equal(5.99M, piscesFishDish.Price);
        }

        /// <summary>
        /// Checks to make sure description matches
        /// </summary>
        [Fact]
        public void CheckDescription()
        {
            var piscesFishDish = new PiscesFishDish();
            Assert.Equal("Halibut baked with onions and tomatoes in a red wine sauce.", piscesFishDish.Description);
        }

        /// <summary>
        /// Checks calories of fish dish
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect() 
        {
            var piscesFishDish = new PiscesFishDish();
            Assert.Equal(726U, piscesFishDish.Calories); //not sure if this is correct
        }

        /// <summary>
        /// Checks special instructions of fish dish
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeEmpty() 
        {
            var piscesFishDish = new PiscesFishDish();
            Assert.Null(piscesFishDish.SpecialInstructions);
        }
    }
}