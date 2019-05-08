using System;
using System.Collections.Generic;
using System.Text;

namespace ghosts
{
    class Colors
    {
        //enumeration
        enum Color { Red, Blue, Yellow }

        //"Getters"
        public int Red() => (int)Color.Red;
        public int Blue() => (int)Color.Blue;
        public int Yellow() => (int)Color.Yellow;
    }
}
