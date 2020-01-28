using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger
    {
        /// <summary>
        /// The price of the double burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories in the double burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
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

        private bool tomato = true;
        /// <summary>
        /// If tomatoes should be on the burger
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;
        /// <summary>
        /// If lettuce should be on the burger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;
        /// <summary>
        /// If mayo should be on the burger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// The special instructions for preparing the burger
        /// </summary>
        public list SpecialInstructions
        {
            get
            {
                var instructions = new list();
                if (!ketchup) { instructions.Add("Hold ketchup"); }
                if (!mustard) { instructions.Add("Hold mustard"); }
                if (!pickle) { instructions.Add("Hold pickle"); }
                if (!cheese) { instructions.Add("Hold cheese"); }
                if(!tomato) { instructions.Add("Hold tomato"); }
                if(!lettuce) { instructions.Add("Hold lettuce"); }
                if(!mayo) { instructions.Add("Hold mayo"); }
            }
        }
    }
}
