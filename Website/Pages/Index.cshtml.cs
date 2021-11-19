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

        public void OnGet()
        {

        }


        public static IEnumerable<IMenuItem> FullMenu { get { return Menu.FullMenu; } }

        /// <summary>
        /// Searches movies in database
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>The results of the search</returns>
        public static IEnumerable<IMenuItem> Search(string terms)
        {
            List<IMenuItem> results = new List<IMenuItem>();

            //null check
            if (terms == null) return FullMenu;

            //Add menu item if the name is a match
            foreach (IMenuItem menuItem in FullMenu)
            {
                foreach (string term in terms.Split(' '))
                {
                    if (menuItem.Name != null && menuItem.Name.Contains(term))
                    {
                        results.Add(menuItem);
                        break;
                    }
                }

                foreach (string term in terms.Split(' '))
                {
                    if (menuItem.Description != null && menuItem.Description.Contains(term))
                    {
                        results.Add(menuItem);
                        break;
                    }
                }
            }

            return results;
        }

    }
}
