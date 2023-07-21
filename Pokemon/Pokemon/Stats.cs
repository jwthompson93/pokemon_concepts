using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public struct Stats
    {
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spatk { get; set; }
        public int Spdef { get; set; }
        public int Spd { get; set; }

        public Stats(int hp, int atk, int def, int spatk, int spdef, int spd)
        {
            this.Hp = hp;
            this.Atk = atk;
            this.Def = def;
            this.Spatk = spatk;
            this.Spdef = spdef;
            this.Spd = spd;
        }
    }
}
