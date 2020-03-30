/*Author: Samantha Rupnick
 * Class: PanDeCampoPropertyChangedTests.cs
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
    public class PanDeCampoPropertyChangedTests
    {
        //Test 1: Pan De Campo implements the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var pan = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pan);
        }

        //Test 2: Baked Beans invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Size", () => { pan.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "SpecialInstructions", () => { pan.Size = Size.Large; });
        }

        //Test 4: Changing the Size property should invoke the PropertyChanged for Calories
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Calories", () => { pan.Size = Size.Large; });
        }

        //Test 5: Changing the Size property should invoke the propertychanged for Price
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice()
        {
            var pan = new PanDeCampo();
            Assert.PropertyChanged(pan, "Price", () => { pan.Size = Size.Large; });
        }
    }
}
