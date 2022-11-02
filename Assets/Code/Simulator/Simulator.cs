using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ParticleNamespace;

namespace SimulatorNamespace
{
    /// <summary>
    /// The class handling all simulation data and logic.
    /// <para>
    /// Manages all <see cref="Particle"/>s in the system.
    /// </para>
    /// </summary>
    public class Simulator
    {
        private List<ParticleNamespace.Particle> particles;

        public Simulator()
        {
            particles = new List<ParticleNamespace.Particle>();
            for (int i = 0; i < 10; i++)
            {
                particles.Add(new ParticleNamespace.Particle(new Vector2Int(i, 0)));
            }
        }

        /// <summary>
        /// Simulates a complete round by activating each particle.
        /// </summary>
        public void SimulateRound()
        {
            foreach (ParticleNamespace.Particle p in particles)
            {
                p.Activate();
            }
        }
    }
}