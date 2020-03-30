/*Author: Samantha Rupnick
 * Class: TexasTriplePropertyChangedTests.cs
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
    public class TexasTriplePropertyChangedTests
    {
        //Test 1: Texas Triple implements the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTripleShouldImplementINotifyPropertyChanged()
        {
            var triple = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(triple);
        }

        //Test 2: Texas Triple invokes property changed for "Ketchup" when the property is changed
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForketchup()
        {
            var triple = new DakotaDoubleBurger();
            Assert.PropertyChanged(triple, "Ketchup", () => { triple.Ketchup = false; });
        }

        //Test 3: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Ketchup = false; });
        }

        //Test 4: Changing the Mustard property should invoke the PropertyChanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForMustard()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mustard", () => { triple.Mustard = false; });
        }

        //Test 5: Changing the Mustard property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Mustard = false; });
        }

        //Test 6: Texas Triple invokes property changed for "Pickle" when the property is changed
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForPickle()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Pickle", () => { triple.Pickle = false; });
        }

        //Test 7: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Pickle = false; });
        }

        //Test 8: Changing the Cheese property should invoke the PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForCheese()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Cheese", () => { triple.Cheese = false; });
        }

        //Test 9: Changing the Cheese property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Cheese = false; });
        }

        //Test 10: Texas Triple invokes property changed for "Bun" when the property is changed
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForBun()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bun", () => { triple.Bun = false; });
        }

        //Test 11: Changing the Bun property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Bun = false; });
        }

        //Test 12: Changing the Tomato property should invoke the PropertyChanged for Tomato
        [Fact]
        public void ChangingTomatoShouldInvokeINotifyPropertyChangedForTomato()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Tomato", () => { triple.Tomato = false; });
        }

        //Test 13: Changing the Tomato property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingTomatoShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Tomato = false; });
        }

        //Test 14: Texas Triple invokes property changed for "Lettuce" when the property is changed
        [Fact]
        public void ChangingLettuceShouldInvokeINotifyPropertyChangedForLettuce()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Lettuce", () => { triple.Lettuce = false; });
        }

        //Test 15: Changing the Lettuce property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingLettuceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Lettuce = false; });
        }

        //Test 16: Changing the Mayo property should invoke the PropertyChanged for Mayo
        [Fact]
        public void ChangingMayoShouldInvokeINotifyPropertyChangedForMayo()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Mayo", () => { triple.Mayo = false; });
        }

        //Test 17: Changing the Mayo property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingMayoShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Mayo = false; });
        }

        //Test 18: Texas Triple invokes property changed for "Bacon" when the property is changed
        [Fact]
        public void ChangingBaconeShouldInvokeINotifyPropertyChangedForBacon()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Bacon", () => { triple.Bacon = false; });
        }

        //Test 19: Changing the Bacon property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingBaconShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Bacon = false; });
        }

        //Test 20: Changing the Egg property should invoke the PropertyChanged for Egg
        [Fact]
        public void ChangingEggShouldInvokeINotifyPropertyChangedForEgg()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "Egg", () => { triple.Egg = false; });
        }

        //Test 21: Changing the Egg property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingEggShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var triple = new TexasTripleBurger();
            Assert.PropertyChanged(triple, "SpecialInstructions", () => { triple.Egg = false; });
        }
    }
}
