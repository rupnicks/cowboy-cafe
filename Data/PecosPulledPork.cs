using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class containing the information for the pulled pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// The price of the pulled pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork
        /// </summary>
        public uint Calories
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
        public list SpecialInstructions
        {
            get
            {
                var instructions = new list();
                if(!bread) { instructions.Add("Hold bread"); }
                if (!pickle) { instructions.Add("Hold pickle"); }
            }
        }
    }
}
