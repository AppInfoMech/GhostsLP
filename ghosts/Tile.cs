using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class holds the characteristics that can be in each Tile after
    /// the For loop in Board.cs
    /// </summary>
    /// <remarks>
    /// It then uses a "Getter-Setter" to attribute the same variable with 
    /// diferent values to each specific tile.
    /// </remarks>
    class Tile
    {
        //Initialize variables
        /// <summary>
        /// This variable holds a int that will be the int that characterizes
        /// the colour we chose to give it.
        /// </summary>
        private int TileColor;

        public Tile()
        {

        }

        //"Getter-Setter"
        /// <summary>
        /// This "getter-setter" takes the TileColor variable and allows us to
        /// attribute it to tiles while having different values for all.
        /// </summary>
        /// <remarks>
        /// The x is just a placeholder. We can then replace it by attributing 
        /// it the int for a colour.
        /// </remarks>
        /// <param name="x"></param>
        public void SetColor(int x) => TileColor = x;
    }
}
