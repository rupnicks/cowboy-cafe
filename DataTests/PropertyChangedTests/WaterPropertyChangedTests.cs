/*Author: Samantha Rupnick
 * Class: WaterPropertyChangedTests.cs
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
    public class WaterPropertyChangedTests
    {
        //Test 1: Water implements the INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }

        //Test 2: Water invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Size", () => { water.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => { water.Size = Size.Large; });
        }

        //Test 4: Water invokes property changed for "Ice" when the property is changed
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () => { water.Ice = false; });
        }

        //Test 5: Changing the Ice property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => { water.Ice = false; });
        }

        //Test 6: Water invokes property changed for "Lemon" when the property is changed
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () => { water.Lemon = true; });
        }

        //Test 7: Changing the Lemon property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () => { water.Lemon = true; });
        }
    }
}
