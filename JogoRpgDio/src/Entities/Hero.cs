using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRpgDio.src.Entities
{
    class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public Hero()
        {
        }

        public Hero(string name, int level, string heroType, int hp, int mp)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
            Hp = hp;
            Mp = mp;
        }

        public override string ToString()
        {
            return "My hero: "
                + this.Name
                + ", level "
                + this.Level
                + ", type "
                + this.HeroType
                + ", HP " + Hp
                + ", MP " + Mp;
        }

        public virtual string Attack()
        {
            return this.Name + " Attacked with his sword. ";
        }

       
    }
}
