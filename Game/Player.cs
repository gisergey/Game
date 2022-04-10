using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Player
    {
        public Player(string name,int time,int point)
        {
            Name = name;
            Time = time;
            Points = point;

        }
        public string Name;
        public int Time = 150;
        public int Points=0;
        public override string ToString()
        {
            return Name + '\n'.ToString() + Time + '\n'.ToString() + Points;
        }
    }
}
