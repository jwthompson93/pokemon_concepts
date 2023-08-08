using Pokemon.Constants;

namespace Pokemon.Types
{
    public class BasePokemon
    {
        public int Id;
        public string Name;

        public Stats BaseStats;
        public Stats EvYield;

        public float Height;
        public float Weight;

        public int CatchRate;
        public GrowthRate GrowthRate;


        public BasePokemon() { }
        public BasePokemon(int id, string name, Stats baseStats, Stats evYield, float height, float weight, int catchRate, GrowthRate growthRate)
        {
            Id = id;
            Name = name;
            BaseStats = baseStats;
            EvYield = evYield;
            Height = height;
            Weight = weight;
            CatchRate = catchRate;
            GrowthRate = growthRate;
        }

        public string PrintPokemon()
        {
            return
                $"Name:\t{this.Name}\n" +
                $"Pokedex No.:\t{this.Id}\n" +
                $"Base Stats:\t{this.BaseStats.PrintStats()}\n" +
                $"EV Yield:\t{this.EvYield.PrintStats()}\n" +
                $"Height:\t{this.Height}\n" +
                $"Weight:\t{this.Weight}\n" +
                $"Catch Rate:\t{this.CatchRate}\n" +
                $"Growth Rate:\t{this.GrowthRate}\n";
        }
    }
}
