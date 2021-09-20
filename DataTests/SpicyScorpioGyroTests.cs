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

        /*
        [Theory]
        [InlineData(DonerMeat.Pork, )]
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
            var VirgoClassicGyro = new VirgoClassicGyro();
            Assert.Equal(meat, 187);
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
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected) 
        {

        }
        */
    }
}