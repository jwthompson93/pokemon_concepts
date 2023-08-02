using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Pokemon.Singleton
{
    public class PokemonStateChangeSingleton
    {
        public PlayerOwnedPokemon CaptureWildPokemon(WildPokemon wildPokemon)
        {
            PlayerOwnedPokemon playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.BasePokemon.Id, wildPokemon.InitialIvs, wildPokemon.Evs, wildPokemon.Level, false);

            return playerOwnedPokemon;
        }

        public PlayerOwnedPokemon HatchPokemon(EggPokemon eggPokemon)
        {
            PlayerOwnedPokemon playerOwnedPokemon = new PlayerOwnedPokemon(eggPokemon.BasePokemon.Id, eggPokemon.InitialIvs, eggPokemon.Evs, 1, false);

            return playerOwnedPokemon;
        }
    }
}
