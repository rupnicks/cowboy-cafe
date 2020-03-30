/*Author: Samantha Rupnick
 * Class: PecosPulledPorkPropertyChangedTests.cs
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
    public class PecosPulledPorkPropertyChangedTEsts
    {
        //Test 1: Pulled pork implements the INotifyPropertyChanged Interface
        [Fact]
        public void PulledPorkShouldImplementINotifyPropertyChanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }

        //Test 2: Pulled Pork invokes property changed for "Bread" when the property is changed
        [Fact]
        public void ChangingBreadShouldInvokeINotifyPropertyChangedForBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () => { pork.Bread = false; });
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
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () => { pork.Pickle = false; });
        }

        //Test 5: Changing the Pickle property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingPickleShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () => { pork.Pickle = false; });
        }
    }
}
