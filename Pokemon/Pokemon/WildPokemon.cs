using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class WildPokemon
    {
        Random random = new Random();
        public ActivePokemon activePokemon;

        public WildPokemon(int pokemonId, int level) {
            activePokemon = new ActivePokemon(
                pokemonId,
                new Stats(
                    random.Next(0, 31),
                    random.Next(0, 31),
                    random.Next(0, 31),
                    random.Next(0, 31),
                    random.Next(0, 31),
                    random.Next(0, 31)
                ),
                new Stats(0, 0, 0, 0, 0, 0),
                level,
                true
            );
        }
    }
}
