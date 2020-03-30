/*
 * Author: Samantha Rupnick
 * Class: Trailburger.cs
 * Purpose: Holds the information of the Trailburger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The number of calories in the burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If ketchup should be on the burger
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If mustard should be on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If pickles should be on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If cheese should be on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool bun = true;
        /// <summary>
        /// If a bun should come with the burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        /// <summary>
        /// The special instructions for preparing the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) { instructions.Add("hold ketchup"); }
                if(!mustard) { instructions.Add("hold mustard"); }
                if(!pickle) { instructions.Add("hold pickle"); }
                if(!cheese) { instructions.Add("hold cheese"); }
                if(!bun) { instructions.Add("hold bun"); }

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default ToString method
        /// </summary>
        /// <returns> The item details </returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
