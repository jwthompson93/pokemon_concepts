﻿using Pokemon.Types.Subtype;

namespace Pokemon.SupportingObjects.Singleton
{
    public class PokemonStateChangeSingleton
    {
        private static PokemonStateChangeSingleton _instance;

        private PokemonStateChangeSingleton() { }

        public static PokemonStateChangeSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new PokemonStateChangeSingleton();
            }

            return _instance;
        }

        public PlayerOwnedPokemon CaptureWildPokemon(WildPokemon wildPokemon)
        {
            PlayerOwnedPokemon playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.BasePokemon.Id, wildPokemon.InitialIvs, wildPokemon.Evs, wildPokemon.Level, wildPokemon.Nature, false);

            return playerOwnedPokemon;
        }

        public PlayerOwnedPokemon HatchPokemon(EggPokemon eggPokemon)
        {
            PlayerOwnedPokemon playerOwnedPokemon = new PlayerOwnedPokemon(eggPokemon.BasePokemon.Id, eggPokemon.InitialIvs, eggPokemon.Evs, eggPokemon.Level, eggPokemon.Nature, false);

            return playerOwnedPokemon;
        }
    }
}