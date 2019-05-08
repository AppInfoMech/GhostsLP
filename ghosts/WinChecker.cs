using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class WinChecker
    {
        public State Check(Board board)
        {
            if (CheckForWin(board, State.X)) return State.X;
            if (CheckForWin(board, State.O)) return State.O;
            return State.Undecided;
        }

        private bool CheckForWin(Board board, State player)
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(board, new Positions[] {
                        new Positions(row, 0),
                        new Positions(row, 1),
                        new Positions(row, 2) }, player))
                    return true;

            for (int column = 0; column < 3; column++)
                if (AreAll(board, new Positions[] {
                        new Positions(0, column),
                        new Positions(1, column),
                        new Positions(2, column) }, player))
                    return true;

            if (AreAll(board, new Positions[] {
                    new Positions(0, 0),
                    new Positions(1, 1),
                    new Positions(2, 2) }, player))
                return true;

            if (AreAll(board, new Positions[] {
                    new Positions(2, 0),
                    new Positions(1, 1),
                    new Positions(0, 2) }, player))
                return true;

            return false;
        }

        private bool AreAll(Board board, Positions[] positions, State state)
        {
            foreach (Positions position in positions)
                if (board.GetState(position) != state) return false;

            return true;
        }



        public bool IsDraw(Board board)
        {
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    if (board.GetState(new Positions(row, column)) == State.Undecided) return false;

            return true;
        }
    }
}
