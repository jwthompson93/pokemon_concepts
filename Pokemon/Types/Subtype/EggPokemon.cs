using Pokemon.SupportingObjects.Enums;
using Pokemon.SupportingObjects.Singleton;
using Pokemon.SupportingObjects.Struct;

namespace Pokemon.Types.Subtype
{
    public class EggPokemon : ActivePokemon
    {
        public EggPokemon(int id) : base(id, 1, false)
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
