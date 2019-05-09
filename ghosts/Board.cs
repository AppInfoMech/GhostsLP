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
        public State NextTurn { get;  private set; }

        public Board()
        {
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
        /*public State Movestate(Positions position)
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
        }*/

        private void SwitchNextTurn()
        {
            if (NextTurn == State.P1) NextTurn = State.P2;
            else NextTurn = State.P1;
        }
    }
}
