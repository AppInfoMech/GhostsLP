using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Board
    {
        private State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
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
            if (state[position.Row, position.Column] != State.Undecided) return false;

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
