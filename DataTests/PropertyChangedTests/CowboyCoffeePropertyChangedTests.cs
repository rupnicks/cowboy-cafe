/*Author: Samantha Rupnick
 * Class: CowboyCoffeePropertyChangedTests.cs
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
    public class CowboyCoffeePropertyChangedTests
    {
        //Test 1: Cowboy Coffee implements the INotifyPropertyChanged Interface
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }

        //Test 2: Cowboy Coffee invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Size", () => { coffee.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => { coffee.Size = Size.Large; });
        }

        //Test 4: Changing the Size property should invoke the PropertyChanged for Calories
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Calories", () => { coffee.Size = Size.Large; });
        }

        //Test 5: Changing the Size property should invoke the propertychanged for Price
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Price", () => { coffee.Size = Size.Large; });
        }

        //Test 6: Cowboy Coffee invokes property changed for "Decaf" when the property is changed
        [Fact]
        public void ChangingDecafShouldInvokeINotifyPropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () => { coffee.Decaf = true; });
        }

        //Test 7: Changing the Decaf property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingDecafShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => { coffee.Decaf = true; });
        }

        //Test 8: Cowboy Coffee invokes property changed for "Ice" when the property is changed
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () => { coffee.Ice = true; });
        }

        //Test 9: Changing the Ice property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => { coffee.Ice = true; });
        }

        //Test 10: Cowboy Coffee invokes property changed for "RoomForCream" when the property is changed
        [Fact]
        public void ChangingRoomForCreamShouldInvokeINotifyPropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () => { coffee.RoomForCream = true; });
        }

        //Test 11: Changing the RoomForCream property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingRoomForCreamShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () => { coffee.RoomForCream = true; });
        }
    }
}
