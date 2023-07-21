using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
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
        public BasePokemon(int pokedexNo, string name, Stats baseStats, Stats evYield, float height, float weight, int catchRate) {
            this.PokedexNo = pokedexNo;
            this.Name = name;
            this.BaseStats = baseStats;
            this.EvYield = evYield;
            this.Height = height;
            this.Weight = weight;
            this.CatchRate = catchRate;
        }
    }
}
