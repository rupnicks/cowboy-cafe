/*
 * Author: Samantha Rupnick
 * Class: JerkedSoda.cs
 * Purpose: Holds the information of the Jerked Soda drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing information for the Jerked Soda
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// What flavor the soda should be
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Returns the price of the soda based on the size
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the calories of the soda based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// A list of instructions on how to prepare the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) { instructions.Add("Hold Ice"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return Size + " " + Flavor + " Jerked Soda";
        }
    }
}