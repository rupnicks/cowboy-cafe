using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests.MenuTests
{
    public class MenuTests
    {
        //Test Group 1: Entrees Contains one instance of the menu item
        [Fact]
        public void EntreesContainsChicken()
        {
            IOrderItem chicken = new AngryChicken();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(chicken, entreeList);
        }

        [Fact]
        public void EntreesContainsChili()
        {
            IOrderItem chili = new CowpokeChili();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(chili, entreeList);
        }

        [Fact]
        public void EntreesContainsDakotaDoubleBurger()
        {
            IOrderItem dakotaDouble = new DakotaDoubleBurger();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(dakotaDouble, entreeList);
        }

        [Fact]
        public void EntreesContainsPulledPork()
        {
            IOrderItem pork = new PecosPulledPork();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(pork, entreeList);
        }

        [Fact]
        public void EntreesContainsRibs()
        {
            IOrderItem ribs = new RustlersRibs();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(ribs, entreeList);
        }

        [Fact]
        public void EntreesContainsTexasTripleBurger()
        {
            IOrderItem texasTriple = new TexasTripleBurger();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(texasTriple, entreeList);
        }

        [Fact]
        public void EntreesContainsTrailBurger()
        {
            IOrderItem trailBurger = new TrailBurger();
            IEnumerable<IOrderItem> entreeList = Menu.Entrees();
            Assert.Contains(trailBurger, entreeList);
        }

        //Test Group 2: Drinks contains one instance of the menu item

        [Fact]
        public void DrinksContainsCoffee()
        {
            IOrderItem coffee = new CowboyCoffee();
            IEnumerable<IOrderItem> drinkList = Menu.Drinks();
            Assert.Contains(coffee, drinkList);
        }

        [Fact]
        public void DrinksContainsSoda()
        {
            IOrderItem soda = new JerkedSoda();
            IEnumerable<IOrderItem> drinkList = Menu.Drinks();
            Assert.Contains(soda, drinkList);
        }

        [Fact]
        public void DrinksContainsTea()
        {
            IOrderItem tea = new TexasTea();
            IEnumerable<IOrderItem> drinkList = Menu.Drinks();
            Assert.Contains(tea, drinkList);
        }

        [Fact]
        public void DrinksContainsWater()
        {
            IOrderItem water = new Water();
            IEnumerable<IOrderItem> drinkList = Menu.Drinks();
            Assert.Contains(water, drinkList);
        }

        //Test Group 3: Sides contains one instance of the menu item

        [Fact]
        public void SidesContainsBakedBeans()
        {
            IOrderItem beans = new BakedBeans();
            IEnumerable<IOrderItem> sidesList = Menu.Sides();
            Assert.Contains(beans, sidesList);
        }

        [Fact]
        public void SidesContainsChiliCheeseFries()
        {
            IOrderItem fries = new ChiliCheeseFries();
            IEnumerable<IOrderItem> sidesList = Menu.Sides();
            Assert.Contains(fries, sidesList);
        }

        [Fact]
        public void SidesContainsCornDodgers()
        {
            IOrderItem corn = new CornDodgers();
            IEnumerable<IOrderItem> sidesList = Menu.Sides();
            Assert.Contains(corn, sidesList);
        }

        [Fact]
        public void SidesContainsPanDeCampo()
        {
            IOrderItem pan = new PanDeCampo();
            IEnumerable<IOrderItem> sidesList = Menu.Sides();
            Assert.Contains(pan, sidesList);
        }

        //Test Group 4: All contains one instance of every menu item
        [Fact]
        public void AllContainsChicken()
        {
            IOrderItem chicken = new AngryChicken();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(chicken, menuList);
        }

        [Fact]
        public void AllContainsChili()
        {
            IOrderItem chili = new CowpokeChili();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(chili, menuList);
        }

        [Fact]
        public void AllContainsDakotaDoubleBurger()
        {
            IOrderItem dakotaDouble = new DakotaDoubleBurger();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(dakotaDouble, menuList);
        }

        [Fact]
        public void AllContainsPulledPork()
        {
            IOrderItem pork = new PecosPulledPork();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(pork, menuList);
        }

        [Fact]
        public void AllContainsRibs()
        {
            IOrderItem ribs = new RustlersRibs();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(ribs, menuList);
        }

        [Fact]
        public void AllContainsTexasTripleBurger()
        {
            IOrderItem texasTriple = new TexasTripleBurger();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(texasTriple, menuList);
        }

        [Fact]
        public void AllContainsTrailBurger()
        {
            IOrderItem trailBurger = new TrailBurger();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(trailBurger, menuList);
        }

        [Fact]
        public void AllContainsCoffee()
        {
            IOrderItem coffee = new CowboyCoffee();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(coffee, menuList);
        }

        [Fact]
        public void AllContainsSoda()
        {
            IOrderItem soda = new JerkedSoda();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(soda, menuList);
        }

        [Fact]
        public void AllContainsTea()
        {
            IOrderItem tea = new TexasTea();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(tea, menuList);
        }

        [Fact]
        public void AllContainsWater()
        {
            IOrderItem water = new Water();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(water, menuList);
        }

        [Fact]
        public void AllContainsBakedBeans()
        {
            IOrderItem beans = new BakedBeans();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(beans, menuList);
        }

        [Fact]
        public void AllContainsChiliCheeseFries()
        {
            IOrderItem fries = new ChiliCheeseFries();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(fries, menuList);
        }

        [Fact]
        public void AllContainsCornDodgers()
        {
            IOrderItem corn = new CornDodgers();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(corn, menuList);
        }

        [Fact]
        public void AllContainsPanDeCampo()
        {
            IOrderItem pan = new PanDeCampo();
            IEnumerable<IOrderItem> menuList = Menu.All();
            Assert.Contains(pan, menuList);
        }

        //Test 5: Searching for a valid item holds true

        //Test 6: Searching for an invalid item returns false

        //Test 7: Searching for a null item returns All
        [Fact]
        public void SearchingForANullItemReturnsAll()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> results = Menu.Search("");
            Assert.Equal(all, results);
        }

        //Test 8: Filtering by Calories returns calories within the given range

        //Test 9: Filtering by a null value for calories returns all
        [Fact]
        public void FilteringByANullCalorieCountReturnsAll()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(all, null, null);
            Assert.Equal(all, results);
        }

        //Test 10: Filtering by price returns prices within the given range

        //Test 11: Filtering by a null price returns all
        [Fact]
        public void FilteringByANullPriceRangeReturnsAll()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(all, null, null);
            Assert.Equal(all, results);
        }

        //Test 12: Filtering by item type returns only the item types

        //Test 13: Filtering by no item types returns all
        [Fact]
        public void FilteringByNoItemTypesReturnsAll()
        {
            IEnumerable<IOrderItem> all = Menu.All();
            IEnumerable<IOrderItem> results = Menu.FilterByItemType(all, null);
            Assert.Equal(all, results);
        }
    }
}
