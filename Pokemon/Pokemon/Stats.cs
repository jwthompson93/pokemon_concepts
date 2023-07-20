using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public struct Stats
    {
        public int hp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int spatk { get; set; }
        public int spdef { get; set; }
        public int spd { get; set; }

        public Stats(int hp, int atk, int def, int spatk, int spdef, int spd)
        {
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.spatk = spatk;
            this.spdef = spdef;
            this.spd = spd;
        }
    }
}
