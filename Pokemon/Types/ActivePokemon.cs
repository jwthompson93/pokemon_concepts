using Pokemon.Constants;
using Pokemon.Enums;

namespace Pokemon.Types
{
    public abstract class ActivePokemon
    {
        public BasePokemon BasePokemon { get; protected set; }
        public Stats InitialIvs { get; protected set; }
        public Stats Evs { get; set; }
        public Stats Stats { get; set; }
        public int Level { get; set; }
        public int Friendship { get; set; }
        public int CurrentHp { get; set; }
        public Nature Nature { get; set; }
        public bool IsCatchable { get; protected set; }

        // Used for initialising PlayerOwnedPokemon
        public ActivePokemon(int pokemonId, Stats initialIvs, int level)
        {
            BasePokemon = PokemonConstants.GetInstance().GetPokemon(pokemonId);
            InitialIvs = initialIvs;
            Evs = new Stats();
            Level = level;
            IsCatchable = true;
            Friendship = 70;
        }

        // Used as base for WildPokemon and EggPokemon
        public ActivePokemon(int pokemonId, int level, bool isCatchable)
        {
            BasePokemon = PokemonConstants.GetInstance().GetPokemon(pokemonId);
            Level = level;
            IsCatchable = isCatchable;
        }

        // Used as base for TrainerOwnedPokemon, PlayerOwnedPokemon as well as being used for WildPokemon
        public ActivePokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : this(pokemonId, initialIvs, level)
        {
            Evs = evs;
            IsCatchable = isCatchable;
        }

        public string PrintPokemon()
        {
            return BasePokemon.PrintPokemon() +
                $"Initial IVs:\t{InitialIvs.PrintStats()}\n" +
                $"EVs:\t{Evs.PrintStats()}\n" +
                $"Level:\t{Level}\n" +
                $"Is Catchable?:\t{IsCatchable}\n";
        }
    }
}
