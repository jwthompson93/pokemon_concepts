using Pokemon.Enums;
using Pokemon.Types;

namespace Pokemon.Constants
{
    public class PokemonConstants
    {
        public static Dictionary<int, BasePokemon> Pokemon;
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
            Pokemon = new Dictionary<int, BasePokemon>();
            Pokemon.Add(1, new BasePokemon
            {
                Name = "Bulbasaur",
                Id = 1,
                BaseStats = new Stats
                {
                    Hp = 45,
                    Atk = 49,
                    Def = 49,
                    Spatk = 65,
                    Spdef = 65,
                    Spd = 45
                },
                EvYield = new Stats
                {
                    Hp = 0,
                    Atk = 0,
                    Def = 0,
                    Spatk = 1,
                    Spdef = 0,
                    Spd = 0
                },
                Height = 0.7f,
                Weight = 6.9f,
                CatchRate = 45,
                GrowthRate = GrowthRate.MEDIUM_SLOW
            });
        }

        public BasePokemon GetPokemon(int id)
        {
            return Pokemon[id];
        }
    }
}
