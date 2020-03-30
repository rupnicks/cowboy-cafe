/*Author: Samantha Rupnick
 * Class: AngryChickenPropertyChangedTests.cs
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
    public class AngryChickenPropertyChangedTests
    {
        //Test 1: Angry Chicken implements the INotifyPropertyChanged Interface
        [Fact]
        public void AngryChickenShouldImplementINotifyPropertyChanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }

        //Test 2: Angry Chicken invokes property changed for "Bread" when the property is changed
        [Fact]
        public void ChangingBreadShouldInvokeINotifyPropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () => { chicken.Bread = false; });
        }

        //Test 3: Changing the Bread property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingBreadShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Bread = false; });
        }

        //Test 4: Changing the Pickle property should invoke the PropertyChanged for pickle
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () => { chicken.Pickle = false; });
        }

        //Test 5: Changing the Pickle property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () => { chicken.Pickle = false; });
        }
    }
}
