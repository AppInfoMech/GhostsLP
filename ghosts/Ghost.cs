using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Ghost
    {
        //INITIALIZE VARIABLES
        private int GhostType;

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
        }
    }
}