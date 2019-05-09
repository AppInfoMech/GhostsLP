using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    /// <summary>
    /// This class resolves conflicts between ghosts.
    /// </summary>
    /// <remarks>
    /// If the game detects that 2 ghosts are sharing a tile, it runs this 
    /// class to try and solve that conflict.
    /// </remarks>
    class Combat
    {
        /// <summary>
        /// This bool is turned true if in the tile where two ghosts are, one
        /// is detected to be Red.
        /// </summary>
        private bool RedGhost;
        /// <summary>
        /// This bool is turned true if in the tile where two ghosts are, one
        /// is detected to be Blue.
        /// </summary>
        private bool BlueGhost;
        /// <summary>
        /// This bool is turned true if in the tile where two ghosts are, one
        /// is detected to be Yellow.
        /// </summary>
        private bool YellowGhost;

        /// <summary>
        /// This constructor is called when there's a conflict and it detects
        /// what is happening and solves it.
        /// </summary>
        /// <remarks>
        /// Using a system of "ifs", it can detect what type of ghosts are 
        /// in conflict and then apply the correct option to the situation,
        /// whether it be the victory of a specific type of ghost or to undo
        /// a previous move.
        /// </remarks>
        public Combat()
        {

            //ISTO É PARA FAZEREM TESTES COM O SISTEMA DE COMBAT, SE PRECISAREM
            //DEPOIS DE FAZEREM ALTERAÇÕES AO PROJETO

            //while (true)
            //{
            //    Console.WriteLine("COMBAT TEST");
            //    Console.WriteLine("GHOST 1 COLOUR: ");
            //    string GHOST = Console.ReadLine();

            //    if (GHOST == "RED")
            //    {
            //        RedGhost = true;
            //    }
            //    else if (GHOST == "BLUE")
            //    {
            //        BlueGhost = true;
            //    }
            //    else if (GHOST == "YELLOW")
            //    {
            //        YellowGhost = true;
            //    }

            //    Console.WriteLine("GHOST 2 COLOUR: ");
            //    GHOST = Console.ReadLine();

            //    if (GHOST == "RED")
            //    {
            //        RedGhost = true;
            //        break;
            //    }
            //    else if (GHOST == "BLUE")
            //    {
            //        BlueGhost = true;
            //        break;
            //    }
            //    else if (GHOST == "YELLOW")
            //    {
            //        YellowGhost = true;
            //        break;
            //    }
            //}

            ///If the involved ghosts are Red and Blue.
            if (RedGhost && BlueGhost)
            {
                Console.WriteLine("RED GHOST VS BLUE GHOST. RED WINS.");
                
                //PUT BLUE GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE

                //Turns the bools back to false so it doesn't detect this 
                //conflict again after it has been resolved
                RedGhost = false;
                BlueGhost = false;
            }
            //If the involved ghosts are Red and Yellow
            else if (RedGhost && YellowGhost)
            {
                Console.WriteLine("RED GHOST VS YELLOW GHOST. YELLOW WINS");

                //PUT RED GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE

                //Turns the bools back to false so it doesn't detect this 
                //conflict again after it has been resolved
                RedGhost = false;
                YellowGhost = false;
            }
            //If the involved ghosts are Blue and Yellow
            else if (BlueGhost && YellowGhost)
            {
                Console.WriteLine("BLUE GHOST VS YELLOW GHOST. BLUE WINS");

                //PUT YELLOW GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE

                //Turns the bools back to false so it doesn't detect this 
                //conflict again after it has been resolved
                BlueGhost = false;
                YellowGhost = false;
            }
            //If the involved ghosts are of the same colour
            else
            {
                Console.WriteLine("INVALID... Ghosts of the same colour " +
                    "cannot engage in combat");

                //PUT THE ATTACKING GHOST BACK IN HIS ORIGINAL POSITION

                //Turns all of the bools back to false so it doesn't detect
                //this conflict again after it has been resolved.
                BlueGhost = false;
                YellowGhost = false;
                RedGhost = false;
            }
        }
    }
}
