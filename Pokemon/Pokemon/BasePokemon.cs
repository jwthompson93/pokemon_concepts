using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class BasePokemon
    {
        public int pokedexNo;
        public string name;

        public Stats baseStats;
        public Stats evYield;

        public float height;
        public float weight;

        public int catchRate;


        public BasePokemon() { }
        public BasePokemon(int pokedexNo, string name, Stats baseStats, Stats evYield, float height, float weight, int catchRate) {
            this.pokedexNo = pokedexNo;
            this.name = name;
            this.baseStats = baseStats;
            this.evYield = evYield;
            this.height = height;
            this.weight = weight;
            this.catchRate = catchRate;
        }
    }
}
