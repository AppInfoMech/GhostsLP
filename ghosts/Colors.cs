using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class holds all the colours and sends them to rest of the
    /// program.
    /// </summary>
    /// <remarks>
    /// This class enumerates all three colours and then has a getter to send
    /// it to wherever it may be needed so that the whole program refers to the
    /// colours in the same way.
    /// </remarks>
    class Colors
    {
        //enumeration
        /// <summary>
        /// Enumeration that contains all 3 colours.
        /// </summary>
        /// <remarks>
        /// We can then use the ints that define each member of this 
        /// enumeration to refer to the colours throught the program.
        /// </remarks>
        enum Color { Red, Blue, Yellow }

        //"Getters"
        /// <summary>
        /// "Getter" that gets the int that defines Red.
        /// </summary>
        /// <returns>Color.Red (int that characterizes Red)</returns>
        public int Red() => (int)Color.Red;
        /// <summary>
        /// "Getter" that gets the int that defines Blue.
        /// </summary>
        /// <returns>Color.Blue (int that characterizes Blue)</returns>
        public int Blue() => (int)Color.Blue;
        /// <summary>
        /// "Getter" that gets the int that defines Yellow.
        /// </summary>
        /// <returns>Color.Yellow (int that characterizes Yellow)</returns>
        public int Yellow() => (int)Color.Yellow;
    }
}
