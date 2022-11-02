using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ParticleNamespace
{
    /// <summary>
    /// Represents a single particle in the simulation.
    /// </summary>
    public class Particle
    {
        /// <summary>
        /// The position of the particle in the grid.
        /// </summary>
        public Vector2Int position;

        /// <summary>
        /// Creates a new particle at the given position.
        /// </summary>
        /// <param name="pos">The grid position where the particle will be created.</param>
        public Particle(Vector2Int pos)
        {
            position = pos;
        }

        /// <summary>
        /// Activates the particle once.
        /// </summary>
        public virtual void Activate()
        {
            // TODO
        }
    }

}
