using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio.src.Entities
{
    class Ninja : Hero
    {
        public Ninja()
        {
        }

        public Ninja(string name, int level, string heroType, int hp, int mp) 
            : base(name, level, heroType, hp, mp)
        {
        }

        public sealed override string Attack()
        {
            return "Nigth dance attack ";
        }
    }
}
