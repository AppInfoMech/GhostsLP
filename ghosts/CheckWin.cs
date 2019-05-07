using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class CheckWin
    {
        //DECLARE VARIABLES
        private bool P1FreeYellow;
        private bool P1FreeGreen;
        private bool P1FreeRed;

        private int P1FreeGhosts;
        private int P2FreeGhosts;

        private bool P2FreeYellow;
        private bool P2FreeGreen;
        private bool P2FreeRed;


        private bool running; //FAKE BOOL... Edit once Game Loop is done




        //CREATE CONSTRUCTOR
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
