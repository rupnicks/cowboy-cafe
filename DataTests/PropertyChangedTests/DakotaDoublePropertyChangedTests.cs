/*Author: Samantha Rupnick
 * Class: DakotaDoublePropertyChangedTests.cs
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
    public class DakotaDoublePropertyChangedTests
    {
        //Test 1: Dakota Double implements the INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);
        }

        //Test 2: Dakota Double invokes property changed for "Ketchup" when the property is changed
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForketchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () => { dakota.Ketchup = false; });
        }

        //Test 3: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingKetchupShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Ketchup = false; });
        }

        //Test 4: Changing the Mustard property should invoke the PropertyChanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () => { dakota.Mustard = false; });
        }

        //Test 5: Changing the Mustard property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingMustardShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Mustard = false; });
        }

        //Test 6: Dakota Double invokes property changed for "Pickle" when the property is changed
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () => { dakota.Pickle = false; });
        }

        //Test 7: Changing the Ketchup property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Pickle = false; });
        }

        //Test 8: Changing the Cheese property should invoke the PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () => { dakota.Cheese = false; });
        }

        //Test 9: Changing the Cheese property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Cheese = false; });
        }

        //Test 10: Dakota Double invokes property changed for "Bun" when the property is changed
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () => { dakota.Bun = false; });
        }

        //Test 11: Changing the Bun property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingBunShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Bun = false; });
        }

        //Test 12: Changing the Tomato property should invoke the PropertyChanged for Tomato
        [Fact]
        public void ChangingTomatoShouldInvokeINotifyPropertyChangedForTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () => { dakota.Tomato = false; });
        }

        //Test 13: Changing the Tomato property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingTomatoShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Tomato = false; });
        }

        //Test 14: Dakota Double invokes property changed for "Lettuce" when the property is changed
        [Fact]
        public void ChangingLettuceShouldInvokeINotifyPropertyChangedForLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () => { dakota.Lettuce = false; });
        }

        //Test 15: Changing the Lettuce property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingLettuceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Lettuce = false; });
        }

        //Test 16: Changing the Mayo property should invoke the PropertyChanged for Mayo
        [Fact]
        public void ChangingMayoShouldInvokeINotifyPropertyChangedForMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () => { dakota.Mayo = false; });
        }

        //Test 17: Changing the Mayo property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingMayoShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () => { dakota.Mayo = false; });
        }
    }
}
