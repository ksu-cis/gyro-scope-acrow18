/*
* VirgoClassicGyroTests.cs
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
    public class VirgoClassicGyroTests
    {
        /// <summary>
        /// Checks default ingridents
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            var VirgoClassicGyro = new VirgoClassicGyro();
            Assert.Equal(DonerMeat.Pork, VirgoClassicGyro.Meat);
            Assert.True(VirgoClassicGyro.Pita);
            Assert.True(VirgoClassicGyro.Tomato);
            Assert.True(VirgoClassicGyro.Onion);
            Assert.True(VirgoClassicGyro.Lettuce);
            Assert.True(VirgoClassicGyro.Tzatziki);
            Assert.False(VirgoClassicGyro.Peppers);
            Assert.False(VirgoClassicGyro.WingSauce);
            Assert.False(VirgoClassicGyro.Eggplant);
            Assert.False(VirgoClassicGyro.MintChutney);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var VirgoClassicGyro = new VirgoClassicGyro();
            Assert.Equal(5.50M, VirgoClassicGyro.Price);
        }

        
        [Theory]
        [InlineData(DonerMeat.Pork, true)]
        //add test cases
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
            VirgoClassicGyro.Meat = meat;
            //set boolean properties
            VirgoClassicGyro.Pita = pita;
            Assert.Equal(calories, VirgoClassicGyro.Calories);
        }


        [Theory]
        //Last entry of new InlineData new String[]{"Add Peppers"};
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
            //copy calories
            
        }
        
    }
}