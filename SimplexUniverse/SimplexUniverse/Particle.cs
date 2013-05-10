using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplexUniverse
{
    public class Particle
    {
        /// <summary>
        /// Event raised when this particle is first created (first tick after being placed on the grid).
        /// </summary>
        public event EventHandler Created;

        /// <summary>
        /// Event raised when this particle is removed from the grid.
        /// </summary>
        public event EventHandler Destroyed;

        /// <summary>
        /// Event raised when this particle occupies the same space as another particle.
        /// </summary>
        public event EventHandler Collision;

        /// <summary>
        /// Event raised after every time the position of this particle is changed.
        /// </summary>
        public event EventHandler Moved;

        /// <summary>
        /// Event raised after the value of a property changes.
        /// </summary>
        public event EventHandler PropertyChanged;

        
        //Private Values
        private int aID;
        private List<double?> aAcceleration;
        private List<double?> aPosition;
        private List<double?> aVelocity;
        private List<double?> aProperties;
        
        
        public Particle(int ID, int NDimensions, int NProperties)
        {
            this.ID = ID;
            this.Acceleration = new List<double?>(NDimensions);
            this.Position = new List<double?>(NDimensions);
            this.Velocity = new List<double?>(NDimensions);
            this.Properties = new List<double?>(NProperties);

            int i;
            for (i = 0; i < NDimensions; i++)
            {
                Position.Add(null);
                Velocity.Add(null);
                Acceleration.Add(null);
            }

            for (i = 0; i < NProperties; i++)
            {
                Properties.Add(null);
            }

        }

        /// <summary>
        /// The unique ID associated with the particle.
        /// </summary>
        public int ID
        {
            get
            {
                return aID;
            }
            set
            {
                aID = value;
            }
        }

        /// <summary>
        /// The list of properties available to this particle. Null values representing an absense of that particular property.
        /// </summary>
        public List<double?> Properties
        {
            get
            {
                return aProperties;
            }
            set
            {
                aProperties = value;
            }
        }

        /// <summary>
        /// The list of coodinates in each axis. Null values indicate that the particle doesn't exist on that particular axis.
        /// </summary>
        public List<double?> Position
        {
            get
            {
                return aPosition;
            }
            set
            {
                aPosition = value;
            }
        }

        /// <summary>
        /// A list of accelerations in each axis.
        /// </summary>
        public List<double?> Acceleration
        {
            get
            {
                return aAcceleration;
            }
            set
            {
                aAcceleration = value;
            }
        }

        /// <summary>
        /// The list of velocities in each axis direction.
        /// </summary>
        public List<double?> Velocity
        {
            get
            {
                return aVelocity;
            }
            set
            {
                aVelocity = value;
            }
        }

        /// <summary>
        /// Returns a string containing the information stored in this particle.
        /// </summary>
        /// <returns>A string containing a summary of this particle's properties.</returns>
        public string ParticleToString()
        {
            string output = "";

            output += "Particle ID =              " + this.ID.ToString() + Environment.NewLine;
            output += "Properties Fullness =      " + this.Properties.Count.ToString() + " / " + this.Properties.Capacity.ToString() + Environment.NewLine;
            output += "Position Fullness =        " + this.Position.Count.ToString() + " / " + this.Position.Capacity.ToString() + Environment.NewLine;
            output += "Velocity Fullness =        " + this.Velocity.Count.ToString() + " / " + this.Velocity.Capacity.ToString() + Environment.NewLine;
            output += "Acceleration Fullness =    " + this.Acceleration.Count.ToString() + " / " + this.Acceleration.Capacity.ToString() + Environment.NewLine;
            output += Environment.NewLine;

            output += "Properties:" + Environment.NewLine;
            foreach (double? x in Properties)
            {
                if (x == null)
                {
                    output += "NULL\t";
                }
                else
                {
                    output += x.ToString() + "\t";
                }
            }
            output += Environment.NewLine;
            output += Environment.NewLine;
            output += "Position:" + Environment.NewLine;
            foreach (double? x in Position)
            {
                if (x == null)
                {
                    output += "NULL\t";
                }
                else
                {
                    output += x.ToString() + "\t";
                }
            }
            output += Environment.NewLine;
            output += Environment.NewLine;
            output += "Velocity:" + Environment.NewLine;
            foreach (double? x in Velocity)
            {
                if (x == null)
                {
                    output += "NULL\t";
                }
                else
                {
                    output += x.ToString() + "\t";
                }
            }
            output += Environment.NewLine;
            output += Environment.NewLine;
            output += "Acceleration:" + Environment.NewLine;
            foreach (double? x in Acceleration)
            {
                if (x == null)
                {
                    output += "NULL\t";
                }
                else
                {
                    output += x.ToString() + "\t";
                }
            }
            output += Environment.NewLine;

            return output;
        }

        /// <summary>
        /// Initializes the Position, Velocity, and Acceleration of a particle to zero rather than null.
        /// </summary>
        public void InitializeToZero()
        {
            int i;
            for (i = 0; i < this.Position.Capacity; i++)
            {
                this.Position[i] = 0;
            }
            for (i = 0; i < this.Velocity.Capacity; i++)
            {
                this.Velocity[i] = 0;
            }
            for (i = 0; i < this.Acceleration.Capacity; i++)
            {
                this.Acceleration[i] = 0;
            }
        }
    }
}
