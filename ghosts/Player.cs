using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Player
    {
        /// <summary>
        /// This function gets the value of the position of the object for the setup of the game.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public Positions GetPosition(Board board)
        {
            Console.WriteLine("");
            int position = Convert.ToInt32(Console.ReadLine());

            Positions desiredCoordinate = PositionForNumber(position);
            return desiredCoordinate;
        }
        /// <summary>
        ///  This function gets the value of the position of the object for the Gameloop.
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        public Positions GetLoopPosition(Board board)
        {
            Console.WriteLine("");

            Console.WriteLine("What ghost do you want to move?");
            int position = Convert.ToInt32(Console.ReadLine());
            Positions desiredCoordinate = PositionForNumber(position);

            Console.WriteLine("up -> u");
            Console.WriteLine("down -> d");
            Console.WriteLine("right -> r");
            Console.WriteLine("left -> l");
            Console.WriteLine("Where do you want to move it?");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'u':
                    desiredCoordinate.Row = desiredCoordinate.Row + 1;
                    return desiredCoordinate;

                case 'd':
                    return desiredCoordinate;

                case 'r':
                    return desiredCoordinate;

                case 'l':
                    return desiredCoordinate;

                default:
                    return null;
            }


             
        }

        /// <summary>
        /// This function gives the value of the desired location of the user.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>

        private Positions PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Positions(4, 0); // Bottom Left
                case 2: return new Positions(4, 1); // Bottom Middle 
                case 3: return new Positions(4, 2); // Bottom Right
                case 4: return new Positions(4, 3); // Middle Left
                case 5: return new Positions(4, 4); // Middle Middle

                case 6: return new Positions(3, 0); // Bottom Left
                case 7: return new Positions(3, 1); // Bottom Middle 
                case 8: return new Positions(3, 2); // Bottom Right
                case 9: return new Positions(3, 3); // Middle Left
                case 10: return new Positions(3, 4); // Middle Middle

                case 11: return new Positions(2, 0); // Bottom Left
                case 12: return new Positions(2, 1); // Bottom Middle 
                case 13: return new Positions(2, 2); // Bottom Right
                case 14: return new Positions(2, 3); // Middle Left
                case 15: return new Positions(2, 4); // Middle Middle

                case 16: return new Positions(1, 0); // Bottom Left
                case 17: return new Positions(1, 1); // Bottom Middle 
                case 18: return new Positions(1, 2); // Bottom Right
                case 19: return new Positions(1, 3); // Middle Left
                case 20: return new Positions(1, 4); // Middle Middle

                case 21: return new Positions(0, 0); // Bottom Left
                case 22: return new Positions(0, 1); // Bottom Middle 
                case 23: return new Positions(0, 2); // Bottom Right
                case 24: return new Positions(0, 3); // Middle Left
                case 25: return new Positions(0, 4); // Middle Middle

                default: return null;
            }

        }
    }
}
