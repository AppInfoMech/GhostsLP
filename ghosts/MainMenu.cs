using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class creates the main menu that appears to the players before
    /// the actual game begins
    /// </summary>
    /// <remarks>
    /// In this class, the players are asked for their name and for the mode
    /// they wish to play
    /// </remarks>
    /// <returns>
    /// Returns the name of both players and the selected mode
    /// </returns>
    class MainMenu
    {
        //Declare Variables
        /// <summary>
        /// This variable is where we save Player 1's chosen name
        /// </summary>
        /// <remarks>
        /// The purpose of this is so that we're able to address the player
        /// properly instead of resorting to a generic Player 1
        /// </remarks>
        private string name1;
        /// <summary>
        /// This variable is where we save Player 2's chosen name
        /// </summary>
        /// <remarks>
        /// The purpose of this is so that we're able to address the player
        /// properly instead of resorting to a generic Player 2
        /// </remarks>
        private string name2;
        /// <summary>
        /// This variable is used for the "if" that tweaks the bool
        /// "quickmode" depending on the player's choice.
        /// </summary>
        /// <remarks>
        /// It's not used again so we don't return it.
        /// </remarks>
        private string choice;
        /// <summary>
        /// This bool detects if the player chose to play in Quick Mode or
        /// not (Regular)
        /// </summary>
        /// <remarks>
        /// It is then used in CheckWin.cs to confirm the Win-Conditions.
        /// </remarks>
        private bool quickmode;

        //Create Constructor
        /// <summary>
        /// The constructor that presents the player with the questions and
        /// collects their answers to variables that can then be used for the 
        /// rest of the game
        /// </summary>
        /// <remarks>
        /// "Select Mode" is under a loop so we're able to warn the player
        /// that his choice (ReadLine) is not valid and for him to retry a
        /// valid value instead of crashing or quitting the program.
        /// </remarks>
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
        /// <summary>
        ///"Getter" - Makes the variables usable throught the rest of the 
        ///program
        /// </summary>
        /// <returns>
        /// name1 - Player 1's chosen name
        /// </returns>
        public string GetName1() => name1;
        /// <summary>
        ///"Getter" - Makes the variables usable throught the rest of the 
        ///program
        /// </summary>
        /// <returns>
        /// name2 - Player 2's chosen name
        /// </returns>
        public string GetName2() => name2;
        /// <summary>
        ///"Getter" - Makes the variables usable throught the rest of the 
        ///program
        /// </summary>
        /// <returns>
        /// quickmode - If the players chose to play on Quick mode.
        /// </returns>
        public bool QuickMode() => quickmode;
    }
}