using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class ActivePokemon
    {

        public ActivePokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable)
        {
            this.basePokemonStats = PokemonConstants.getInstance().GetPokemon(pokemonId);
            this.initialIvs = initialIvs;
            this.evs = evs;
            this.level = level;
            this.isCatchable = isCatchable;
        }

        public BasePokemon basePokemonStats { get; protected set; }

        public Stats initialIvs { get; }
        public Stats evs { get; set; }
        public int level { get; set; }

        public bool isCatchable { get; protected set; }
    }
}
