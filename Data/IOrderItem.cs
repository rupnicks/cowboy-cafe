/* Author: Samantha Rupnick
 * Class: IOrderItem.cs
 * Purpose: To access data for a single order item
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price for this IOrderItem
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for this IOrderItem
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
