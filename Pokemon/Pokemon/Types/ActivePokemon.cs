using Pokemon.Pokemon.Constants;

namespace Pokemon.Pokemon.Types
{
    public class ActivePokemon
    {
        public ActivePokemon(int pokemonId, Stats initialIvs, int level)
        {
            BasePokemon = PokemonConstants.GetInstance().GetPokemon(pokemonId);
            InitialIvs = initialIvs;
            Evs = new Stats();
            Level = level;
            IsCatchable = true;
            Friendship = 70;
        }

        public ActivePokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable) : this(pokemonId, initialIvs, level)
        {
            Evs = evs;
            IsCatchable = isCatchable;
        }

        public BasePokemon BasePokemon { get; protected set; }

        public Stats InitialIvs { get; }
        public Stats Evs { get; set; }
        public Stats Stats { get; set; }
        public int Level { get; set; }
        public int Friendship { get; set; }
        public int CurrentHp { get; set; }

        public bool IsCatchable { get; internal set; }

        public string PrintPokemon()
        {
            return this.BasePokemon.PrintPokemon() +
                $"Initial IVs:\t{InitialIvs.PrintStats()}\n" +
                $"EVs:\t{Evs.PrintStats()}\n" +
                $"Level:\t{Level}\n" +
                $"Is Catchable?:\t{IsCatchable}\n";
        }
    }
}
