using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class checks if any of the players has won so it can terminate
    /// the game-loop.
    /// </summary>
    /// <remarks>
    /// It checks each loop if any of the player has won... If one has,
    /// it also detects who did and presents a win message to that player
    /// before terminating the game-loop.
    /// </remarks>
    class CheckWin
    {
        //DECLARE VARIABLES
        /// <summary>
        /// Turns into true if player one was released any yellow ghosts
        /// </summary>
        private bool P1FreeYellow;
        /// <summary>
        /// Turns into true if player one was released any yellow green
        /// </summary>
        private bool P1FreeGreen;
        /// <summary>
        /// Turns into true if player one was released any yellow red
        /// </summary>
        private bool P1FreeRed;

        /// <summary>
        /// Checks how many ghosts player one released (each released ghost
        /// adds +1 to this int that starts at 0 in the beginning of the game
        /// </summary>
        private int P1FreeGhosts;
        /// <summary>
        /// Checks how many ghosts player two released (each released ghost
        /// adds +1 to this int that starts at 0 in the beginning of the game
        /// </summary>
        private int P2FreeGhosts;

        /// <summary>
        /// Turns into true if player two was released any yellow ghosts
        /// </summary>
        private bool P2FreeYellow;
        /// <summary>
        /// Turns into true if player two was released any green ghosts
        /// </summary>
        private bool P2FreeGreen;
        /// <summary>
        /// Turns into true if player two was released any red ghosts
        /// </summary>
        private bool P2FreeRed;

        /// <summary>
        /// Bool used to create the Game-Loop. Turns false at win-conditions
        /// to end the game.
        /// </summary>
        private bool running; //FAKE BOOL... Edit once Game Loop is done




        //CREATE CONSTRUCTOR
        /// <summary>
        /// This constructor detects the win conditions via "ifs" and ends
        /// the game loop.
        /// </summary>
        /// 
        /// <remarks>
        /// The "ifs" inside "ifs" work in the way that it first detects if
        /// you chose Quick Mode. If you haven't it goes directly to the else
        /// since it's impossible to progress to this point before selecting
        /// either Quick Mode or Regular. Inside both of these "ifs", it
        /// uses variables (different per player) to detect if the win
        /// conditions have been met and depending on those variables, it can
        /// say which player won. It then presents a message and interrupts
        /// the loop.
        /// </remarks>
        public CheckWin()
        {
            //IMPORT MAINMENU CLASS
            MainMenu MainMenu = new MainMenu();

            //DETECT QUICK MODE
            if (MainMenu.QuickMode())
            {
                //DETECT IF PLAYER ONE WON
                if (P1FreeGhosts == 3)
                {
                    //PLAYER ONE WINS
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations {0}! You won!", 
                        MainMenu.GetName1());
                    
                    //TERMINATE GAME-LOOP
                    running = false;
                }
                //DETECT IF PLAYER TWO WON
                else if (P2FreeGhosts == 3)
                {
                    //PLAYER TWO WINS
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations {0}! You won!",
                        MainMenu.GetName2());

                    //TERMINATE GAME-LOOP
                    running = false;
                }
            }
            //DETECT REGULAR MODE
            else
            {
                //DETECT IF PLAYER ONE WON
                if (P1FreeGreen & P1FreeRed & P1FreeYellow)
                {
                    //PLAYER ONE WINS
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations {0}! You won!",
                        MainMenu.GetName1());

                    //TERMINATE GAME-LOOP
                    running = false;
                }
                //DETECT IF PLAYER TWO WON
                else if (P2FreeGreen & P2FreeRed & P2FreeYellow)
                {
                    //PLAYER TWO WINS
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Congratulations {0}! You won!",
                        MainMenu.GetName2());

                    //TERMINATE GAME-LOOP
                    running = false;
                }
            }
        }
    }
}
