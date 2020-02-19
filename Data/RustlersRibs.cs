/*
 * Author: Samantha Rupnick
 * Class: RustlersRibs.cs
 * Purpose: Holds the information of the Ribs entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the ribs entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories in the ribs entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// The special instructions for how to make the ribs (there are no special instructions provided)
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
