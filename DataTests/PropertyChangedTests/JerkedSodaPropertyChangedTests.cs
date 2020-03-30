/*Author: Samantha Rupnick
 * Class: JerkedSodaPropertyChangedTests.cs
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
    public class JerkedSodaPropertyChangedTests
    {
        //Test 1: Jerked Soda implements the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        //Test 2: Jerked Soda invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () => { soda.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Size = Size.Large; });
        }

        //Test 4: Changing the Size property should invoke the PropertyChanged for Calories
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Calories", () => { soda.Size = Size.Large; });
        }

        //Test 5: Changing the Size property should invoke the propertychanged for Price
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Price", () => { soda.Size = Size.Large; });
        }

        //Test 6: Jerked Soda invokes property changed for "Flavor" when the property is changed
        [Fact]
        public void ChangingFlavorShouldInvokeINotifyPropertyChangedForFlavor()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Decaf", () => { soda.Flavor = SodaFlavor.RootBeer; });
        }

        //Test 7: Changing the Flavor property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingFlavorShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Flavor = SodaFlavor.RootBeer; });
        }

        //Test 8: Jerked Soda invokes property changed for "Ice" when the property is changed
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () => { soda.Ice = false; });
        }

        //Test 9: Changing the Ice property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () => { soda.Ice = false; });
        }
    }
}
