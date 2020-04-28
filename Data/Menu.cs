using System;
using System.Collections.Generic;
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
            object soda = new JerkedSoda();
            Drinks.Add(soda as IOrderItem);
            object tea = new TexasTea();
            Drinks.Add(tea as IOrderItem);
            object water = new Water();
            Drinks.Add(water as IOrderItem);
            object coffee = new CowboyCoffee();
            Drinks.Add(coffee as IOrderItem);
            return Drinks;
        }

        /// <summary>
        /// Holds a list of each sides in the menu
        /// </summary>
        /// <returns>A list of the sides available</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Sides = new List<IOrderItem>();
            object panDeCampo = new PanDeCampo();
            Sides.Add(panDeCampo as IOrderItem);
            object chiliCheeseFries = new ChiliCheeseFries();
            Sides.Add(chiliCheeseFries as IOrderItem);
            object bakedBeans = new BakedBeans();
            Sides.Add(bakedBeans as IOrderItem);
            object cornDodgers = new CornDodgers();
            Sides.Add(cornDodgers as IOrderItem);
            return Sides;
        }

        /// <summary>
        /// Holds the menu
        /// </summary>
        /// <returns>The compelete Menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> Menu = new List<IOrderItem>();
            IEnumerable<IOrderItem> EntreeList = Entrees();
            foreach(IOrderItem entree in EntreeList)
            {
                Menu.Add(entree);
            }
            IEnumerable<IOrderItem> DrinkList = Drinks();
            foreach (IOrderItem drink in DrinkList)
            {
                Menu.Add(drink);
            }
            IEnumerable<IOrderItem> SideList = Sides();
            foreach (IOrderItem side in SideList)
            {
                Menu.Add(side);
            }
            return Menu;
        }
    }
}
