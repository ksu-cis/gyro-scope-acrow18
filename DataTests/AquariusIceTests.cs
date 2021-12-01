using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AquariusIce
    /// </summary>
    public class AquariusIceTests
    {
        /// <summary>
        /// Checks default flavor
        /// </summary>
        [Fact]
        public void FlavorShouldDefaultToLemon()
        {
            var ice = new AquariusIce();
            Assert.Equal(AquariusIceFlavor.Lemon, ice.Flavor);
        }

        /// <summary>
        /// Checks to make sure description matches
        /// </summary>
        [Fact]
        public void CheckDescription()
        {
            var ice = new AquariusIce();
            Assert.Equal("Italian flavored ices, the coolest treat you can eat with a spoon!", ice.Description);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry)]
        [InlineData(AquariusIceFlavor.Lemon)]
        [InlineData(AquariusIceFlavor.Mango)]
        [InlineData(AquariusIceFlavor.Orange)]
        [InlineData(AquariusIceFlavor.Strawberry)]
        [InlineData(AquariusIceFlavor.Watermellon)]
        public void ShouldBeAbleToSetFlavor(AquariusIceFlavor flavor)
        {
            var ice = new AquariusIce();
            ice.Flavor = flavor;
            Assert.Equal(flavor, ice.Flavor);
        }

        /// <summary>
        /// Checks the default size
        /// </summary>
        [Fact]
        public void ShouldDefaultToSmall()
        {
            var ice = new AquariusIce();
            Assert.Equal(Size.Small, ice.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 2.0)]
        [InlineData(Size.Medium, 2.5)]
        [InlineData(Size.Large, 3.0)]
        public void ShouldHaveTheRightPriceForSize(Size size, decimal price)
        {
            var ice = new AquariusIce()
            {
                Size = size
            };
            Assert.Equal(price, ice.Price);

        }

        /// <summary>
        /// Should be able to set size of aquarius ice
        /// </summary>
        /// <param name="size">Size of aquarius ice</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            var ice = new AquariusIce() { Size = size };
            Assert.Equal(size, ice.Size);
        }

        /// <summary>
        /// Aquarius Ice should have right name for size and flavor
        /// </summary>
        /// <param name="size">Size</param>
        /// <param name="flavor">Flavor</param>
        /// <param name="name">Name</param>
        [Theory]
        [InlineData(Size.Small, AquariusIceFlavor.BlueRaspberry, "Small BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Lemon, "Small Lemon Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Mango, "Small Mango Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Orange, "Small Orange Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Strawberry, "Small Strawberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Watermellon, "Small Watermellon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.BlueRaspberry, "Medium BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Lemon, "Medium Lemon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Mango, "Medium Mango Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Orange, "Medium Orange Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Strawberry, "Medium Strawberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Watermellon, "Medium Watermellon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.BlueRaspberry, "Large BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Lemon, "Large Lemon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Mango, "Large Mango Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Orange, "Large Orange Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Strawberry, "Large Strawberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Watermellon, "Large Watermellon Aquarius Ice")]
        public void ShouldHaveTheRightNameForSizeAndFlavor(Size size, AquariusIceFlavor flavor, string name)
        {
            var ice = new AquariusIce()
            {
                Size = size,
                Flavor = flavor
            };
            Assert.Equal(name, ice.Name);
        }

        /// <summary>
        /// Checks if INotifyPropertyChanged is implemented
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged() 
        {
            var ice = new AquariusIce();
            Assert.IsAssignableFrom<System.ComponentModel.INotifyPropertyChanged>(ice);
        }

        /// <summary>
        /// Notifies of property change when size is changed
        /// </summary>
        /// <param name="size">Size of aquarius ice</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(Size.Large, "Size")]
        [InlineData(Size.Medium, "Size")]
        [InlineData(Size.Small, "Size")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Large, "Flavor")]
        [InlineData(Size.Medium, "Flavor")]
        [InlineData(Size.Small, "Flavor")]
        [InlineData(Size.Large, "Name")]
        [InlineData(Size.Medium, "Name")]
        [InlineData(Size.Small, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName) 
        {

            var ice = new AquariusIce();

            //A quick hack to avoid not changing size when setting to default size
            if (size == Size.Small) 
            {
                ice.Size = Size.Medium;
            }

            
            Assert.PropertyChanged(ice, propertyName, () =>
            {
                ice.Size = size;
            });
        }

        /// <summary>
        /// Notifies of property change when flavor is changed
        /// </summary>
        /// <param name="flavor">Flavor of Aquarius ice</param>
        /// <param name="propertyName">Name of property</param>
        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry, "Flavor")]
        [InlineData(AquariusIceFlavor.Lemon, "Flavor")]
        [InlineData(AquariusIceFlavor.Mango, "Flavor")]
        [InlineData(AquariusIceFlavor.Watermellon, "Name")]
        [InlineData(AquariusIceFlavor.Strawberry, "Name")]
        [InlineData(AquariusIceFlavor.Orange, "Name")]
        [InlineData(AquariusIceFlavor.Lemon, "Name")]
        [InlineData(AquariusIceFlavor.BlueRaspberry, "Calories")]
        [InlineData(AquariusIceFlavor.Lemon, "Calories")]
        [InlineData(AquariusIceFlavor.Mango, "Calories")]
        public void ShouldNotifyOfPropertyChangeWhenFlavorChanges(AquariusIceFlavor flavor, string propertyName) 
        {
            var ice = new AquariusIce();

            //A quick hack to avoid not changing size when setting to default size
            if (flavor == AquariusIceFlavor.Lemon)
            {
                ice.Flavor = AquariusIceFlavor.Orange;
            }


            Assert.PropertyChanged(ice, propertyName, () =>
            {
                ice.Flavor = flavor;
            });
        }
    }
}
