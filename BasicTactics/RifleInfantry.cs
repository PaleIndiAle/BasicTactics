using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicTactics
{
    internal class RifleInfantry
    {
        public int team, cost, HP, attack, range, movement, luck, x, y;
        public static Random luckvalue = new Random();

        public RifleInfantry(int _team, int _x, int _y)
        {
            team = _team;
            cost = 50;
            HP = 4;
            attack = 3;
            range = 1;
            movement = 3;
            luck = luckvalue.Next(0, 10);
            x = _x;
            y = _y;
        }
    }
}
