/*Author: Samantha Rupnick
 * Class: TrailburgerPropertyChangedTests.cs
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
    public class TrailburgerPropertyChangedTests
    {
        //Test 1: TrailBurger implements the INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleShouldImplementINotifyPropertyChanged()
        {
            var burger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(burger);
        }

        //Test 2: Trailburger invokes property changed for "Ketchup" when the property is changed
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForketchup()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Ketchup", () => { burger.Ketchup = false; });
        }

        //Test 3: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => { burger.Ketchup = false; });
        }

        //Test 4: Changing the Mustard property should invoke the PropertyChanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForMustard()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Mustard", () => { burger.Mustard = false; });
        }

        //Test 5: Changing the Mustard property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => { burger.Mustard = false; });
        }

        //Test 6: Dakota Double invokes property changed for "Pickle" when the property is changed
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForPickle()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Pickle", () => { burger.Pickle = false; });
        }

        //Test 7: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => { burger.Pickle = false; });
        }

        //Test 8: Changing the Cheese property should invoke the PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForCheese()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Cheese", () => { burger.Cheese = false; });
        }

        //Test 9: Changing the Cheese property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => { burger.Cheese = false; });
        }

        //Test 10: Trailburger invokes property changed for "Bun" when the property is changed
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForBun()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "Bun", () => { burger.Bun = false; });
        }

        //Test 11: Changing the Bun property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var burger = new TrailBurger();
            Assert.PropertyChanged(burger, "SpecialInstructions", () => { burger.Bun = false; });
        }
    }
}
