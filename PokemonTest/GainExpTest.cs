using Pokemon.Pokemon.Constants;
using Pokemon.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Pokemon.Types;

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
            playerOwnedPokemon = new PlayerOwnedPokemon(wildPokemon.ActivePokemon);
        }

        [Test]
        public void TestGainExp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(43);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", (GrowthRateConstants.GetInstance().CalculateGrowthRateUntilNextLevel(playerOwned.ActivePokemon.Level + 1, playerOwned.ActivePokemon.BasePokemon.GrowthRate) - playerOwned.Exp));
            Assert.True(playerOwned.Exp == 178);
        }

        [Test]
        public void TestGainExpAndLevelUp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(96);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", (GrowthRateConstants.GetInstance().CalculateGrowthRateUntilNextLevel(playerOwned.ActivePokemon.Level + 1, playerOwned.ActivePokemon.BasePokemon.GrowthRate) - playerOwned.Exp));
            Assert.True(playerOwned.Exp == 231 && playerOwned.ActivePokemon.Level == 6);
        }

        [Test]
        public void TestGainExpAndExactLevelUp()
        {
            PlayerOwnedPokemon playerOwned = playerOwnedPokemon;
            playerOwned.GainExp(101);
            Console.WriteLine(playerOwned.PrintPokemon());
            Console.WriteLine("Exp until next level: {0}", (GrowthRateConstants.GetInstance().CalculateGrowthRateUntilNextLevel(playerOwned.ActivePokemon.Level + 1, playerOwned.ActivePokemon.BasePokemon.GrowthRate) - playerOwned.Exp));
            Assert.True(playerOwned.Exp == 236 && playerOwned.ActivePokemon.Level == 7);
        }
    }
}
