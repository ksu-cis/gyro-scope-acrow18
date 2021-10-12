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

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var scorpioSpicyGyro = new ScorpioSpicyGyro();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(scorpioSpicyGyro);
        }

        /// <summary>
        /// Notifies of property change when meat is changed
        /// </summary>
        /// <param name="meat">Meat used in Gyro</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(DonerMeat.Beef, "Calories")]
        [InlineData(DonerMeat.Chicken, "Calories")]
        [InlineData(DonerMeat.Lamb, "Calories")]
        [InlineData(DonerMeat.Pork, "Calories")]
        [InlineData(DonerMeat.Beef, "SpecialInstructions")]
        [InlineData(DonerMeat.Chicken, "SpecialInstructions")]
        [InlineData(DonerMeat.Lamb, "SpecialInstructions")]
        [InlineData(DonerMeat.Pork, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenMeatChanges(DonerMeat meat, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (meat == DonerMeat.Chicken)
            {
                scorpioSpicyGyro.Meat = DonerMeat.Beef;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Meat = meat;
            });
        }

        /// <summary>
        /// Notifies of property change when pita is changed
        /// </summary>
        /// <param name="pita">Pita</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenPitaChanges(bool pita, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (pita == true)
            {
                scorpioSpicyGyro.Pita = false;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Pita = pita;
            });
        }

        /// <summary>
        /// Notifies of property change when Tomato is changed
        /// </summary>
        /// <param name="tomato">Tomato</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenTomatoChanges(bool tomato, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing tomato when setting to default 
            if (tomato == false)
            {
                scorpioSpicyGyro.Tomato = true;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Tomato = tomato;
            });
        }

        /// <summary>
        /// Notifies of property change when onion is changed
        /// </summary>
        /// <param name="onion">Onion</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenOnionChanges(bool onion, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing onion when setting to default
            if (onion == true)
            {
                scorpioSpicyGyro.Onion = false;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Onion = onion;
            });
        }

        /// <summary>
        /// Notifies of property change when eggplant is changed
        /// </summary>
        /// <param name="eggplant">Eggplant</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenEggplantChanges(bool eggplant, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing eggplant when setting to default
            if (eggplant == false)
            {
                scorpioSpicyGyro.Eggplant = true;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Eggplant = eggplant;
            });
        }

        /// <summary>
        /// Notifies of property change when lettuce is changed
        /// </summary>
        /// <param name="lettuce">Lettuce</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenLettuceChanges(bool lettuce, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing lettuce when setting to default
            if (lettuce == true)
            {
                scorpioSpicyGyro.Lettuce = false;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Lettuce = lettuce;
            });
        }

        /// <summary>
        /// Notifies of property change when mint chutney is changed
        /// </summary>
        /// <param name="mintChutney">Mint Chutney</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenMintChutneyChanges(bool mintChutney, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing mintChutney when setting to default
            if (mintChutney == false)
            {
                scorpioSpicyGyro.MintChutney = true;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.MintChutney = mintChutney;
            });
        }

        /// <summary>
        /// Notifies of property change when peppers is changed
        /// </summary>
        /// <param name="peppers">peppers</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenPeppersChanges(bool peppers, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing peppers when setting to default
            if (peppers == true)
            {
                scorpioSpicyGyro.Peppers = false;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Peppers = peppers;
            });
        }


        /// <summary>
        /// Notifies of property change when wing sauce is changed
        /// </summary>
        /// <param name="wingSauce">Wing Sauce</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenWingSauceChanges(bool wingSauce, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing wing sauce when setting to default
            if (wingSauce == true)
            {
                scorpioSpicyGyro.WingSauce = false;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.WingSauce = wingSauce;
            });
        }

        /// <summary>
        /// Notifies of property change when tzatziki is changed
        /// </summary>
        /// <param name="tzatziki">tzatziki</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Calories")]
        [InlineData(false, "Calories")]
        [InlineData(true, "SpecialInstructions")]
        [InlineData(false, "SpecialInstructions")]

        public void ShouldNotifyOfPropertyChangedWhenTzatzikiChanges(bool tzatziki, string propertyName)
        {

            var scorpioSpicyGyro = new ScorpioSpicyGyro();

            //A quick hack to avoid not changing tzatziki when setting to default
            if (tzatziki == false)
            {
                scorpioSpicyGyro.Tzatziki = true;
            }


            Assert.PropertyChanged(scorpioSpicyGyro, propertyName, () =>
            {
                scorpioSpicyGyro.Tzatziki = tzatziki;
            });
        }

    }
}