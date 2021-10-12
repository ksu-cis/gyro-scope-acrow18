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
            var leoLambGyro = new LeoLambGyro();
            Assert.Equal(DonerMeat.Lamb, leoLambGyro.Meat);
            Assert.True(leoLambGyro.Pita);
            Assert.True(leoLambGyro.Tomato);
            Assert.True(leoLambGyro.Onion);
            Assert.True(leoLambGyro.Eggplant);
            Assert.True(leoLambGyro.Lettuce);
            Assert.True(leoLambGyro.MintChutney);
            Assert.False(leoLambGyro.Peppers);
            Assert.False(leoLambGyro.WingSauce);
            Assert.False(leoLambGyro.Tzatziki);
        }

        /// <summary>
        /// Checks price of gyro
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            var leoLambGyro = new LeoLambGyro();
            Assert.Equal(5.75M, leoLambGyro.Price);
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
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, 584U)]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, false, false, true, 620U)]
        [InlineData(DonerMeat.Chicken, true, true, false, true, true, true, false, false, true, 546U)]
        [InlineData(DonerMeat.Beef, true, true, false, true, true, true, false, false, true, 614U)]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, false, false, 557U)]
        [InlineData(DonerMeat.Lamb, false, false, false, false, false, false, false, false, false, 151U)]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, 322U)]
        [InlineData(DonerMeat.Lamb, true, false, false, true, true, true, false, false, true, 554U)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, uint calories)
        {
            var leoLambGyro = new LeoLambGyro();
            leoLambGyro.Meat = meat;
            leoLambGyro.Pita = pita;
            leoLambGyro.Tomato = tomato;
            leoLambGyro.Peppers = peppers;
            leoLambGyro.Eggplant = eggplant;
            leoLambGyro.Onion = onion;
            leoLambGyro.Lettuce = lettuce;
            leoLambGyro.Tzatziki = tzatziki;
            leoLambGyro.WingSauce = wingSauce;
            leoLambGyro.MintChutney = mintChutney;
            Assert.Equal(calories, leoLambGyro.Calories);
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
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, true, new String[] { })]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, false, false, true, new String[] { "Use Pork" })]
        [InlineData(DonerMeat.Chicken, true, true, false, true, true, true, false, false, true, new String[] { "Use Chicken" })]
        [InlineData(DonerMeat.Beef, true, true, false, true, true, true, false, false, true, new String[] { "Use Beef" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, new String[] { "Hold Pita" })]
        [InlineData(DonerMeat.Lamb, true, false, false, true, true, true, false, false, true, new String[] { "Hold Tomato" })]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, false, false, true, new String[] { "Add Peppers" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, true, false, true, new String[] { "Add Tzatziki" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers, bool eggplant, bool onion, bool lettuce, bool tzatziki, bool wingSauce, bool mintChutney, string[] expected) 
        {
            var leoLambGyro = new LeoLambGyro();
            leoLambGyro.Meat = meat;
            leoLambGyro.Pita = pita;
            leoLambGyro.Tomato = tomato;
            leoLambGyro.Peppers = peppers;
            leoLambGyro.Eggplant = eggplant;
            leoLambGyro.Onion = onion;
            leoLambGyro.Lettuce = lettuce;
            leoLambGyro.Tzatziki = tzatziki;
            leoLambGyro.WingSauce = wingSauce;
            leoLambGyro.MintChutney = mintChutney;
            Assert.Equal(expected, leoLambGyro.SpecialInstructions);
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var leoLambGyro = new LeoLambGyro();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(leoLambGyro);
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (meat == DonerMeat.Lamb)
            {
                leoLambGyro.Meat = DonerMeat.Beef;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Meat = meat;
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

        public void ShouldNotifyOfPropertyChangedWhenPitaChanges(bool pita , string propertyName)
        {

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (pita == true)
            {
                leoLambGyro.Pita = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Pita = pita;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing tomato when setting to default 
            if (tomato == true)
            {
                leoLambGyro.Tomato = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Tomato = tomato;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing onion when setting to default
            if (onion == true)
            {
                leoLambGyro.Onion = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Onion = onion;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing eggplant when setting to default
            if (eggplant == true)
            {
                leoLambGyro.Eggplant = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Eggplant = eggplant;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing lettuce when setting to default
            if (lettuce == true)
            {
                leoLambGyro.Lettuce = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Lettuce = lettuce;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing mintChutney when setting to default
            if (mintChutney == true)
            {
                leoLambGyro.MintChutney = false;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.MintChutney = mintChutney;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing mintChutney when setting to default
            if (peppers == false)
            {
                leoLambGyro.Peppers = true;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Peppers = peppers;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing mintChutney when setting to default
            if (wingSauce == false)
            {
                leoLambGyro.WingSauce = true;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.WingSauce = wingSauce;
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

            var leoLambGyro = new LeoLambGyro();

            //A quick hack to avoid not changing mintChutney when setting to default
            if (tzatziki == false)
            {
                leoLambGyro.Tzatziki = true;
            }


            Assert.PropertyChanged(leoLambGyro, propertyName, () =>
            {
                leoLambGyro.Tzatziki = tzatziki;
            });
        }

    }
}