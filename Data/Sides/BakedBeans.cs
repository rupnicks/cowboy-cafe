﻿/*
 * Author: Samantha Rupnick
 * Class: BakedBeans.cs
 * Purpose: Holds the information of the Baked Beans side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class holding information of the Baked Beans Side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// The calories in the different sizes of Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the different sizes of Baked Beans
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
            return Size + " Baked Beans";
        }
    }
}
