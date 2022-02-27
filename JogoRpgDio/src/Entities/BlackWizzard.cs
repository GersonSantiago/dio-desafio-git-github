using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio.src.Entities
{
    class BlackWizzard : Wizzard
    {
        public BlackWizzard()
        {
        }

        public BlackWizzard(string name, int level, string heroType, int hp, int mp) 
            : base(name, level, heroType, hp, mp)
        {
        }


        public override string Attack(int Bonus)
        {
            return base.Attack(Bonus);
        }

    }
}


