using Pokemon.SupportingObjects.Enums;
using Pokemon.SupportingObjects.Struct;

namespace Pokemon.Types.Subtype
{
    public class TrainerOwnedPokemon : ActivePokemon
    {
        public TrainerOwnedPokemon(int pokemonId, Stats initialIvs, Stats evs, int level, Nature nature) : 
            base(pokemonId, initialIvs, evs, level, nature, false)
        {

        }
    }
}
