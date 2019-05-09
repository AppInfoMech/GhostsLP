﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class is where all the game loops (gameplay).
    /// </summary>
    class GameLoop
    {
        public bool Gameloop = false;

        public GameLoop ()
        {
        }

        public void Gamestart(Board board, Renderer renderer, Player player1, 
            Player player2)
        {
            Gameloop = true;
            while (true)
            {
                renderer.Render(board, Gameloop);

                Positions nextMove;
                if (board.NextTurn == State.P1)
                    nextMove = player1.GetLoopPosition(board);
                else
                    nextMove = player2.GetLoopPosition(board);

                if (!board.SetState(nextMove, board.NextTurn))
                    Console.WriteLine("That is not a legal move.");

            }
        }
        public void GameSetup(Board board, Renderer renderer, Player player1, 
            Player player2)
        {
            for (int i = 0; i < 18; i++)
            {
                renderer.Render(board,Gameloop);

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
