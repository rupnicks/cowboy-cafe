﻿/*
 * Author: Samantha Rupnick
 * Class: CornDodgers.cs
 * Purpose: Holds the information of the Corn Dodgers side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class holding information of the Corn Dodgers Side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The calories in the different sizes of Corn Dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of the different sizes of Corn Dodgers
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
            return Size + " Corn Dodgers";
        }
    }
}
