using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the ribs entree
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories in the ribs entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// The special instructions for how to make the ribs (there are no special instructions provided)
        /// </summary>
        public List SpecialInstructions {}
    }
}
