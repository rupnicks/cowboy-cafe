/*Author: Samantha Rupnick
 * Class: TexasTeaPropertyChangedTests.cs
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
    public class TexasTeaPropertyChangedTests
    {
        //Test 1: Texas Tea implements the INotifyPropertyChanged Interface
        [Fact]
        public void TexasTeaShouldImplementINotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }

        //Test 2: Texas Tea invokes property changed for "Size" when the property is changed
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSize()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Size", () => { tea.Size = Size.Large; });
        }

        //Test 3: Changing the Size property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Size = Size.Large; });
        }

        //Test 4: Changing the Size property should invoke the PropertyChanged for Calories
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForCalories()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Calories", () => { tea.Size = Size.Large; });
        }

        //Test 5: Changing the Size property should invoke the propertychanged for Price
        [Fact]
        public void ChangingSizeShouldInvokeINotifyPropertyChangedForPrice()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Price", () => { tea.Size = Size.Large; });
        }

        //Test 6: Texas Tea invokes property changed for "Sweet" when the property is changed
        [Fact]
        public void ChangingSweetShouldInvokeINotifyPropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () => { tea.Sweet = false; });
        }

        //Test 7: Changing the Sweet property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingSweetShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Sweet = false; });
        }

        //Test 8: Texas Tea invokes property changed for "Ice" when the property is changed
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () => { tea.Ice = false; });
        }

        //Test 9: Changing the Ice property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingIceShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Ice = false; });
        }

        //Test 10: Texas Tea invokes property changed for "Lemon" when the property is changed
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () => { tea.Lemon = true; });
        }

        //Test 11: Changing the Lemon property should update the SpecialInstructions and invoke INotifyPropertyChanged
        [Fact]
        public void ChangingLemonShouldInvokeINotifyPropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () => { tea.Lemon = true; });
        }
    }
}
