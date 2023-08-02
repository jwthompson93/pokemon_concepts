using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon.Types;

namespace Pokemon.Pokemon
{
    public class TrainerOwnedPokemon : ActivePokemon
    {
        public TrainerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : base(pokemonId, initialIvs, evs, level, isCatchable)
        {

        }
    }
}
