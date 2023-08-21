using Pokemon.Enums;
using Pokemon.Types;
using Pokemon.Struct;

namespace Pokemon.Constants
{
    public class PokemonConstants
    {
        private Dictionary<int, BasePokemon> Pokemon;
        private static PokemonConstants _instance;

        public static PokemonConstants GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PokemonConstants();
            }

            return _instance;
        }

        private PokemonConstants()
        {
            Pokemon = new Dictionary<int, BasePokemon>
            {
                {   1, 
                    new BasePokemon
                    (
                        1, // Pokemon ID
                        "Bulbasaur", // Name
                        new Stats // Base Stats
                        {
                            Hp = 45,
                            Atk = 49,
                            Def = 49,
                            Spatk = 65,
                            Spdef = 65,
                            Spd = 45
                        },
                        new Stats // EV Yields
                        {
                            Hp = 0,
                            Atk = 0,
                            Def = 0,
                            Spatk = 1,
                            Spdef = 0,
                            Spd = 0
                        },
                        0.7f, // Height
                        6.9f, // Weight
                        45, // Catch Rate
                        GrowthRate.MEDIUM_SLOW // GrowthRate
                    ) 
                }
            };
        }

        public BasePokemon GetPokemon(int id)
        {
            return Pokemon[id];
        }
    }
}
