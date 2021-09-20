/*
* LeoLambGyroTests.cs
* Author: Alisha C.
*/

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for LeoLambGyroTests
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

        
        [Theory]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, 584U)]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, false, false, true, 620U)]
        [InlineData(DonerMeat.Chicken, true, true, false, true, true, true, false, false, true, 546U)]
        [InlineData(DonerMeat.Beef, true, true, false, true, true, true, false, false, true, 614U)]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, false, false, 557U)]
        [InlineData(DonerMeat.Lamb, false, false, false, false, false, false, false, false, false, 151U)]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, 322U)]
        [InlineData(DonerMeat.Lamb, true, false, false, true, true, true, false, false, true, 554U)]
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
            var LeoLambGyro = new LeoLambGyro();
            LeoLambGyro.Meat = meat;
            LeoLambGyro.Pita = pita;
            LeoLambGyro.Tomato = tomato;
            LeoLambGyro.Peppers = peppers;
            LeoLambGyro.Eggplant = eggplant;
            LeoLambGyro.Onion = onion;
            LeoLambGyro.Lettuce = lettuce;
            LeoLambGyro.Tzatziki = tzatziki;
            LeoLambGyro.WingSauce = wingSauce;
            LeoLambGyro.MintChutney = mintChutney;
            Assert.Equal(calories, LeoLambGyro.Calories);
        }

        [Theory]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, new String[] { })]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, false, false, true, new String[] { "Use Pork" })]
        [InlineData(DonerMeat.Chicken, true, true, false, true, true, true, false, false, true, new String[] { "Use Chicken" })]
        [InlineData(DonerMeat.Beef, true, true, false, true, true, true, false, false, true, new String[] { "Use Beef" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, new String[] { "Hold Pita" })]
        [InlineData(DonerMeat.Lamb, true, false, false, true, true, true, false, false, true, new String[] { "Hold Tomato"})]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, false, false, true, new String[] { "Add Peppers" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, true, false, true, new String[] { "Add Tzatziki" })]

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
            var LeoLambGyro = new LeoLambGyro();
            LeoLambGyro.Meat = meat;
            LeoLambGyro.Pita = pita;
            LeoLambGyro.Tomato = tomato;
            LeoLambGyro.Peppers = peppers;
            LeoLambGyro.Eggplant = eggplant;
            LeoLambGyro.Onion = onion;
            LeoLambGyro.Lettuce = lettuce;
            LeoLambGyro.Tzatziki = tzatziki;
            LeoLambGyro.WingSauce = wingSauce;
            LeoLambGyro.MintChutney = mintChutney;
            Assert.Equal(expected, LeoLambGyro.SpecialInstructions);
        }
        
    }
}