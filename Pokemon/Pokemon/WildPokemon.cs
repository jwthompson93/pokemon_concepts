using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class WildPokemon : ActivePokemon
    {
        public WildPokemon() { 
            isCatchable = true;
            evs = new Stats(0,0,0,0,0,0);
        }
    }
}
