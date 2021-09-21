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
    public class ScorpioSpicyGyroTests
    {
        /// <summary>
        /// Checks default ingridents
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            var spicyScorpioGyro = new ScorpioSpicyGyro();
            Assert.Equal(DonerMeat.Chicken, spicyScorpioGyro.Meat);
            Assert.True(spicyScorpioGyro.Pita);
            Assert.True(spicyScorpioGyro.Peppers);
            Assert.True(spicyScorpioGyro.Onion);
            Assert.True(spicyScorpioGyro.Lettuce);
            Assert.True(spicyScorpioGyro.WingSauce);
            Assert.False(spicyScorpioGyro.MintChutney);
            Assert.False(spicyScorpioGyro.Eggplant);
            Assert.False(spicyScorpioGyro.Tzatziki);
            Assert.False(spicyScorpioGyro.Tomato);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var spicyScorpioGyro = new ScorpioSpicyGyro();
            Assert.Equal(6.20M, spicyScorpioGyro.Price);
        }



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
        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, 507U)]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, 581U)]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, 545U)]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, 575U)]
        [InlineData(DonerMeat.Chicken, false, false, false, false, false, false, false, false, false, 113U)]
        [InlineData(DonerMeat.Chicken, true, false, false, false, false, false, false, false, false, 375U)]
        [InlineData(DonerMeat.Chicken, true, true, false, false, false, false, false, false, false, 405U)]
        [InlineData(DonerMeat.Chicken, true, true, true, false, false, false, false, false, false, 438U)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            var spicyScorpioGyro = new ScorpioSpicyGyro();
            spicyScorpioGyro.Meat = meat;
            spicyScorpioGyro.Pita = pita;
            spicyScorpioGyro.Tomato = tomato;
            spicyScorpioGyro.Peppers = peppers;
            spicyScorpioGyro.Eggplant = eggplant;
            spicyScorpioGyro.Onion = onion;
            spicyScorpioGyro.Lettuce = lettuce;
            spicyScorpioGyro.Tzatziki = tzatziki;
            spicyScorpioGyro.WingSauce = wingSauce;
            spicyScorpioGyro.MintChutney = mintChutney;
            Assert.Equal(calories, spicyScorpioGyro.Calories);
        }


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
        [Theory]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, false, new String[] { })]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, new String[] { "Use Pork" })]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, new String[] { "Use Lamb" })]
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, new String[] { "Use Beef" })]
        [InlineData(DonerMeat.Chicken, false, false, true, false, true, true, false, true, false, new String[] { "Hold Pita" })]
        [InlineData(DonerMeat.Chicken, true, false, false, false, true, true, false, true, false, new String[] { "Hold Peppers" })]
        [InlineData(DonerMeat.Chicken, true, true, true, false, true, true, false, true, false, new String[] { "Add Tomato" })]
        [InlineData(DonerMeat.Chicken, true, false, true, true, true, true, false, true, false, new String[] { "Add Eggplant" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected) 
        {
            var spicyScorpioGyro = new ScorpioSpicyGyro();
            spicyScorpioGyro.Meat = meat;
            spicyScorpioGyro.Pita = pita;
            spicyScorpioGyro.Tomato = tomato;
            spicyScorpioGyro.Peppers = peppers;
            spicyScorpioGyro.Eggplant = eggplant;
            spicyScorpioGyro.Onion = onion;
            spicyScorpioGyro.Lettuce = lettuce;
            spicyScorpioGyro.Tzatziki = tzatziki;
            spicyScorpioGyro.WingSauce = wingSauce;
            spicyScorpioGyro.MintChutney = mintChutney;
            Assert.Equal(expected, spicyScorpioGyro.SpecialInstructions);
        }
        
    }
}