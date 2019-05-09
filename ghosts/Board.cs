using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Board
    {

        private State[,] state;
        public State NextTurn { get;  private set; }

        /// <summary>
        /// This class will setup the board so we can then render it and 
        /// start the game.
        /// </summary>
        public Board()
        {
            //INITIALIZE COLORS CLASS SO I CAN USE THE GETTERS
            Colors colors = new Colors();

            //BI-DIMENSIONAL TILE ARRAY TO ARRANGE THE BOARD
            Tile[,] tiles = new Tile[5, 5];

            ///FOR LOOP TO CREATE A 5 BY 5 ARRAY
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    tiles[x, y] = new Tile();
                }
            }


            /*
             * TILES ARRAY REPRESENTED GRAPHICALLY
             * 
             * [0,0] [0,1] [0,2] [0,3] [0,4]
             * [1,0] [1,1] [1,2] [1,3] [1,4]
             * [2,0] [2,1] [2,2] [2,3] [2,4]
             * [3,0] [3,1] [3,2] [3,3] [3,4]
             * [4,0] [4,1] [4,2] [4,3] [4,4]
             * 
            */

            //GIVES EACH TILE A COLOUR TO USE WHEN SETTING UP THE GAME
            tiles[0,0].SetColor(colors.Blue());
            tiles[0,1].SetColor(colors.Red());
            //tiles[0,2] - Portal Room
            tiles[0,3].SetColor(colors.Blue());
            tiles[0,4].SetColor(colors.Red());

            tiles[1,0].SetColor(colors.Yellow());
            //tiles[1,1] - Mirror Room
            tiles[1,2].SetColor(colors.Yellow());
            //tiles[1,3] - Mirro Room
            tiles[1,4].SetColor(colors.Yellow());

            tiles[2,0].SetColor(colors.Red());
            tiles[2,1].SetColor(colors.Blue());
            tiles[2,2].SetColor(colors.Red());
            tiles[2,3].SetColor(colors.Blue());
            //tiles[2,4] - Portal Room

            tiles[3,0].SetColor(colors.Blue());
            //tiles[3,1] - Mirror Room
            tiles[3,2].SetColor(colors.Yellow());
            //tiles[3,3] - Mirror Room
            tiles[3,4].SetColor(colors.Red());

            tiles[4,0].SetColor(colors.Yellow());
            tiles[4,1].SetColor(colors.Red());
            //tiles[4,2] - Portal Room
            tiles[4,3].SetColor(colors.Blue());
            tiles[4,4].SetColor(colors.Yellow());

            
            state = new State[6, 6];
            NextTurn = State.P1;
        }

        public State GetState(Positions position)
        {
            return state[position.Row, position.Column];
        }

        public bool SetState(Positions position, State newState)
        {
            if (newState != NextTurn) return false;
            if (state[position.Row, position.Column] != State.Undecided)
                return false;

            state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }

        private void SwitchNextTurn()
        {
            if (NextTurn == State.P1) NextTurn = State.P2;
            else NextTurn = State.P1;
        }
    }
}
