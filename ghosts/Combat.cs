using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Combat
    {
        //Int que deve receber as características dos Fantasmas 
        //que entram em combate
        private bool RedGhost;
        private bool BlueGhost;
        private bool YellowGhost;

        Colors Colors = new Colors();

        //WE NEED TO CREATE A SETGHOSTTYPE 
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

            if (RedGhost && BlueGhost)
            {
                Console.WriteLine("RED GHOST VS BLUE GHOST. RED WINS.");
                //PUT BLUE GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE
                RedGhost = false;
                BlueGhost = false;
            }
            else if (RedGhost && YellowGhost)
            {
                Console.WriteLine("RED GHOST VS YELLOW GHOST. YELLOW WINS");
                //PUT RED GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE
                RedGhost = false;
                YellowGhost = false;
            }
            else if (BlueGhost && YellowGhost)
            {
                Console.WriteLine("BLUE GHOST VS YELLOW GHOST. BLUE WINS");
                //PUT YELLOW GHOST IN DUNGEON
                //CHANGE WHERE PORTALS ARE
                BlueGhost = false;
                YellowGhost = false;
            }
            else
            {
                Console.WriteLine("INVALID... Ghosts of the same colour " +
                    "cannot engage in combat");
                //PUT THE ATTACKING GHOST BACK IN HIS ORIGINAL POSITION
                BlueGhost = false;
                YellowGhost = false;
                RedGhost = false;
            }
        }
    }
}
