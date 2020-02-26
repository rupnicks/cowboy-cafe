/* Author: Samantha Rupnick
 * Class: OrderTests.cs
 * Purpose: Contains tests for the Order class
 */
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.UnitTests
{
    /// <summary>
    /// Holds a mock item to be used in the test cases
    /// </summary>
    class MockOrderItem : IOrderItem
    {
        /// <summary>
        /// Price of the mock item
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Special instructions for the mock item
        /// </summary>
        public List<string> SpecialInstructions { get; set; }
    }

    /// <summary>
    /// A class containing tests for the Order class
    /// </summary>
    public class OrderTests
    {
        /// <summary>
        /// Adding something to the order should have it appear in the Items property
        /// </summary>
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        /// <summary>
        /// Removing something from the order should remove it from the Items property
        /// </summary>
        [Fact]
        public void RemovedIOrderItemsNoLongerAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        /// <summary>
        /// Get the price - needs to be right (for the items added)
        /// </summary>
        /// <param name="prices">A list of prices of items to add</param>
        [Theory]
        [InlineData(new double[] { })]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        public void SubtotalShouldBeSumOfOrderItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }
            Assert.Equal(total, order.Subtotal);
        }

        /// <summary>
        /// Order cannot contain more items than what was added to the order
        /// </summary>
        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() { Price = 3 },
                new MockOrderItem() { Price = 4 },
                new MockOrderItem() { Price = 7 }
            };

            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }
    }
}
