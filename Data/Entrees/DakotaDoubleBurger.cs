/*
 * Author: Samantha Rupnick
 * Class: DakotaDouble.cs
 * Purpose: Holds the information of the Dakota Double entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// The price of the double burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories in the double burger
        /// </summary>
        public override uint Calories
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
                if(!lettuce) { instructions.Add("hold lettuce"); }
                if(!mayo) { instructions.Add("hold mayo"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
