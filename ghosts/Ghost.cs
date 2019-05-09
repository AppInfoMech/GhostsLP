using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    public class Ghost
    {
        public int coorX;
        public int coorY;

        /* INITIALIZE VARIABLES
        // private int GhostType;

        public Ghost(int GhostType)
        {
            Colors Colors = new Colors();

            if (GhostType == Colors.Red())
            {
                //CENAS DO FANTASMA VERMELHO
            }
            else if (GhostType == Colors.Blue())
            {
                //CENAS DO FANTASMA AZUL
            }
            else if (GhostType == Colors.Yellow())
            {
                //CENAS DO FANTASMA AMARELO
            }
        } */
    }

    public class RedGhost : Ghost
    {
        public RedGhost()
        {
            
        }

        bool spawnRed = true;
        bool spawnBlue = false;
        bool spawnYellow = false;
    }

    public class BlueGhost : Ghost
    {
        bool spawnRed = false;
        bool spawnBlue = true;
        bool spawnYellow = false;
    }

    public class YellowGhost : Ghost
    {
        bool spawnRed = false;
        bool spawnBlue = false;
        bool spawnYellow = true;
    }


    RedGhost[] redghost = new RedGhost[6];


}