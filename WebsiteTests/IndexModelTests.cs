using GyroScope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Pages;
using Xunit;

namespace Website
{
    /// <summary>
    /// Tests for index model
    /// </summary>
    public class IndexModelTests
    {
        
        /// <summary>
        /// Logger for tests
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Makes sure calories search is null by default
        /// </summary>
        [Fact]
        public void CaloriesSearchShouldBeNullByDefault() 
        {
            IndexModel IM = new IndexModel(_logger);
            Assert.Null(IM.CalorieMin);
            Assert.Null(IM.CalorieMin);
        }

        /// <summary>
        /// Makes sure price search is null by default
        /// </summary>
        [Fact]
        public void PriceSearchShouldBeNullByDefault()
        {
            IndexModel IM = new IndexModel(_logger);
            Assert.Null(IM.PriceMin);
            Assert.Null(IM.PriceMin);
        }

        /// <summary>
        /// Makes sure items are null by default
        /// </summary>
        [Fact]
        public void ItemsSearchShouldBeNullByDefault()
        {
            IndexModel IM = new IndexModel(_logger);
            Assert.Null(IM.MenuItems);
        }

        /// <summary>
        /// Should be able to hold entrees
        /// </summary>
        [Fact]
        public void ItemsShouldHoldEntreeWhenBoolIsTrue()
        {
            IndexModel IM = new IndexModel(_logger);
            IM.OnGet(null, null, null, null, null, true, false, false, false);
            Assert.Collection<IMenuItem>(IM.MenuItems,
                item => Assert.IsType<VirgoClassicGyro>(item),
                item => Assert.IsType<LeoLambGyro>(item),
                item => Assert.IsType<ScorpioSpicyGyro>(item),
                item => Assert.IsType<PiscesFishDish>(item));
        }

        /// <summary>
        /// Should be able to hold sides
        /// </summary>
        [Fact]
        public void ItemsShouldHoldSideWhenBoolIsTrue()
        {
            IndexModel IM = new IndexModel(_logger);
            IM.OnGet(null, null, null, null, null, false, true, false, false);
            Assert.Collection<IMenuItem>(IM.MenuItems,
                item => Assert.IsType<AriesFries>(item),
                item => Assert.IsType<GeminiStuffedGrapeLeaves>(item),
                item => Assert.IsType<SagittariusGreekSalad>(item),
                item => Assert.IsType<TaurusTabuleh>(item));
        }

        /// <summary>
        /// Should be able to hold drinks
        /// </summary>
        [Fact]
        public void ItemsShouldHoldDrinkWhenBoolIsTrue()
        {
            IndexModel IM = new IndexModel(_logger);
            IM.OnGet(null, null, null, null, null, false, false, true, false);
            Assert.Collection<IMenuItem>(IM.MenuItems,
                item => Assert.IsType<CapricornMountainTea>(item),
                item => Assert.IsType<LibraLibation>(item));
        }

        /// <summary>
        /// Should be able to hold treats
        /// </summary>
        [Fact]
        public void ItemsShouldHoldTreatsWhenBoolIsTrue()
        {
            IndexModel IM = new IndexModel(_logger);
            IM.OnGet(null, null, null, null, null, false, false, false, true);
            Assert.Collection<IMenuItem>(IM.MenuItems,
                item => Assert.IsType<CancerHalvaCake>(item),
                item => Assert.IsType<AquariusIce>(item));
        }
    }
}
