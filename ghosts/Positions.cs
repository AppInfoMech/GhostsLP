using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class gets the number of positions of the row and the column.
    /// </summary>
    class Positions
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Positions(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
