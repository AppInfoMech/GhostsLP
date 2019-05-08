using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Positions
    {
        public int Row { get; }
        public int Column { get; }

        public Positions(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
