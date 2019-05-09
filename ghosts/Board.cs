using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Board
    {
        public bool up = false;
        public bool down = false;
        public bool right = false;
        public bool left = false;

        private State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
            //Tile Array in order to arrange the board
            Tile[,] tiles = new Tile[5, 5];

            //For loop in order to create a ordered 5 by 5 board
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


            state = new State[7, 7];
            NextTurn = State.P1;
        }

        public State GetState(Positions position)
        {
            return state[position.Row, position.Column];
        }

        public bool SetState(Positions position, State newState)
        {
            if (newState != NextTurn) return false;
            if (state[position.Row, position.Column] != State.Undecided) return false;

            state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }
        public State Movestate(Positions position)
        {
         
            if(up == true)
            {
                return state[position.Row + 1, position.Column];
            }
             if(down == true)
             {
                return state[position.Row - 1, position.Column];
            }
             if(right ==true)
             {
                return state[position.Row, position.Column + 1];
            }
            if (left == true)
            {
                return state[position.Row, position.Column - 1];
            }

                return state[position.Row +1 , position.Column];
        }

        private void SwitchNextTurn()
        {
            if (NextTurn == State.P1) NextTurn = State.P2;
            else NextTurn = State.P1;
        }
    }
}
