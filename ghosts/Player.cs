using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Player
    {
        /// <summary>
        /// This function gets the value of the position of the object for the 
        /// setup of the game.
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
        ///  This function gets the value of the position of the object for 
        ///  the Gameloop.
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
                case 1: return new Positions(4, 0); // fifth Line 1st position
                case 2: return new Positions(4, 1); // fifth Line 2nd position 
                case 3: return new Positions(4, 2); // fifth Line 3rd position
                case 4: return new Positions(4, 3); // fifth Line 4th position
                case 5: return new Positions(4, 4); // fifth Line 5th position

                case 6: return new Positions(3, 0); // forth Line 1st position
                case 7: return new Positions(3, 1); // forth Line 2nd position
                case 8: return new Positions(3, 2); // forth Line 3rd position
                case 9: return new Positions(3, 3); // forth Line 4th position
                case 10: return new Positions(3, 4);// forth Line 5th position

                case 11: return new Positions(2, 0); // third Line 1st position
                case 12: return new Positions(2, 1); // third Line 2nd position 
                case 13: return new Positions(2, 2); // third Line 3rd position
                case 14: return new Positions(2, 3); // third Line 4th position
                case 15: return new Positions(2, 4); // third Line 5th position

                case 16: return new Positions(1, 0);// second Line 1st position
                case 17: return new Positions(1, 1);// second Line 2nd position 
                case 18: return new Positions(1, 2);// second Line 3rd position
                case 19: return new Positions(1, 3);// second Line 4th position
                case 20: return new Positions(1, 4);// second Line 5th position

                case 21: return new Positions(0, 0); // first Line 1st position
                case 22: return new Positions(0, 1); // first Line 2nd position
                case 23: return new Positions(0, 2); // first Line 3rd position
                case 24: return new Positions(0, 3); // first Line 4th position
                case 25: return new Positions(0, 4); // first Line 5th position

                default: return null;
            }

        }
    }
}
