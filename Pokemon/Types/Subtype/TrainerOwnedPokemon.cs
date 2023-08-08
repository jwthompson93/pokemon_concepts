using Pokemon.Constants;

namespace Pokemon.Types.Subtype
{
    public class TrainerOwnedPokemon : ActivePokemon
    {
        public TrainerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : base(pokemonId, initialIvs, evs, level, isCatchable)
        {

        }
    }
}
