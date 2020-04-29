using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    { 
        /// <summary>
        /// Holds a list of each entree in the menu
        /// </summary>
        /// <returns>A list of the entrees available</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> Entrees = new List<IOrderItem>();
            Entree chicken = new AngryChicken();
            Entrees.Add(chicken as IOrderItem);
            Entree chili = new CowpokeChili();
            Entrees.Add(chili as IOrderItem);
            Entree trailBurger = new TrailBurger();
            Entrees.Add(trailBurger as IOrderItem);
            Entree dakotaDouble = new DakotaDoubleBurger();
            Entrees.Add(dakotaDouble as IOrderItem);
            Entree texasTriple = new TexasTripleBurger();
            Entrees.Add(texasTriple as IOrderItem);
            Entree pork = new PecosPulledPork();
            Entrees.Add(pork as IOrderItem);
            Entree ribs = new RustlersRibs();
            Entrees.Add(ribs as IOrderItem);
            return Entrees;
        }

        /// <summary>
        /// Holds a list of each drink in the menu
        /// </summary>
        /// <returns>A list of the drinks available</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> Drinks = new List<IOrderItem>();

            //small
            Drink soda = new JerkedSoda();
            Drinks.Add(soda as IOrderItem);

            //medium
            Drink soda2 = new JerkedSoda
            {
                Size = Size.Medium
            };
            Drinks.Add(soda2 as IOrderItem);

            //large
            Drink soda3 = new JerkedSoda
            {
                Size = Size.Large
            };
            Drinks.Add(soda3 as IOrderItem);


            //small
            Drink tea = new TexasTea();
            Drinks.Add(tea as IOrderItem);

            //medium
            Drink tea2 = new TexasTea
            {
                Size = Size.Medium
            };
            Drinks.Add(tea2 as IOrderItem);

            //large
            Drink tea3 = new TexasTea
            {
                Size = Size.Large
            };
            Drinks.Add(tea3 as IOrderItem);


            //small
            Drink water = new Water();
            Drinks.Add(water as IOrderItem);

            //medium
            Drink water2 = new Water
            {
                Size = Size.Medium
            };
            Drinks.Add(water2 as IOrderItem);
            Drink water3 = new Water
            {
                //large
                Size = Size.Large
            };
            Drinks.Add(water3 as IOrderItem);


            //small
            Drink coffee = new CowboyCoffee();
            Drinks.Add(coffee as IOrderItem);

            //medium
            Drink coffee2 = new CowboyCoffee();
            coffee2.Size = Size.Medium;
            Drinks.Add(coffee2 as IOrderItem);

            //large
            Drink coffee3 = new CowboyCoffee();
            coffee3.Size = Size.Large;
            Drinks.Add(coffee3 as IOrderItem);


            return Drinks;
        }

        /// <summary>
        /// Holds a list of each sides in the menu
        /// </summary>
        /// <returns>A list of the sides available</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Sides = new List<IOrderItem>();

            //small
            Side panDeCampo = new PanDeCampo();
            Sides.Add(panDeCampo as IOrderItem);

            //medium
            Side panDeCampo2 = new PanDeCampo();
            panDeCampo2.Size = Size.Medium;
            Sides.Add(panDeCampo2 as IOrderItem);

            //large
            Side panDeCampo3 = new PanDeCampo();
            panDeCampo3.Size = Size.Large;
            Sides.Add(panDeCampo3 as IOrderItem);

            //small
            Side chiliCheeseFries = new ChiliCheeseFries();
            Sides.Add(chiliCheeseFries as IOrderItem);

            //medium
            Side chiliCheeseFries2 = new ChiliCheeseFries();
            chiliCheeseFries2.Size = Size.Medium;
            Sides.Add(chiliCheeseFries2 as IOrderItem);

            //large
            Side chiliCheeseFries3 = new ChiliCheeseFries();
            chiliCheeseFries3.Size = Size.Large;
            Sides.Add(chiliCheeseFries3 as IOrderItem);


            //small
            Side bakedBeans = new BakedBeans();
            Sides.Add(bakedBeans as IOrderItem);

            //medium
            Side bakedBeans2 = new BakedBeans();
            bakedBeans2.Size = Size.Medium;
            Sides.Add(bakedBeans2 as IOrderItem);

            //large
            Side bakedBeans3 = new BakedBeans();
            bakedBeans3.Size = Size.Large;
            Sides.Add(bakedBeans3 as IOrderItem);


            //small
            Side cornDodgers = new CornDodgers();
            Sides.Add(cornDodgers as IOrderItem);

            //medium
            Side cornDodgers2 = new CornDodgers();
            cornDodgers2.Size = Size.Medium;
            Sides.Add(cornDodgers2 as IOrderItem);

            //large
            Side cornDodgers3 = new CornDodgers();
            cornDodgers3.Size = Size.Large;
            Sides.Add(cornDodgers3 as IOrderItem);


            return Sides;
        }

        /// <summary>
        /// Holds the menu
        /// </summary>
        /// <returns>The compelete Menu</returns>
        public static IEnumerable<IOrderItem> All()
        {
            return Entrees().Concat(Drinks()).Concat(Sides());
        }

        /// <summary>
        /// Gets possible item types
        /// </summary>
        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Drink",
                "Side"
            };
        }

        /// <summary>
        /// Searches the menu for the matching items
        /// </summary>
        /// <param name="terms"> The search terms </param>
        /// <returns> A filtered menu </returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == "" || terms == null) return All();

            foreach (IOrderItem item in All())
            {
                if (item.ToString().Contains(terms, StringComparison.OrdinalIgnoreCase)) results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on the type of item
        /// </summary>
        /// <param name="menu"> The menu to filter </param>
        /// <param name="types"> The types of food to include </param>
        /// <returns> A filtered menu </returns>
        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> menu, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0) return menu;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menu)
            {
                if(item is Entree && types.Contains("Entree"))
                {
                    results.Add(item);
                }
                if(item is Drink && types.Contains("Drink"))
                {
                    results.Add(item);
                }
                if(item is Side && types.Contains("Side"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the menu by price
        /// </summary>
        /// <param name="menu"> The menu to be filtered </param>
        /// <param name="min"> The minimum price </param>
        /// <param name="max"> The maximum price </param>
        /// <returns> The filtered menu </returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max) results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filters the menu based on the number of calories
        /// </summary>
        /// <param name="menu"> The menu to filter </param>
        /// <param name="min"> The minimum number of calories </param>
        /// <param name="max"> The maximum number of calories </param>
        /// <returns> The filtered menu </returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in menu)
            {
                if (item.Calories <= max && item.Calories >= min) results.Add(item);
            }

            return results;
        }
    }
}
