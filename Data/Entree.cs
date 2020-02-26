﻿/*
 * Author: Samantha Rupnick
 * Class: Entree.cs
 * Purpose: Acts as a base class for the entrees
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the list of special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
