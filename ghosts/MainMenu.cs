using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class MainMenu
    {
        //Declare Variables
        private string name1;
        private string name2;
        private string choice;
        private bool quickmode;

        //Create Constructor
        public MainMenu()
        {
            Console.WriteLine("Hello there and welcome to 18 Ghosts!");
            Console.WriteLine("");

            //Select Name
            Console.Write("Player 1, what's your name?  ");
            this.name1 = Console.ReadLine();
            Console.Write("Player 2, who are you?  ");
            this.name2 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome {0} and {1}!", this.name1, this.name2);

            //Select Mode
            while (true)
            {
                Console.WriteLine("What mode do you want to play?");
                Console.WriteLine("");
                Console.WriteLine("1: REGULAR - Enjoy the classic game of " +
                    "«18 Ghosts» where the requirements for victory are that" +
                    " you save at least 1 ghost of each colour!");
                Console.WriteLine("");
                Console.WriteLine("2: QUICK - Enjoy a special variant of " +
                    "«18 Ghosts» for when you just want to enjoy a quick " +
                    "game. The requirements for victory are that you save" +
                    " any 3 ghosts!");
                Console.WriteLine("");
                Console.Write("Which mode do you want to play (1 or 2)?   ");
                this.choice = Console.ReadLine();

                if (this.choice == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You have selected REGULAR mode... " +
                        "Please, enjoy the game!");
                    this.quickmode = false;
                    break;
                }
                else if (this.choice == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("You have selected QUICK mode... " +
                        "Please, enjoy the game!");
                    this.quickmode = true;
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Invalid! Please, select a valid" +
                        " option.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                }
            }


        }

        //"Getters"
        public string GetName1() => name1;
        public string GetName2() => name2;
        public bool QuickMode() => quickmode;
    }
}