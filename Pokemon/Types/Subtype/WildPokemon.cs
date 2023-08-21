using Pokemon.Singleton;
using Pokemon.Enums;
using Pokemon.Struct;

namespace Pokemon.Types.Subtype
{
    public class WildPokemon : ActivePokemon
    {
        public WildPokemon(int pokemonId, int level) : base(pokemonId, level, true)
        {
            InitialIvs = new Stats(
                RandomSingleton.GetInstance().GetRandomInteger(0, 31),
                RandomSingleton.GetInstance().GetRandomInteger(0, 31),
                RandomSingleton.GetInstance().GetRandomInteger(0, 31),
                RandomSingleton.GetInstance().GetRandomInteger(0, 31),
                RandomSingleton.GetInstance().GetRandomInteger(0, 31),
                RandomSingleton.GetInstance().GetRandomInteger(0, 31)
            );
            Evs = new Stats(0, 0, 0, 0, 0, 0);
            Nature = (Nature)RandomSingleton.GetInstance().GetRandomInteger(0, Enum.GetValues(typeof(Nature)).Length);
        }

        public new string PrintPokemon()
        {
            return base.PrintPokemon();
        }
    }
}
