using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Colors
    {
        //enumeration
        enum Colours { Red, Blue, Yellow }

        //"Getters"
        public int Red() => (int)Colours.Red;
        public int Blue() => (int)Colours.Blue;
        public int Yellow() => (int)Colours.Yellow;
    }
}
