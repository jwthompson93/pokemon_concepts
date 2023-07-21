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
            this.BasePokemonStats = PokemonConstants.GetInstance().GetPokemon(pokemonId);
            this.InitialIvs = initialIvs;
            this.Evs = evs;
            this.Level = level;
            this.IsCatchable = isCatchable;
        }

        public BasePokemon BasePokemonStats { get; protected set; }

        public Stats InitialIvs { get; }
        public Stats Evs { get; set; }
        public int Level { get; set; }

        public bool IsCatchable { get; protected set; }
    }
}
