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

        public void OnGet(string SearchTerms, double? CalorieMax, double? CalorieMin, decimal? PriceMax, decimal? PriceMin, bool IsEntree, bool IsSide, bool isDrink, bool IsTreat)
        {
            this.SearchTerms = SearchTerms;
            this.CalorieMax = CalorieMax;
            this.CalorieMin = CalorieMin;
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.IsEntree = IsEntree;
            this.IsSide = IsSide;
            this.IsDrink = IsDrink;
            this.IsTreat = IsTreat;
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
        /// Determines whether is entree
        /// </summary>
        public bool IsEntree { get => IsEntree; set => value = IsEntree; }

        /// <summary>
        /// Determines whether is side
        /// </summary>
        public bool IsSide { get => IsSide; set => value = IsSide; }

        /// <summary>
        /// Determines whether is drink
        /// </summary>
        public bool IsDrink { get => IsDrink; set => value = IsDrink; }

        /// <summary>
        /// Determines whether is treat
        /// </summary>
        public bool IsTreat { get => IsTreat; set => value = IsTreat; }

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
