using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class GameLoop
    {

        public GameLoop ()
        {
            
        }

        public void GameSetup(Board board, Renderer renderer, Player player1, Player player2)
        {
            for (int i = 0; i < 18; i++)
            {
                renderer.Render(board);

                Positions nextMove;
                if (board.NextTurn == State.P1)
                    nextMove = player1.GetPosition(board);
                else
                    nextMove = player2.GetPosition(board);

                if (!board.SetState(nextMove, board.NextTurn))
                    Console.WriteLine("That is not a legal move.");
            }
        }
    }
}
