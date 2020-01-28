﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Texas Triple burger
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories in the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
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

        private bool bacon = true;
        /// <summary>
        /// If bacon should be on the burger
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;
        /// <summary>
        /// If egg should be on the burger
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
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
                if (!tomato) { instructions.Add("Hold tomato"); }
                if (!lettuce) { instructions.Add("Hold lettuce"); }
                if (!mayo) { instructions.Add("Hold mayo"); }
                if (!bacon) { instructions.Add("Hold bacon"); }
                if(!egg) { instructions.Add("Hold egg"); }
            }
        }
    }
}