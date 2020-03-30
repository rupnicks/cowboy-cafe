/*Author: Samantha Rupnick
 * Class: ChiliCheeseFriesPropertyChangedTests.cs
 * Purpose: Tests the property changed invocations of the item
 */

using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.ComponentModel;
using Xunit;
namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTests
    {
        //Test 1: Chili Cheese Fries implements the INotifyPropertyChanged Interface
        [Fact]
        public void ChiliCheeseFriesShouldImplementINotifyPropertyChanged()
        {
            var fries = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(fries);
        }

        //Test 2: Chili Cheese Fries invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () => { fries.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "SpecialInstructions", () => { fries.Size = Size.Large; });
        }

        //Test 4: Changing the Size property should invoke the PropertyChanged for Calories
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () => { fries.Size = Size.Large; });
        }

        //Test 5: Changing the Size property should invoke the propertychanged for Price
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () => { fries.Size = Size.Large; });
        }
    }
}
