using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Trailburger entree
    /// </summary>
    public class TrailBurger
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The number of calories in the burger
        /// </summary>
        public uint Calories
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
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If mustard should be on the burger
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If pickles should be on the burger
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// If cheese should be on the burger
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool bun = true;
        /// <summary>
        /// If a bun should come with the burger
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// The special instructions for preparing the burger
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
