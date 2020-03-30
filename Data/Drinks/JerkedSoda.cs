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
        private bool ice = true;
        /// <summary>
        /// Whether or not the soda should be served with ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

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

        /// <summary>
        /// Overrides the default ToString method for the class
        /// </summary>
        /// <returns> The information of the drink to be printed </returns>
        public override string ToString()
        {
            switch(Flavor)
            {
                case (SodaFlavor.BirchBeer):
                    return Size + " Birch Beer Jerked Soda";
                case (SodaFlavor.CreamSoda):
                    return Size + " Cream Soda Jerked Soda";
                case (SodaFlavor.OrangeSoda):
                    return Size + " Orange Soda Jerked Soda";
                case (SodaFlavor.RootBeer):
                    return Size + " Root Beer Jerked Soda";
                default:
                    return Size + " Sarsparilla Jerked Soda";
            }
        }
    }
}