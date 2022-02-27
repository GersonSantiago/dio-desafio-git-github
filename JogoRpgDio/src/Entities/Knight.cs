using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio.src.Entities
{
    class Knight : Hero
    {
        public Knight()
        {
        }

        public Knight(string name, int level, string heroType, int hp, int mp) 
            : base(name, level, heroType, hp, mp)
        {
        }
    }
}
