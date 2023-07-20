using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class ActivePokemon
    {
        public BasePokemon basePokemonStats { get; }

        public Stats initialIvs { get; }
        public Stats evs { get; set; }
        public int level { get; set; }

        public bool isCatchable { get; protected set; }
    }
}
