/*
 * LibraLibationTests.cs
 * Author: Alisha C.
 */

using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Drinks;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AquariusIce
    /// </summary>
    public class LibraLibationTests
    {
        /// <summary>
        /// Checks default sparkling
        /// </summary>
        [Fact]
        public void ShouldDefaultToSparkling()
        {
            var libraLibation = new LibraLibation();
            Assert.True(libraLibation.Sparkling);
        }

        /// <summary>
        /// Checks that the <paramref name="sparkling"/> can be set
        /// </summary>
        /// <param name="sparkling">Sparkling</param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetSparkling(bool sparkling)
        {
            var libraLibation = new LibraLibation();
            libraLibation.Sparkling = sparkling;
            Assert.Equal(sparkling, libraLibation.Sparkling);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral)]
        [InlineData(LibraLibationFlavor.Orangeade)]
        [InlineData(LibraLibationFlavor.PinkLemonada)]
        [InlineData(LibraLibationFlavor.SourCherry)]
        public void ShouldBeAbleToSetFlavor(LibraLibationFlavor flavor)
        {
            var libraLibation = new LibraLibation();
            libraLibation.Flavor = flavor;
            Assert.Equal(flavor, libraLibation.Flavor);
        }

        /// <summary>
        /// Checks the price based on the flavor 
        /// </summary>
        /// <param name="flavor">The flavor to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 1.00)]
        [InlineData(LibraLibationFlavor.Orangeade, 1.00)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 1.00)]
        [InlineData(LibraLibationFlavor.SourCherry, 1.00)]
        public void PriceShouldBeCorrectForFlavor(LibraLibationFlavor flavor, decimal price)
        {
            var libraLibation = new LibraLibation()
            {
                Flavor = flavor
            };
            Assert.Equal(price, libraLibation.Price);

        }

        /// <summary>
        /// Checks the price based on the flavor 
        /// </summary>
        /// <param name="flavor">The flavor to check</param>
        /// <param name="calories">The expected calories</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, 120)]
        [InlineData(LibraLibationFlavor.Orangeade, 180)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 41)]
        [InlineData(LibraLibationFlavor.SourCherry, 100)]
        public void CaloriesShouldBeCorrectForFlavor(LibraLibationFlavor flavor, uint calories) 
        {
            var libraLibation = new LibraLibation()
            {
                Flavor = flavor
            };
            Assert.Equal(calories, libraLibation.Calories);
        }

        /// <summary>
        /// Libra Libation should have right name for flavor and sparkling
        /// </summary>
        /// <param name="flavor">Flavor</param>
        /// <param name="sparkling">Sparkling</param>
        /// <param name="name">Name</param>
        [Theory]
        [InlineData(Size.Small, LibraLibationFlavor.Biral, true, "Small Sparkling Biral Libra Libation")]
        [InlineData(Size.Small, LibraLibationFlavor.Biral, false, "Small Still Biral Libra Libation")]
        [InlineData(Size.Medium, LibraLibationFlavor.Orangeade, true, "Medium Sparkling Orangeade Libra Libation")]
        [InlineData(Size.Medium, LibraLibationFlavor.Orangeade, false, "Medium Still Orangeade Libra Libation")]
        [InlineData(Size.Large, LibraLibationFlavor.PinkLemonada, true, "Large Sparkling PinkLemonada Libra Libation")]
        [InlineData(Size.Large, LibraLibationFlavor.PinkLemonada, false, "Large Still PinkLemonada Libra Libation")]
        [InlineData(Size.Small, LibraLibationFlavor.SourCherry, true, "Small Sparkling SourCherry Libra Libation")]
        [InlineData(Size.Medium, LibraLibationFlavor.SourCherry, false, "Medium Still SourCherry Libra Libation")]
        public void NameShouldBeCorrectForFlavorSparklingandSize(Size size, LibraLibationFlavor flavor, bool sparkling, string name)
        {
            var libraLibation = new LibraLibation()
            {
                Size = size,
                Flavor = flavor,
                Sparkling = sparkling
            };
            Assert.Equal(name, libraLibation.Name);
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var libraLibation = new LibraLibation();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(libraLibation);
        }

        /// <summary>
        /// Notifies of property change when flavor is changed
        /// </summary>
        /// <param name="flavor">Flavor of LibraLibation</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, "Calories")]
        [InlineData(LibraLibationFlavor.Orangeade, "Calories")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Calories")]
        [InlineData(LibraLibationFlavor.SourCherry, "Calories")]
        [InlineData(LibraLibationFlavor.Biral, "Name")]
        [InlineData(LibraLibationFlavor.Orangeade, "Name")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Name")]
        [InlineData(LibraLibationFlavor.SourCherry, "Name")]
        [InlineData(LibraLibationFlavor.Biral, "Flavor")]
        [InlineData(LibraLibationFlavor.Orangeade, "Flavor")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Flavor")]
        [InlineData(LibraLibationFlavor.SourCherry, "Flavor")]
        public void ShouldNotifyOfPropertyChangedWhenFlavorChanges(LibraLibationFlavor flavor, string propertyName)
        {

            var libraLibation = new LibraLibation();

            //A quick hack to avoid not changing size when setting to default size
            if (flavor == LibraLibationFlavor.Orangeade)
            {
                libraLibation.Flavor = LibraLibationFlavor.SourCherry;
            }

            Assert.PropertyChanged(libraLibation, propertyName, () =>
            {
                libraLibation.Flavor = flavor;
            });
        }

        /// <summary>
        /// Notifies of property change when sparkling is changed
        /// </summary>
        /// <param name="sparkling">Sparkling</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(true, "Name")]
        [InlineData(false, "Name")]
        [InlineData(true, "Sparkling")]
        [InlineData(false, "Sparkling")]

        public void ShouldNotifyOfPropertyChangedWhenSparklingChanges(bool sparkling, string propertyName)
        {

            var libraLibation = new LibraLibation();

            //A quick hack to avoid not changing sparkling when setting to default
            if (sparkling == true)
            {
                libraLibation.Sparkling = false;
            }

            Assert.PropertyChanged(libraLibation, propertyName, () =>
            {
                libraLibation.Sparkling = sparkling;
            });
        }
    }
}
