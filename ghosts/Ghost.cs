using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// Basic Ghost class.
    /// This class contains the properties that all Ghosts must have, 
    /// regardless of their color.
    /// </summary>
    public class Ghost
    {
        /// <summary>
        /// These variables determine the coordinates where Ghosts created 
        /// from this class are located on the board.
        /// </summary>
        public int coorX;
        public int coorY;
    }
}