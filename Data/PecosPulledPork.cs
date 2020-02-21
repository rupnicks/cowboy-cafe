/*
 * Author: Samantha Rupnick
 * Class: PecosPulledPork.cs
 * Purpose: Holds the information of the Pulled Pork entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing the information for the pulled pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }
        
        private bool bread = true;
        /// <summary>
        /// If the pulled pork should come with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }
        
        private bool pickle = true;
        /// <summary>
        /// If the pulled pork should come with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) { instructions.Add("hold bread"); }
                if (!pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
