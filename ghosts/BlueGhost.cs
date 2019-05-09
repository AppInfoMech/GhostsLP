using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// BlueGhost class. 
    /// This class inherits everything from the Ghost class.
    /// It also adds parameters specific to this color/type of Ghost.
    /// </summary>
    public class BlueGhost : Ghost
    {
        public BlueGhost()
        {

        }

        /// <summary>
        /// These booleans determine where Blue Ghosts can spawn on setup.
        /// </summary>
        bool spawnRed = false;
        bool spawnBlue = true;
        bool spawnYellow = false;
    }
}
