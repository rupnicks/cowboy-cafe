﻿/*
 * Author: Samantha Rupnick
 * Class: TexasTea.cs
 * Purpose: Holds the information of the Texas Tea drink
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing information for the Texas Tea
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Whether or not the tea should be sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Whether or not the tea should be served with Lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Returns the price of the tea based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the calories of the tea based on size and if it is sweet
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 13;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// A list of instructions on how to prepare the tea
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
            switch (Size)
            {
                case (Size.Small):
                    if (!Sweet)
                    {
                        return "Small Texas Tea";
                    }
                    return "Small Sweet Texas Tea";
                case (Size.Medium):
                    if (!Sweet)
                    {
                        return "Medium Texas Tea";
                    }
                    return "Medium Sweet Texas Tea";
                case (Size.Large):
                    if (!Sweet)
                    {
                        return "Large Texas Tea";
                    }
                    return "Large Sweet Texas Tea";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}