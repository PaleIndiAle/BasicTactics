using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTactics
{
    internal class BlockGen
    {
        public int x, y;
        public int size = 50;

        public BlockGen(int _x, int _y) 
        {
            x = _x;
            y = _y;
        }
    }
}
