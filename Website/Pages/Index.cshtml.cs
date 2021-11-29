using GyroScope.Data;
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

        public void OnGet(string SearchTerms)
        {
            this.SearchTerms = SearchTerms;
            MenuItems = Menu.Search(SearchTerms);
        }

        /// <summary>
        /// Keeps track of menu
        /// </summary>
        public IEnumerable<IMenuItem> MenuItems { get; set; }

        public IEnumerable<IMenuItem>

        /// <summary>
        /// Terms to be searched
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Min calories
        /// </summary>
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// Max calories
        /// </summary>
        public double? CaloriesMax { get; set; }

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
