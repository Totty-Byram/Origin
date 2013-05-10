using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplexUniverse
{
    public class Rule
    {
        /// <summary>
        /// The property index a particle must possess in order for the rule to apply. Particles with null values at that index will be ignored. If AppliesTo is set to -1, then all particles will be affected.
        /// </summary>
        public int AppliesTo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
