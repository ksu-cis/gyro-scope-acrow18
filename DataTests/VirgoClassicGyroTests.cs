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

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var virgoClassicGyro = new VirgoClassicGyro();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(virgoClassicGyro);
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
        [InlineData(DonerMeat.Beef, "Meat")]
        [InlineData(DonerMeat.Chicken, "Meat")]
        [InlineData(DonerMeat.Lamb, "Meat")]
        [InlineData(DonerMeat.Pork, "Meat")]
        public void ShouldNotifyOfPropertyChangedWhenMeatChanges(DonerMeat meat, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (meat == DonerMeat.Pork)
            {
                virgoClassicGyro.Meat = DonerMeat.Beef;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Meat = meat;
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
        [InlineData(true, "Pita")]
        [InlineData(false, "Pita")]

        public void ShouldNotifyOfPropertyChangedWhenPitaChanges(bool pita, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing meat when setting to default meat
            if (pita == true)
            {
                virgoClassicGyro.Pita = false;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Pita = pita;
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
        [InlineData(true, "Tomato")]
        [InlineData(false, "Tomato")]

        public void ShouldNotifyOfPropertyChangedWhenTomatoChanges(bool tomato, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing tomato when setting to default 
            if (tomato == true)
            {
                virgoClassicGyro.Tomato = false;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Tomato = tomato;
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
        [InlineData(true, "Onion")]
        [InlineData(false, "Onion")]
        public void ShouldNotifyOfPropertyChangedWhenOnionChanges(bool onion, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing onion when setting to default
            if (onion == true)
            {
                virgoClassicGyro.Onion = false;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Onion = onion;
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
        [InlineData(true, "Eggplant")]
        [InlineData(false, "Eggplant")]
        public void ShouldNotifyOfPropertyChangedWhenEggplantChanges(bool eggplant, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing eggplant when setting to default
            if (eggplant == false)
            {
                virgoClassicGyro.Eggplant = true;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Eggplant = eggplant;
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
        [InlineData(true, "Lettuce")]
        [InlineData(false, "Lettuce")]
        public void ShouldNotifyOfPropertyChangedWhenLettuceChanges(bool lettuce, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing lettuce when setting to default
            if (lettuce == true)
            {
                virgoClassicGyro.Lettuce = false;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Lettuce = lettuce;
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
        [InlineData(true, "MintChutney")]
        [InlineData(false, "MintChutney")]
        public void ShouldNotifyOfPropertyChangedWhenMintChutneyChanges(bool mintChutney, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing mint chutney when setting to default
            if (mintChutney == false)
            {
                virgoClassicGyro.MintChutney = true;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.MintChutney = mintChutney;
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
        [InlineData(true, "Peppers")]
        [InlineData(false, "Peppers")]
        public void ShouldNotifyOfPropertyChangedWhenPeppersChanges(bool peppers, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing peppers when setting to default
            if (peppers == false)
            {
                virgoClassicGyro.Peppers = true;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Peppers = peppers;
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
        [InlineData(true, "WingSauce")]
        [InlineData(false, "WingSauce")]
        public void ShouldNotifyOfPropertyChangedWhenWingSauceChanges(bool wingSauce, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing wing sauce when setting to default
            if (wingSauce == false)
            {
                virgoClassicGyro.WingSauce = true;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.WingSauce = wingSauce;
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
        [InlineData(true, "Tzatziki")]
        [InlineData(false, "Tzatziki")]
        public void ShouldNotifyOfPropertyChangedWhenTzatzikiChanges(bool tzatziki, string propertyName)
        {

            var virgoClassicGyro = new VirgoClassicGyro();

            //A quick hack to avoid not changing tzatziki when setting to default
            if (tzatziki == true)
            {
                virgoClassicGyro.Tzatziki = false;
            }


            Assert.PropertyChanged(virgoClassicGyro, propertyName, () =>
            {
                virgoClassicGyro.Tzatziki = tzatziki;
            });
        }

    }
}