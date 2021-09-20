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
    /// Unit tests for VirgoClassicGyro
    /// </summary>
    public class LeoLambGyroTests
    {
        /// <summary>
        /// Checks default ingridents
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            var LeoLambGyro = new LeoLambGyro();
            Assert.Equal(DonerMeat.Lamb, LeoLambGyro.Meat);
            Assert.True(LeoLambGyro.Pita);
            Assert.True(LeoLambGyro.Tomato);
            Assert.True(LeoLambGyro.Onion);
            Assert.True(LeoLambGyro.Eggplant);
            Assert.True(LeoLambGyro.Lettuce);
            Assert.True(LeoLambGyro.MintChutney);
            Assert.False(LeoLambGyro.Peppers);
            Assert.False(LeoLambGyro.WingSauce);
            Assert.False(LeoLambGyro.Tzatziki);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var LeoLambGyro = new LeoLambGyro();
            Assert.Equal(5.75M, LeoLambGyro.Price);
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