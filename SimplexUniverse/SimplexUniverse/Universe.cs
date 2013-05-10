using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimplexUniverse
{
    public class Universe
    {
        /// <summary>
        /// Event raised after the creation of this universe (at first tick).
        /// </summary>
        public event EventHandler Created;

        /// <summary>
        /// Event raised during the destruction of this universe.
        /// </summary>
        public event EventHandler Destroyed;

        /// <summary>
        /// The number of axes available for particle to travel.
        /// </summary>
        public int NumberDimensions
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// A list of sizes for each dimension. This value will be extended in both directions from the origion.
        /// </summary>
        public List<int> Size
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// A list of all of the particles contained in this universe.
        /// </summary>
        public List<Particle> Particles
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        /// <summary>
        /// A list of all of the rules contained in this universe.
        /// </summary>
        public List<Rule> Rules
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
