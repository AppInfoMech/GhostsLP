using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[6, 6];
            for (int row = 0; row < 6; row++)
                for (int column = 0; column < 6; column++)
                    symbols[row, column] = SymbolFor(board.GetState(new Positions(row, column)));

            Console.WriteLine("");

            Console.WriteLine($"| 21 | 22 | 23 | 24 | 25 |   |");
            Console.WriteLine("+----+----+----+----+----+---+");
            Console.WriteLine($"| 16 | 17 | 18 | 19 | 20 |   |");
            Console.WriteLine("+----+----+----+----+----+---+");
            Console.WriteLine($"| 11 | 12 | 13 | 14 | 15 |   |");
            Console.WriteLine("+----+----+----+----+----+---+");
            Console.WriteLine($"| 6  | 7  | 8  | 9  | 10 |   |");
            Console.WriteLine("+----+----+----+----+----+---+");
            Console.WriteLine($"| 1  | 2  | 3  | 4  | 5  |   |");

            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine($"| {symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]} | {symbols[0, 3]} | {symbols[0, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+---+");
            Console.WriteLine($"| {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} | {symbols[1, 3]} | {symbols[1, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+---+");
            Console.WriteLine($"| {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} | {symbols[2, 3]} | {symbols[2, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+---+");
            Console.WriteLine($"| {symbols[3, 0]} | {symbols[3, 1]} | {symbols[3, 2]} | {symbols[3, 3]} | {symbols[3, 4]} |   |");
            Console.WriteLine("+---+---+---+---+---+---+");
            Console.WriteLine($"| {symbols[4, 0]} | {symbols[4, 1]} | {symbols[4, 2]} | {symbols[4, 3]} | {symbols[4, 4]} |   |");
        }

        private char SymbolFor(State state)
        {
            switch (state)
            {
                case State.O: return 'O';
                case State.X: return 'X';
                default: return '\u156E';
            }
        }

        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.O:
                case State.X:
                    Console.WriteLine(SymbolFor(winner) + " Wins!");
                    break;
                case State.Undecided:
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
}
