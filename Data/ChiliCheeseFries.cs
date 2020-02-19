/*
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

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Large:
                    return "Large Chili Cheese Fries";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
