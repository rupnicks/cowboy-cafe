/*Author: Samantha Rupnick
 * Class: CowpokeChiliPropertyChangedTests.cs
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
    public class CowpokeChiliPropertyChangedTests
    {
        //Test 1: Cowpoke Chili implements the INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        //Test 2: Cowpoke Chili invokes property changed for "Cheese" when the property is changed
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () => { chili.Cheese = false; });
        }

        //Test 3: Changing the Cheese property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingCheeseShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.Cheese = false; });
        }

        //Test 4: Changing the SourCream property should invoke the PropertyChanged for SourCream
        [Fact]
        public void ChangingSourCreamShouldInvokeINotifyPropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () => { chili.SourCream = false; });
        }

        //Test 5: Changing the SourCream property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingSourCreamShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.SourCream = false; });
        }

        //Test 6: Cowpoke Chili invokes property changed for "Green Onions" when the property is changed
        [Fact]
        public void ChangingGreenOnionsShouldInvokeINotifyPropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () => { chili.GreenOnions = false; });
        }

        //Test 7: Changing the Cheese property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingGreenOnionsShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.GreenOnions = false; });
        }

        //Test 8: Changing the TortillaStrips property should invoke the PropertyChanged for TortillaStrips
        [Fact]
        public void ChanginTortillaStripsShouldInvokeINotifyPropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () => { chili.SourCream = false; });
        }

        //Test 9: Changing the TortillaStrips property should invoke the propertychanged for special instructions
        [Fact]
        public void ChangingTortillaStripsShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () => { chili.TortillaStrips = false; });
        }
    }
}
