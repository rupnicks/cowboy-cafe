using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The information for the chicken sandwich entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// The price of the chicken sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories in the chicken sandwich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool bread = true;
        /// <summary>
        /// If the sandwich comes on bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the sandwich comes with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken sandwich
        /// </summary>
        public list SpecialInstructions
        {
            get
            {
                var instructions = new list();
                if (!bread) { instructions.Add("Hold bread"); }
                if (!pickle) { instructions.Add("Hold pickle"); }
            }
        }
    }
}
