using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

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
