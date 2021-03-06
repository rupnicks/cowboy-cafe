﻿/*
 * Author: Samantha Rupnick
 * Class: ChiliCheeseFries.cs
 * Purpose: Holds the information of the Chili Cheese Fries side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class holding information of the Chili Cheese Fries Side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The calories in the different sizes of Chili Cheese Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the different sizes of Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The special instructions for preparing the item
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default ToString method
        /// </summary>
        /// <returns> The item details </returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }
    }
}
