/* Index.cshtml.cs
 * Author: Samantha Rupnick
 * Purpose: Contains the code for filtering the menu using Linq
 */

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
            Menus = Menu.All();
            //Filter by Search Terms
            if (SearchTerms != null)
            {
                Menus = Menus.Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            //Filter by Item Type
            if(Types != null)
            {
                if(Types.Contains("Entree"))
                {
                    Menus = Menus.Where(item => item is Entree);
                }
                if(Types.Contains("Drink"))
                {
                    Menus = Menus.Where(item => item is Drink);
                }
                if(Types.Contains("Side"))
                {
                    Menus = Menus.Where(item => item is Side);
                }    
            }
            //Filter by Calories
            if(CalMin != null)
            {
                Menus = Menus.Where(item =>
                item.Calories >= CalMin);
            }
            if(CalMax != null)
            {
                Menus = Menus.Where(item =>
                item.Calories <= CalMax);
            }
            //Filter by Price
            if(PriceMin != null)
            {
                Menus = Menus.Where(item =>
                item.Price >= PriceMin);
            }
            if(PriceMax != null)
            {
                Menus = Menus.Where(item =>
                item.Price <= PriceMax);
            }
        }
    }
}
