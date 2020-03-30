/*
 * Author: Samantha Rupnick
 * Class: PanDeCampo.cs
 * Purpose: Holds the information of the Pan De Campo side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class holding information of the Pan De Campo Side
    /// </summary>
    public class PanDeCampo : Side
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
            return Size + " Pan de Campo";
        }
    }
}
