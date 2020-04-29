using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The menu to display on the index page
        /// </summary>
        public IEnumerable<IOrderItem> Menus { get; protected set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets and sets the food type filters
        /// </summary>
        public string[] Types { get; set; }

        /// <summary>
        /// Gets and sets the calorie minimium amount
        /// </summary>
        public double? CalMin { get; set; }

        /// <summary>
        /// Gets and sets the calorie maximum amount
        /// </summary>
        public double? CalMax { get; set; }

        /// <summary>
        /// Gets and sets the minimum price amount
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the maximum price amount
        /// </summary>
        public double? PriceMax { get; set; }

        public void OnGet(double? CalMin, double? CalMax, double? PriceMin, double? PriceMax)
        {
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            this.CalMin = CalMin;
            this.CalMax = CalMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            Menus = Menu.Search(SearchTerms);
            Menus = Menu.FilterByItemType(Menus, Types);
            Menus = Menu.FilterByCalories(Menus, CalMin, CalMax);
            Menus = Menu.FilterByPrice(Menus, PriceMin, PriceMax);
        }
    }
}
