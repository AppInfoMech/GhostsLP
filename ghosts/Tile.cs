using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    //class in which the details/characteristics inside of the tiles in the
    //board will be set.
    class Tile
    {
        //Initialize variables
        private int TileColor;

        public Tile()
        {

        }

        //"Getter-Setter"
        public void SetColor(int x) => TileColor = x;
    }
}
