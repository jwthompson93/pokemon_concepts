using Pokemon.Constants;
using Pokemon.Enums;

namespace Pokemon.Types.Subtype
{
    public class TrainerOwnedPokemon : ActivePokemon
    {
        public TrainerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, Nature nature, bool isCatchable) : base(pokemonId, initialIvs, evs, level, nature, isCatchable)
        {

        }
    }
}
