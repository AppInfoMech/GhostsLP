using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// RedGhost class. 
    /// This class inherits everything from the Ghost class.
    /// It also adds parameters specific to this color/type of Ghost.
    /// </summary>
    public class RedGhost : Ghost
    {
        public RedGhost()
        {

        }

        /// <summary>
        /// These booleans determine where Red Ghosts can spawn on setup.
        /// </summary>
        bool spawnRed = true;
        bool spawnBlue = false;
        bool spawnYellow = false;
    }
}
