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
            var virgoClassicGyro = new VirgoClassicGyro();
            Assert.Equal(DonerMeat.Pork, virgoClassicGyro.Meat);
            Assert.True(virgoClassicGyro.Pita);
            Assert.True(virgoClassicGyro.Tomato);
            Assert.True(virgoClassicGyro.Onion);
            Assert.True(virgoClassicGyro.Lettuce);
            Assert.True(virgoClassicGyro.Tzatziki);
            Assert.False(virgoClassicGyro.Peppers);
            Assert.False(virgoClassicGyro.WingSauce);
            Assert.False(virgoClassicGyro.Eggplant);
            Assert.False(virgoClassicGyro.MintChutney);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var virgoClassicGyro = new VirgoClassicGyro();
            Assert.Equal(5.50M, virgoClassicGyro.Price);
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
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, 593U)]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, false, false, 557U)]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, 519U)]
        [InlineData(DonerMeat.Beef, true, true, false, false, true, true, true, false, false, 587U)]
        [InlineData(DonerMeat.Pork, false, false, false, false, false, false, false, false, false, 187U)]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, false, false, 331U)]
        [InlineData(DonerMeat.Pork, false, false, false, false, true, true, true, false, false, 301U)]
        [InlineData(DonerMeat.Pork, false, false, false, false, false, true, true, false, false, 271U)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            var virgoClassicGyro = new VirgoClassicGyro();
            virgoClassicGyro.Meat = meat;
            virgoClassicGyro.Pita = pita;
            virgoClassicGyro.Tomato = tomato;
            virgoClassicGyro.Peppers = peppers;
            virgoClassicGyro.Eggplant = eggplant;
            virgoClassicGyro.Onion = onion;
            virgoClassicGyro.Lettuce = lettuce;
            virgoClassicGyro.Tzatziki = tzatziki;
            virgoClassicGyro.WingSauce = wingSauce;
            virgoClassicGyro.MintChutney = mintChutney;
            Assert.Equal(calories, virgoClassicGyro.Calories);
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
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, false, new String[] { })]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, false, false, new String[] { "Use Lamb" })]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, new String[] { "Use Chicken" })]
        [InlineData(DonerMeat.Beef, true, true, false, false, true, true, true, false, false, new String[] { "Use Beef" })]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, false, false, new String[] { "Hold Pita" })] 
        [InlineData(DonerMeat.Pork, true, false, false, false, true, true, true, false, false, new String[] { "Hold Tomato" })]
        [InlineData(DonerMeat.Pork, true, true, true, false, true, true, true, false, false, new String[] { "Add Peppers" })] 
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, true, false, false, new String[] { "Add Eggplant" })] 
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected)
        {
            var virgoClassicGyro = new VirgoClassicGyro();
            virgoClassicGyro.Meat = meat;
            virgoClassicGyro.Pita = pita;
            virgoClassicGyro.Tomato = tomato;
            virgoClassicGyro.Peppers = peppers;
            virgoClassicGyro.Eggplant = eggplant;
            virgoClassicGyro.Onion = onion;
            virgoClassicGyro.Lettuce = lettuce;
            virgoClassicGyro.Tzatziki = tzatziki;
            virgoClassicGyro.WingSauce = wingSauce;
            virgoClassicGyro.MintChutney = mintChutney;
            Assert.Equal(expected, virgoClassicGyro.SpecialInstructions);
        }   
    }
}