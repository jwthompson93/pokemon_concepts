using Pokemon.SupportingObjects.Enums;
using Pokemon.SupportingObjects.Struct;

namespace Pokemon.Types
{
    // The BasePokemon class contains information for static Pokemon values (values that all Pokemon of the same species have)

    public class BasePokemon
    {
        public int Id { get; }
        public string Name { get; }

        public Stats BaseStats { get; }
        public Stats EvYield { get; }

        public float Height { get; }
        public float Weight { get; }

        public int CatchRate { get; }
        public GrowthRate GrowthRate { get; }

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
