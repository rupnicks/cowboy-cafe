/*
 * Author: Samantha Rupnick
 * Class: Water.cs
 * Purpose: Holds the information of the Water drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing information for the Water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Whether or not the water should be served with Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Returns the price of the water
        /// </summary>
        public override double Price
        {
            get { return 0.12; }
        }

        /// <summary>
        /// Returns the calories of the water
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// A list of instructions on how to prepare the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }
                if (Lemon) { instructions.Add("Add Lemon"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return Size + " Water";
        }
    }
}