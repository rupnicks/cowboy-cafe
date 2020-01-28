using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Trailburger entree
    /// </summary>
    public class Trailburger
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

        /// <summary>
        /// The special instructions for preparing the burger
        /// </summary>
        public list SpecialInstructions
        {
            get
            {
                var instructions = new list();
                if(!ketchup) { instructions.Add("Hold ketchup"); }
                if(!mustard) { instructions.Add("Hold mustard"); }
                if(!pickle) { instructions.Add("Hold pickle"); }
                if(!cheese) { instructions.Add("Hold cheese"); }
            }
        }
    }
}
