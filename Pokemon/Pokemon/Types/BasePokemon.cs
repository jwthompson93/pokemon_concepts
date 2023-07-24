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
    }
}
