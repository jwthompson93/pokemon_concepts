using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class WildPokemon
    {
        private Random _random = new Random();
        public ActivePokemon ActivePokemon;

        public WildPokemon(int pokemonId, int level) {
            ActivePokemon = new ActivePokemon(
                pokemonId,
                new Stats(
                    _random.Next(0, 31),
                    _random.Next(0, 31),
                    _random.Next(0, 31),
                    _random.Next(0, 31),
                    _random.Next(0, 31),
                    _random.Next(0, 31)
                ),
                new Stats(0, 0, 0, 0, 0, 0),
                level,
                true
            );
        }
    }
}
