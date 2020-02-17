/*
 * Author: Samantha Rupnick
 * Class: CowboyCoffee.cs
 * Purpose: Holds the information of the Cowboy Coffee drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing information for the Cowboy Coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Whether or not the coffee should be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Whether or not the coffee should come with ice
        /// </summary>
        public new bool Ice { get; set; } = false;

        /// <summary>
        /// Whether or not the coffee should leave room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Returns the price of the coffee based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the calories of the coffee based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// A list of instructions on how to prepare the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }

                return instructions;
            }
        }

    }
}