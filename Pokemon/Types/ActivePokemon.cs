using Pokemon.Constants;
using Pokemon.Enums;
using Pokemon.Struct;

namespace Pokemon.Types
{
    public abstract class ActivePokemon
    {
        // The ActivePokemon class is an abstract class used for all Pokemon that can be seen (becomes 'active')
        // e.g. A wild Pokemon, a Trainer's Pokemon, a Player's Pokemon

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
        public ActivePokemon(int pokemonId, Stats initialIvs, Stats evs, int level, Nature nature, bool isCatchable) : this(pokemonId, initialIvs, level)
        {
            Evs = evs;
            IsCatchable = isCatchable;
            Nature = nature;
        }

        public string PrintPokemon()
        {
            return BasePokemon.PrintPokemon() +
                $"Initial IVs:\t{InitialIvs.PrintStats()}\n" +
                $"EVs:\t{Evs.PrintStats()}\n" +
                $"Level:\t{Level}\n" +
                $"Nature:\t{Nature}\n" +
                $"Is Catchable?:\t{IsCatchable}\n";
        }
    }
}
