using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// YellowGhost class. 
    /// This class inherits everything from the Ghost class.
    /// It also adds parameters specific to this color/type of Ghost.
    /// </summary>
    public class YellowGhost : Ghost
    {
        public YellowGhost()
        {

        }

        /// <summary>
        /// These booleans determine where Yellow Ghosts can spawn on setup.
        /// </summary>
        bool spawnRed = false;
        bool spawnBlue = false;
        bool spawnYellow = true;
    }
}
