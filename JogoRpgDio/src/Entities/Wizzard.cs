using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio.src.Entities
{
    class Wizzard : Hero
    {
        public Wizzard()
        {
        }

        public Wizzard(string name, int level, string heroType, int hp, int mp) 
            : base(name, level, heroType, hp, mp)
        {
        }

        public  override string Attack()
        {
            return  "Attacked with his magic. ";
        }

        public  virtual string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Attacked with his super effective magic with bonus " + Bonus;
            }
            else
            {
                return this.Name + " Attacked with its weak magic bonus " + Bonus;
            }
        }
    }
}
