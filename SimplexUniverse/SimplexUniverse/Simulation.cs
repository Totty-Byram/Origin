using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimplexUniverse
{
    public class Simulation
    {
        private static Random gen = new Random();

        /// <summary>
        /// Creates a set of randomly positioned particles with a particular set of properties. Velocities and Accelerations are initialized to zero.
        /// </summary>
        /// <returns>A list of randomly positioned particles.</returns>
        public static List<Particle> GetRandomParticleSet(int IndexStart, int NParticles, int NDimensions, List<int> Sizes, List<double?> Properties, bool IsNullPositionAllowed)
        {
            List<Particle> OutList = new List<Particle>(NParticles);

            int i;
            for (i = 0; i < NParticles; i++)
            {
                Particle NewParticle = new Particle(IndexStart + i, NDimensions, Properties.Capacity);
                NewParticle.Properties = Properties;
                NewParticle.InitializeToZero();
                NewParticle.Position = GetRandomCoordinates(NDimensions, Sizes, IsNullPositionAllowed);
                OutList.Add(NewParticle);
            }

            return OutList;
        }

        /// <summary>
        /// Updates the position/properties of a single particle for a single tick.
        /// </summary>
        /// <returns>The modified particle with new position and/or properties</returns>
        public static Particle UpdateParticle()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns a random set of coordinates given the number of dimensions, whether or not nullable values are allowed, and the sizes of the dimensions.
        /// </summary>
        /// <returns>A random set of coordinates.</returns>
        public static List<double?> GetRandomCoordinates(int NumberDimensions, List<int> Sizes, bool IsNullAllowed)
        {
            List<double?> ReturnCoordinates = new List<double?>(NumberDimensions);
            int i;
            for (i = 0; i < NumberDimensions; i++)
            {
                if (IsNullAllowed == true)
                {
                    int val;
                    val = gen.Next(-Sizes[i], Sizes[i] + 1);
                    if (val == Sizes[i])
                    {
                        ReturnCoordinates.Add(null);
                    }
                    else
                    {
                        ReturnCoordinates.Add(val);
                    }
                }
                else
                {
                    ReturnCoordinates.Add(gen.Next(-Sizes[i], Sizes[i]));
                }
            }

            return ReturnCoordinates;
        }

        /// <summary>
        /// Returns a set of randomly shifted coordinates with a specified minimum and maximum walk value.
        /// </summary>
        /// <returns>A set of randomly shifted coordinates.</returns>
        public static List<double?> RandomWalk(List<double?> InitialCoordinates, int MinWalkValue, int MaxWalkValue)
        {
            List<double?> ReturnCoordinates = new List<double?>(InitialCoordinates.Capacity);
            
            foreach (double? Coord in InitialCoordinates)
            {
                if (Coord != null)
                {
                    if (gen.Next(0, 2) == 1)
                    {
                        ReturnCoordinates.Add(Coord + gen.Next(MinWalkValue, MaxWalkValue + 1));
                    }
                    else
                    {
                        ReturnCoordinates.Add(Coord - gen.Next(MinWalkValue, MaxWalkValue + 1));
                    }
                }
            }

            return ReturnCoordinates;
        }

        /// <summary>
        /// Returns the acceleration CHANGES to a particular particle based on gravitational interaction.
        /// </summary>
        /// <returns></returns>
        public static List<double?> CalculateAcceleration_BasicGravity(Particle InputParticle, Particle ModParticle, int MassIndex, double Precision, double GRAVCONSTANT)
        {
            List<double?> ReturnAcceleration = new List<double?>(InputParticle.Acceleration.Capacity);

            int i;
            for (i = 0; i < InputParticle.Acceleration.Capacity; i++) // For each component of the input acceleration
            {
                if (InputParticle.Position[i] == null || InputParticle.Velocity[i] == null || InputParticle.Acceleration[i] == null)
                    {
                        //If any of these are null, then we don't need to worry about it
                    }
                    else
                    {
                        double? Distance = ModParticle.Position[i] - InputParticle.Position[i];
                        if (Distance > -Precision && Distance < Precision)
                        {
                            //If they are at the same point in space (or really close), then the acceleration change is zero
                            ReturnAcceleration.Add(0);
                        }
                        else
                        {
                            if (Distance > 0)
                            {
                                ReturnAcceleration.Add((GRAVCONSTANT * ModParticle.Properties[MassIndex]) / (Distance * Distance));
                            }
                            else
                            {
                                ReturnAcceleration.Add((GRAVCONSTANT * ModParticle.Properties[MassIndex]) / -(Distance * Distance));
                            }
                        }
                    }
            }

            return ReturnAcceleration;
        }

        public static Particle UpdateParticle_BasicGravity(Particle Input, List<Particle> ParticleList, int MassIndex, double Precision, double GRAVCONSTANT, double VelocityLimit)
        {
            if (Input.Properties[MassIndex] == null) return Input;
            
            Particle ReturnParticle = Input;

            foreach (Particle P in ParticleList)
            {
                if (P.ID == Input.ID || P.Properties[MassIndex] == null) continue;
                ReturnParticle.Acceleration = AddLists(ReturnParticle.Acceleration, CalculateAcceleration_BasicGravity(Input, P, MassIndex, Precision, GRAVCONSTANT));
            }

            ReturnParticle.Velocity = AddLists(ReturnParticle.Velocity, ReturnParticle.Acceleration);

            int i;
            for (i = 0; i < ReturnParticle.Velocity.Capacity; i++)
            {
                if (ReturnParticle.Velocity[i] == null) continue;
                if (ReturnParticle.Velocity[i] > 0 && ReturnParticle.Velocity[i] > VelocityLimit) ReturnParticle.Velocity[i] = VelocityLimit;
                if (ReturnParticle.Velocity[i] < 0 && ReturnParticle.Velocity[i] < -VelocityLimit) ReturnParticle.Velocity[i] = -VelocityLimit;
            }

            ReturnParticle.Position = AddLists(ReturnParticle.Position, ReturnParticle.Velocity);
            return ReturnParticle;
        }

        /// <summary>
        /// Adds two lists of positions, accelerations, velocities, etc. together.
        /// </summary>
        /// <returns>The modified list</returns>
        public static List<double?> AddLists(List<double?> List1, List<double?> List2)
        {
            int i;
            for (i = 0; i < List1.Capacity; i++)
            {
                if (List1[i] == null || List2[i] == null)
                {
                    //If one of these has a null value...what should we do?
                }
                else
                {
                    List1[i] = List1[i] + List2[i];
                }
            }
            return List1;
        }

        /// <summary>
        /// Calulates the acceleration due to electromagnetism between two particles.
        /// </summary>
        /// <returns>The list of acceleration changes.</returns>
        public static List<double?> CalculateAcceleration_BasicElecMag(Particle InputParticle, Particle ModParticle, int ChargeIndex, int MassIndex, double Precision, double ELECCONSTANT)
        {
            List<double?> ReturnAcceleration = new List<double?>(InputParticle.Acceleration.Capacity);

            int i;
            for (i = 0; i < InputParticle.Acceleration.Capacity; i++) // For each component of the input acceleration
            {
                if (InputParticle.Position[i] == null || InputParticle.Velocity[i] == null || InputParticle.Acceleration[i] == null)
                {
                    //If any of these are null, then we don't need to worry about it
                }
                else
                {
                    double? Distance = ModParticle.Position[i] - InputParticle.Position[i];
                    if (Distance > -Precision && Distance < Precision)
                    {
                        //If they are at the same point in space (or really close), then the acceleration change is zero
                        ReturnAcceleration.Add(0);
                    }
                    else
                    {
                        if (Distance > 0) 
                        {
                            //ELECCONST = 8.988E9
                            ReturnAcceleration.Add(-((ELECCONSTANT * ModParticle.Properties[ChargeIndex] * InputParticle.Properties[ChargeIndex]) / (Distance * Distance)) / InputParticle.Properties[MassIndex]);
                        }
                        else
                        {
                            ReturnAcceleration.Add(-((ELECCONSTANT * ModParticle.Properties[ChargeIndex] * InputParticle.Properties[ChargeIndex]) / -(Distance * Distance)) / InputParticle.Properties[MassIndex]);
                        }
                    }
                }
            }

            return ReturnAcceleration;
        }

        /// <summary>
        /// Updates the properties of a particle based on surrounding gravitational and electromagnetic interactions.
        /// </summary>
        /// <returns>The modified particle.</returns>
        public static Particle UpdateParticle_BasicElecMag(Particle Input, List<Particle> ParticleList, int ChargeIndex, int MassIndex, double Precision, double ELECCONSTANT, double GRAVCONSTANT, double VelocityLimit)
        {
            if (Input.Properties[ChargeIndex] == null || Input.Properties[MassIndex] == null) return Input;

            Particle ReturnParticle = Input;

            foreach (Particle P in ParticleList)
            {
                if (P.ID == Input.ID || P.Properties[ChargeIndex] == null || P.Properties[MassIndex] == null) continue;
                ReturnParticle.Acceleration = AddLists(ReturnParticle.Acceleration, CalculateAcceleration_BasicGravity(Input, P, MassIndex, Precision, GRAVCONSTANT));
                ReturnParticle.Acceleration = AddLists(ReturnParticle.Acceleration, CalculateAcceleration_BasicElecMag(Input, P, ChargeIndex, MassIndex, Precision, ELECCONSTANT));
            }
            ReturnParticle.Velocity = AddLists(ReturnParticle.Velocity, ReturnParticle.Acceleration);

            int i;
            for (i = 0; i < ReturnParticle.Velocity.Capacity; i++)
            {
                if (ReturnParticle.Velocity[i] == null) continue;
                if (ReturnParticle.Velocity[i] > 0 && ReturnParticle.Velocity[i] > VelocityLimit) ReturnParticle.Velocity[i] = VelocityLimit;
                if (ReturnParticle.Velocity[i] < 0 && ReturnParticle.Velocity[i] < -VelocityLimit) ReturnParticle.Velocity[i] = -VelocityLimit;
            }

            ReturnParticle.Position = AddLists(ReturnParticle.Position, ReturnParticle.Velocity);
            return ReturnParticle;
        }
    }
}
