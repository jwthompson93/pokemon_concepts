using Pokemon.Pokemon.Constants;

namespace Pokemon.Pokemon.Types
{
    public class BasePokemon
    {
        public int PokedexNo;
        public string Name;

        public Stats BaseStats;
        public Stats EvYield;

        public float Height;
        public float Weight;

        public int CatchRate;


        public BasePokemon() { }
        public BasePokemon(int pokedexNo, string name, Stats baseStats, Stats evYield, float height, float weight, int catchRate)
        {
            PokedexNo = pokedexNo;
            Name = name;
            BaseStats = baseStats;
            EvYield = evYield;
            Height = height;
            Weight = weight;
            CatchRate = catchRate;
        }

        public string PrintPokemon()
        {
            return
                $"Name:\t{this.Name}\n" +
                $"Pokedex No.:\t{this.PokedexNo}\n" +
                $"Base Stats:\t{this.BaseStats.PrintStats()}\n" +
                $"EV Yield:\t{this.EvYield.PrintStats()}\n" +
                $"Height:\t{this.Height}\n" +
                $"Weight:\t{this.Weight}\n" +
                $"Catch Rate:\t{this.CatchRate}\n";
        }
    }
}
