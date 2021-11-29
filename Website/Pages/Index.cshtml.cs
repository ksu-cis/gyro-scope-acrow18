using GyroScope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, double? CalorieMax, double? CalorieMin, double? PriceMax, double? PriceMin)
        {
            this.SearchTerms = SearchTerms;
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            MenuItems = Menu.Search(SearchTerms);
        }

        /// <summary>
        /// Keeps track of menu
        /// </summary>
        public IEnumerable<IMenuItem> MenuItems { get; set; }

        /// <summary>
        /// Entrees
        /// </summary>
        public IEnumerable<Entree> Entrees { get => MenuItems.OfType<Entree>(); }

        /// <summary>
        /// Sides
        /// </summary>
        public IEnumerable<Side> Sides { get => MenuItems.OfType<Side>(); }

        /// <summary>
        /// Drinks
        /// </summary>
        public IEnumerable<Drink> Drinks { get => MenuItems.OfType<Drink>(); }

        /// <summary>
        /// Treats
        /// </summary>
        public IEnumerable<Treat> Treats { get => MenuItems.OfType<Treat>(); }

        /// <summary>
        /// Terms to be searched
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Min calories
        /// </summary>
        public double? CalorieMin { get; set; }

        /// <summary>
        /// Max calories
        /// </summary>
        public double? CalorieMax { get; set; }

        /// <summary>
        /// Min price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Max price
        /// </summary>
        public double? PriceMax { get; set; }
    }
}
