using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon
{
    public class PokemonConstants
    {
        public static Dictionary<int, BasePokemon> pokemon;
        private static PokemonConstants instance;

        public static PokemonConstants getInstance()
        {
            if(instance == null)
            {
                instance = new PokemonConstants();
            }

            return instance;
        }

        private PokemonConstants()
        {
            pokemon = new Dictionary<int, BasePokemon>();
            pokemon.Add(1, new BasePokemon {
                name = "Bulbasaur",
                pokedexNo = 1,
                baseStats = new Stats
                {
                    hp = 45,
                    atk = 49,
                    def = 49,
                    spatk = 65,
                    spdef = 65,
                    spd = 45
                },
                evYield = new Stats { 
                    hp = 0,
                    atk = 0,
                    def = 0,
                    spatk = 1,
                    spdef = 0,
                    spd = 0
                },
                height = 0.7f,
                weight = 6.9f,
                catchRate = 45,
            });
        }

        public BasePokemon GetPokemon(int id)
        {
            return pokemon[id];
        }
    }
}
