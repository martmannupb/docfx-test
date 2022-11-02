using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimulatorNamespace;

namespace MainNamespace
{
    /// <summary>
    /// The main entry point of the system.
    /// </summary>
    public class Main : MonoBehaviour
    {
        /// <summary>
        /// Let's see if this is documented.
        /// </summary>
        Simulator sim;

        // Start is called before the first frame update
        void Start()
        {
            sim = new Simulator();
        }

        // Update is called once per frame
        void Update()
        {
            sim.SimulateRound();
        }
    }
}
