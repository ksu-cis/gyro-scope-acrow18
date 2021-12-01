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
        /// <summary>
        /// Used to log infomation
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="logger">Used to log information</param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// On get method
        /// </summary>
        /// <param name="SearchTerms">Search terms</param>
        /// <param name="CalorieMax">Max calories</param>
        /// <param name="CalorieMin">Min calories</param>
        /// <param name="PriceMax">Max price</param>
        /// <param name="PriceMin">Min price</param>
        /// <param name="entrees">Entrees</param>
        /// <param name="sides">Sides</param>
        /// <param name="drinks">Drinks</param>
        /// <param name="treats">Treats</param>
        public void OnGet(string SearchTerms, double? CalorieMax, double? CalorieMin, decimal? PriceMax, decimal? PriceMin, bool entrees, bool sides, bool drinks, bool treats)
        {
            this.SearchTerms = SearchTerms;
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.IsEntree = entrees;
            this.IsSide = sides;
            this.IsDrink = drinks;
            this.IsTreat = treats;

            MenuItems = Menu.Search(SearchTerms);

            if (IsEntree == false) 
            {
                MenuItems = MenuItems.Where(Item => !(Item is Entree));
            }

            if (IsSide == false)
            {
                MenuItems = MenuItems.Where(Item => !(Item is Side));
            }

            if (IsDrink == false)
            {
                MenuItems = MenuItems.Where(Item => !(Item is Drink));
            }

            if (IsTreat == false)
            {
                MenuItems = MenuItems.Where(Item => !(Item is Treat));
            }

            if (PriceMin == null && PriceMax != null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Price != 0 &&
                    item.Price <= PriceMax
                    );
            }

            if (PriceMax == null && PriceMin != null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Price != 0 &&
                    item.Price >= PriceMin
                    );
            }

            if (PriceMin != null && PriceMax != null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Price != 0 &&
                    item.Price <= PriceMax && item.Price >= PriceMin
                    );
            }

            if (CalorieMin == null && CalorieMax != null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Calories != 0 &&
                    item.Calories <= CalorieMax
                    );
            }

            if (CalorieMin != null && CalorieMax == null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Calories != 0 &&
                    item.Calories >= CalorieMin
                    );
            }

            if (CalorieMin != null && CalorieMax != null)
            {
                MenuItems = MenuItems.Where(item =>
                    item.Calories != 0 &&
                    item.Calories <= CalorieMax && item.Calories >= CalorieMin
                    );
            }

            MenuItems = Menu.FilterByCalories(MenuItems, CalorieMin, CalorieMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);

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
        /// backing field for IsEntree
        /// </summary>
        private bool isentree = true;

        /// <summary>
        /// Determines whether is entree
        /// </summary>
        public bool IsEntree { get => isentree; set => isentree = value; }


        /// <summary>
        /// backing field for IsEntree
        /// </summary>
        private bool isside = true;

        /// <summary>
        /// Determines whether is side
        /// </summary>
        public bool IsSide { get => isside; set => isside = value; }

        /// <summary>
        /// backing field for IsEntree
        /// </summary>
        private bool isdrink = true;

        /// <summary>
        /// Determines whether is drink
        /// </summary>
        public bool IsDrink { get => isdrink; set => isdrink = value; }

        /// <summary>
        /// backing field for IsEntree
        /// </summary>
        private bool istreat = true;

        /// <summary>
        /// Determines whether is treat
        /// </summary>
        public bool IsTreat { get => istreat; set => istreat = value; }

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
        public decimal? PriceMin { get; set; }

        /// <summary>
        /// Max price
        /// </summary>
        public decimal? PriceMax { get; set; }
    }
}
