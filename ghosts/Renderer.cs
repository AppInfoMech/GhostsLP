using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class is to draw everything related to the game.
    /// </summary>
    class Renderer
    {
        /// <summary>
        /// this is where it draws the board
        /// </summary>
        /// <param name="board"></param>
        /// <param name="loop"></param>
        public void Render(Board board, bool loop)
        {
             char[,] symbols = new char[6, 6];
             for (int row = 0; row < 6; row++)
                 for (int column = 0; column < 6; column++)
                     if (loop == true)
                     {
                         symbols[row, column] = SymbolFor(board.GetState
                             (new Positions(row, column)));
                     }
                     else
                         symbols[row, column] = SymbolFor(board.GetState
                             (new Positions(row, column)));

             Console.WriteLine("");
            // drawin a guide board for the player to be able to see the 
            //positions.
             Console.WriteLine($"| 19 | 20 | BP | 21 | 22 |   |");
             Console.WriteLine("+----+----+----+----+----+   +");
             Console.WriteLine($"| 14 | 15 | 16 | 17 | 18 |   |");
             Console.WriteLine("+----+----+----+----+----+   +");
             Console.WriteLine($"| YP | 10 | 11 | 12 | 13 |   |");
             Console.WriteLine("+----+----+----+----+----+   +");
             Console.WriteLine($"| 5  | 6  | 7  | 8  | 9  |   |");
             Console.WriteLine("+----+----+----+----+----+   +");
             Console.WriteLine($"| 1  | 2  | RP | 3  | 4  |   |");

             Console.WriteLine("");
             Console.WriteLine("");

            Console.WriteLine($"| {symbols[0, 0]} | {symbols[0, 1]} | " +
                $"\u156C | {symbols[0, 3]} | {symbols[0, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+   +");
            Console.WriteLine($"| {symbols[1, 0]} | {symbols[1, 1]} | " +
                $"{symbols[1, 2]} | {symbols[1, 3]} | {symbols[1, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+   +");
            Console.WriteLine($"| \u156E | {symbols[2, 1]} | " +
                $"{symbols[2, 2]} | {symbols[2, 3]} | {symbols[2, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+   +");
            Console.WriteLine($"| {symbols[3, 0]} | {symbols[3, 1]} | " +
                $"{symbols[3, 2]} | {symbols[3, 3]} | {symbols[3, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+   +");
            Console.WriteLine($"| {symbols[4, 0]} | {symbols[4, 1]} | " +
                $"\u156B | {symbols[4, 3]} | {symbols[4, 4]} |   |");
        }
        /// <summary>
        /// Looks for the corrent player then gets his respective simbol
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private char SymbolFor(State state)
        {
            switch (state)
            {
                case State.P2: return '\u1cc3';
                case State.P1: return '\u1cc1';
                default: return ' ';
            }
        }
        /// <summary>
        /// Its to draw the winning lines
        /// </summary>
        /// <param name="winner"></param>
        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.P2:
                case State.P1:
                    Console.WriteLine(SymbolFor(winner) + " Wins!");
                    break;
                case State.Undecided:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
}
