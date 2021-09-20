/*
* SpicyScorpioGyroTests.cs
* Author: Alisha C.
*/

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for SpicyScorpioGyroTests
    /// </summary>
    public class SpicyScorpioGyroTests
    {
        /// <summary>
        /// Checks default ingridents
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            var SpicyScorpioGyro = new ScorpioSpicyGyro();
            Assert.Equal(DonerMeat.Chicken, SpicyScorpioGyro.Meat);
            Assert.True(SpicyScorpioGyro.Pita);
            Assert.True(SpicyScorpioGyro.Peppers);
            Assert.True(SpicyScorpioGyro.Onion);
            Assert.True(SpicyScorpioGyro.Lettuce);
            Assert.True(SpicyScorpioGyro.WingSauce);
            Assert.False(SpicyScorpioGyro.MintChutney);
            Assert.False(SpicyScorpioGyro.Eggplant);
            Assert.False(SpicyScorpioGyro.Tzatziki);
            Assert.False(SpicyScorpioGyro.Tomato);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var SpicyScorpioGyro = new ScorpioSpicyGyro();
            Assert.Equal(6.20M, SpicyScorpioGyro.Price);
        }


        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, 507U)]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, 581U)]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, 545U)]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, 575U)]
        [InlineData(DonerMeat.Chicken, false, false, false, false, false, false, false, false, false, 113U)]
        [InlineData(DonerMeat.Chicken, true, false, false, false, false, false, false, false, false, 375U)]
        [InlineData(DonerMeat.Chicken, true, true, false, false, false, false, false, false, false, 405U)]
        [InlineData(DonerMeat.Chicken, true, true, true, false, false, false, false, false, false, 438U)]
        /// <summary>
        /// Checks calories based on ingridents
        /// </summary>
        /// <param name="meat">Type of meat</param>
        /// <param name="pita">Pita</param>
        /// <param name="tomato">Tomato</param>
        /// <param name="peppers">Peppers</param>
        /// <param name="eggplant">Eggplant</param>
        /// <param name="onion">Onion</param>
        /// <param name="lettuce">Lettuce</param>
        /// <param name="tzatziki">Tzatziki</param>
        /// <param name="wingSauce">WingSauce</param>
        /// <param name="mintChutney">MintChutney</param>
        /// <param name="calories">Calories</param>
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            var SpicyScorpioGyro = new ScorpioSpicyGyro();
            SpicyScorpioGyro.Meat = meat;
            SpicyScorpioGyro.Pita = pita;
            SpicyScorpioGyro.Tomato = tomato;
            SpicyScorpioGyro.Peppers = peppers;
            SpicyScorpioGyro.Eggplant = eggplant;
            SpicyScorpioGyro.Onion = onion;
            SpicyScorpioGyro.Lettuce = lettuce;
            SpicyScorpioGyro.Tzatziki = tzatziki;
            SpicyScorpioGyro.WingSauce = wingSauce;
            SpicyScorpioGyro.MintChutney = mintChutney;
            Assert.Equal(calories, SpicyScorpioGyro.Calories);
        }

        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, new String[] { })]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, new String[] { "Use Pork" })]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, new String[] { "Use Lamb" })]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, new String[] { "Use Beef" })]
        [InlineData(DonerMeat.Chicken, false, false, true, false, true, true, false, true, false, new String[] { "Hold Pita" })]
        [InlineData(DonerMeat.Chicken, true, false, false, false, true, true, false, true, false, new String[] { "Hold Peppers" })]
        [InlineData(DonerMeat.Chicken, true, true, true, false, true, true, false, true, false, new String[] { "Add Tomato"})]
        [InlineData(DonerMeat.Chicken, true, false, true, true, true, true, false, true, false, new String[] { "Add Eggplant"})]
        /// <summary>
        /// Special instructions of gyro
        /// </summary>
        /// <param name="meat">Type of meat</param>
        /// <param name="pita">Pita</param>
        /// <param name="tomato">Tomato</param>
        /// <param name="peppers">Peppers</param>
        /// <param name="eggplant">Eggplant</param>
        /// <param name="onion">Onion</param>
        /// <param name="lettuce">Lettuce</param>
        /// <param name="tzatziki">Tzatziki</param>
        /// <param name="wingSauce">WingSauce</param>
        /// <param name="mintChutney">MintChutney</param>
        /// <param name="expected">Expected special instructions</param>
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected) 
        {
            var SpicyScorpioGyro = new ScorpioSpicyGyro();
            SpicyScorpioGyro.Meat = meat;
            SpicyScorpioGyro.Pita = pita;
            SpicyScorpioGyro.Tomato = tomato;
            SpicyScorpioGyro.Peppers = peppers;
            SpicyScorpioGyro.Eggplant = eggplant;
            SpicyScorpioGyro.Onion = onion;
            SpicyScorpioGyro.Lettuce = lettuce;
            SpicyScorpioGyro.Tzatziki = tzatziki;
            SpicyScorpioGyro.WingSauce = wingSauce;
            SpicyScorpioGyro.MintChutney = mintChutney;
            Assert.Equal(expected, SpicyScorpioGyro.SpecialInstructions);
        }
        
    }
}