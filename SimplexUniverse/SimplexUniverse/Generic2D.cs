using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplexUniverse
{
    /// <summary>
    /// Contains functions dealing with the creation of a basic 2-rule 2D universe.
    /// </summary>
    public class Generic2D
    {
        /// <summary>
        /// Creates a new particle modeled after a proton.
        /// </summary>
        /// <returns>A proton.</returns>
        public static Particle CreateProton(int ID, List<double?> Position)
        {
            Particle ReturnParticle = new Particle(ID, 2, 2);

            ReturnParticle.Position[0] = Position[0];
            ReturnParticle.Position[1] = Position[1];
            ReturnParticle.Properties[0] = 1.673e-27;
            ReturnParticle.Properties[1] = 1.602e-19;
            ReturnParticle.Acceleration[0] = 0;
            ReturnParticle.Acceleration[1] = 0;
            ReturnParticle.Velocity[0] = 0;
            ReturnParticle.Velocity[1] = 0;

            return ReturnParticle;
        }

        /// <summary>
        /// Creates a new particle modeled after a neutron.
        /// </summary>
        /// <returns>A neutron.</returns>
        public static Particle CreateNeutron(int ID, List<double?> Position)
        {
            Particle ReturnParticle = new Particle(ID, 2, 2);

            ReturnParticle.Position[0] = Position[0];
            ReturnParticle.Position[1] = Position[1];
            ReturnParticle.Properties[0] = 1.675e-27;
            ReturnParticle.Properties[1] = null;
            ReturnParticle.Acceleration[0] = 0;
            ReturnParticle.Acceleration[1] = 0;
            ReturnParticle.Velocity[0] = 0;
            ReturnParticle.Velocity[1] = 0;

            return ReturnParticle;
        }

        /// <summary>
        /// Creates a new particle modeled after an electron.
        /// </summary>
        /// <returns>An electron.</returns>
        public static Particle CreateElectron(int ID, List<double?> Position)
        {
            Particle ReturnParticle = new Particle(ID, 2, 2);

            ReturnParticle.Position[0] = Position[0];
            ReturnParticle.Position[1] = Position[1];
            ReturnParticle.Properties[0] = 9.109e-28;
            ReturnParticle.Properties[1] = -1.602e-19;
            ReturnParticle.Acceleration[0] = 0;
            ReturnParticle.Acceleration[1] = 0;
            ReturnParticle.Velocity[0] = 0;
            ReturnParticle.Velocity[1] = 0;

            return ReturnParticle;
        }

        /// <summary>
        /// Creates the rule pretaining to basic gravitational interaction.
        /// </summary>
        /// <returns>Gravity</returns>
        public static Rule CreateGravity()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates the rule pretaining to basic electromagnetic interaction.
        /// </summary>
        /// <returns>Electromagnetism.</returns>
        public static Rule CreateElectromagnetism()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a simple particle immune to electromagnetism and with a mass of 1.
        /// </summary>
        /// <returns>A simple particle.</returns>
        public static Particle CreateSimpleMassParticle(int ID, List<double?> Position)
        {
            Particle ReturnParticle = new Particle(ID, 2, 2);

            ReturnParticle.Position[0] = Position[0];
            ReturnParticle.Position[1] = Position[1];
            ReturnParticle.Properties[0] = 1;
            ReturnParticle.Properties[1] = null;
            ReturnParticle.Acceleration[0] = 0;
            ReturnParticle.Acceleration[1] = 0;
            ReturnParticle.Velocity[0] = 0;
            ReturnParticle.Velocity[1] = 0;

            return ReturnParticle;
        }

        /// <summary>
        /// Creates a simple particle immune to gravity and with a charge of +1.
        /// </summary>
        /// <returns>A simple particle.</returns>
        public static Particle CreateSimplePChargeParticle()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a simple particle immune to gravity and with a charge of -1.
        /// </summary>
        /// <returns>A simple particle.</returns>
        public static Particle CreateSimpleNChargeParticle()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates a basic set of 2D grid sizes given a basic radial size. EX: 50 will create a 100 x 100 grid.
        /// </summary>
        /// <returns>A list of sizes.</returns>
        public static List<int> CreateBasicSizeList(int BaseSize)
        {
            List<int> returnlist = new List<int>(2);

            returnlist.Add(BaseSize);
            returnlist.Add(BaseSize);

            return returnlist;
        }

        /// <summary>
        /// Outputs useful debug information about a Generic 2D particle as a string.
        /// </summary>
        /// <returns>A string containing information about a 2D particle.</returns>
        public static string ParticleToString(Particle InputParticle)
        {
            string output = "";
            output += "Particle ID =                   " + InputParticle.ID.ToString() + Environment.NewLine;
            output += "Properties Capacity =           " + InputParticle.Properties.Capacity.ToString() + Environment.NewLine;
            output += "Position Capacity =             " + InputParticle.Position.Capacity.ToString() + Environment.NewLine;
            output += "Velocity Capacity =             " + InputParticle.Velocity.Capacity.ToString() + Environment.NewLine;
            output += "Acceleration Capacity =         " + InputParticle.Acceleration.Capacity.ToString() + Environment.NewLine;
            output += "Properties Count =              " + InputParticle.Properties.Count.ToString() + Environment.NewLine;
            output += "Position Count =                " + InputParticle.Position.Count.ToString() + Environment.NewLine;
            output += "Velocity Count =                " + InputParticle.Velocity.Count.ToString() + Environment.NewLine;
            output += "Acceleration Count =            " + InputParticle.Acceleration.Count.ToString() + Environment.NewLine;
            output += "Properties[0] (Mass) Value =    " + InputParticle.Properties[0].ToString() + Environment.NewLine;
            output += "Properties[1] (Charge) Value =  " + InputParticle.Properties[1].ToString() + Environment.NewLine;
            output += "Position[0] (X) Value =         " + InputParticle.Position[0].ToString() + Environment.NewLine;
            output += "Position[1] (Y) Value =         " + InputParticle.Position[1].ToString() + Environment.NewLine;
            output += "Velocity[0] (X) Value =         " + InputParticle.Velocity[0].ToString() + Environment.NewLine;
            output += "Velocity[1] (Y) Value =         " + InputParticle.Velocity[1].ToString() + Environment.NewLine;
            output += "Acceleration[0] (X) Value =     " + InputParticle.Acceleration[0].ToString() + Environment.NewLine;
            output += "Acceleration[1] (Y) Value =     " + InputParticle.Acceleration[1].ToString() + Environment.NewLine;
            
            return output;
        }
    }
}
