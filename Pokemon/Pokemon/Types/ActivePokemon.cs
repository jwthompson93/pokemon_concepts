using Pokemon.Pokemon.Constants;

namespace Pokemon.Pokemon.Types
{
    public class ActivePokemon
    {

        public ActivePokemon(int pokemonId, Stats initialIvs, Stats evs, int level, bool isCatchable)
        {
            BasePokemonStats = PokemonConstants.GetInstance().GetPokemon(pokemonId);
            InitialIvs = initialIvs;
            Evs = evs;
            Level = level;
            IsCatchable = isCatchable;
        }

        public BasePokemon BasePokemonStats { get; protected set; }

        public Stats InitialIvs { get; }
        public Stats Evs { get; set; }
        public int Level { get; set; }

        public bool IsCatchable { get; internal set; }

        public string PrintPokemon()
        {
            return this.BasePokemonStats.PrintPokemon() +
                $"Initial IVs:\t{InitialIvs.PrintStats()}\n" +
                $"EVs:\t{Evs.PrintStats()}\n" +
                $"Level:\t{Level}\n" +
                $"Is Catchable?:\t{IsCatchable}\n";
        }
    }
}
