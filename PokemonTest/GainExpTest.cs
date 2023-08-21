﻿using Pokemon.Types.Subtype;

namespace PokemonTest
{
    internal class GainExpTest
    {
        private WildPokemon wildPokemon;
        private PlayerOwnedPokemon playerOwnedPokemon;

        [SetUp]
        public void Setup()
        {
            wildPokemon = new WildPokemon(1, 5);
            playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.BasePokemon.Id, wildPokemon.InitialIvs, wildPokemon.Evs, wildPokemon.Level, wildPokemon.Nature, false);
        }

        [Test]
        public void TestGainExp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(43);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", playerOwned.growthRate.Calculate(playerOwned.Level + 1));
            Assert.That(playerOwned.Exp, Is.EqualTo(178));
        }

        [Test]
        public void TestGainExpAndLevelUp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(96);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", playerOwned.growthRate.Calculate(playerOwned.Level + 1));
            Assert.True(playerOwned.Exp == 231 && playerOwned.Level == 6);
        }

        [Test]
        public void TestGainExpAndExactLevelUp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(101);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", playerOwned.growthRate.Calculate(playerOwned.Level + 1));
            Assert.True(playerOwned.Exp == 236 && playerOwned.Level == 7);
        }
    }
}
