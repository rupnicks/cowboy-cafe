﻿/*
 * Author: Samantha Rupnick
 * Class: TexasTripleBurger.cs
 * Purpose: Holds the information of the Texas Triple Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Texas Triple burger
    /// </summary>
    public class TexasTripleBurger : Entree
    {
        /// <summary>
        /// The price of the burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories in the burger
        /// </summary>
        public override uint Calories
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

        private bool tomato = true;
        /// <summary>
        /// If tomatoes should be on the burger
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If lettuce should be on the burger
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If mayo should be on the burger
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool bacon = true;
        /// <summary>
        /// If bacon should be on the burger
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyOfPropertyChange("Bacon");
                NotifyOfPropertyChange("SpecialInstructions");
            }
        }

        private bool egg = true;
        /// <summary>
        /// If egg should be on the burger
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyOfPropertyChange("Egg");
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
                if (!mustard) { instructions.Add("hold mustard"); }
                if (!pickle) { instructions.Add("hold pickle"); }
                if (!cheese) { instructions.Add("hold cheese"); }
                if (!bun) { instructions.Add("hold bun"); }
                if (!tomato) { instructions.Add("hold tomato"); }
                if (!lettuce) { instructions.Add("hold lettuce"); }
                if (!mayo) { instructions.Add("hold mayo"); }
                if (!bacon) { instructions.Add("hold bacon"); }
                if(!egg) { instructions.Add("hold egg"); }

                return instructions;
            }
        }

        /// <summary>
        /// Overrides the default ToString method
        /// </summary>
        /// <returns> The item details </returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
