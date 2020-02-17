/*
 * Author: Samantha Rupnick
 * Class: Drink.cs
 * Purpose: Acts as a base class for the Drinks
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {

        /// <summary>
        /// Gets the size of the drink, defaulted to small
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets whether or not the drink has ice, defaulted to true
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Lists special instructions for how the drink should be prepared
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}